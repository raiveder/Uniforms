using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Uniforms
{
    internal class Other
    {

        /// <summary>
        /// Запуск таймера
        /// </summary>
        /// <param name="lb">label, запускаемый на время</param>
        public static void getTimer(Label lb)
        {
            Timer timer = new Timer();
            lb.Visible = true;
            timer.Interval = 2000;
            timer.Start();
            timer.Tick += new EventHandler(time_Tick);

            void time_Tick(object sender, EventArgs e)
            {
                lb.Visible = false;
            }
        }
        
        /// <summary>
        /// Соединение с БД
        /// </summary>
        public static SqlConnection connect()
        {
            string location = Environment.CurrentDirectory;
            location = location.Remove(location.Length - 9, 9);
            location = location.Insert(location.Length, "Database1.mdf");
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + location + ";Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        /// <summary>
        /// Запуск программы
        /// </summary>
        public static void firstRun()
        {
            string location = Environment.CurrentDirectory;
            location = location.Insert(location.Length, "\\Diagnostic.txt");
            FileStream file = new FileStream(location, FileMode.Create);
            file.Close();

            try
            {
                SqlConnection sqlConnection;
                location = location.Remove(location.Length - 14, 14);
                location = location.Insert(location.Length, "Database1.mdf");
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + location + ";Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                MessageBox.Show("Подключение установлено!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Не удалось установить подключение!\nДля входа в режиме разработчика введите\nЛогин: administrator\nПароль: admin", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Запись строки в файл Diagnostic
        /// </summary>
        /// <param name="s">Строка для записи в файл</param>
        public static void diagWrite(string s)
        {
            TextWriterTraceListener tr = new TextWriterTraceListener(File.AppendText("Diagnostic.txt"));
            Debug.Listeners.Add(tr);
            Debug.WriteLine(s);
            Debug.Flush();
            tr.Close();
        }
    }
}
