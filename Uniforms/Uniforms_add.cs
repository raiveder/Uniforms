using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Uniforms
{
    public partial class Uniforms_add : Form
    {
        public Uniforms_add()
        {
            InitializeComponent();
            cbFill();
            lb_notify.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Uniforms uniforms = new Uniforms();
            uniforms.Show();
            uniforms.Location = Location;
        }

        private void Uniforms_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool check = false;
            checkData(ref check);
            if (check)
            {
                fillTable();
                Other.getTimer(lb_notify);
            }
        }

        /// <summary>
        /// Проверка данных на корректность перед сохранением в БД
        /// </summary>
        /// <param name="check">Булевый параметр для проверки</param>
        private void checkData(ref bool check)
        {
            int year = DateTime.Now.Year - 14;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            try
            {
                if (tb_name.Text == "" || Regex.IsMatch(Convert.ToString(tb_name.Text[0]), @"[А-Я]") == false)
                {
                    MessageBox.Show("Введите название формы корректно!", "Добавление спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_vid.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите вид формы из списка!", "Добавление спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    check = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошабка. Проверьте введённые данные!", "Добавление спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление данных в БД
        /// </summary>
        private void fillTable()
        {
            SqlCommand command = new SqlCommand("INSERT INTO uniforms VALUES(@name, @vid, @cost, @count, @srok)", Other.connect());
            command.Parameters.AddWithValue("name", tb_name.Text);
            command.Parameters.AddWithValue("vid", cb_vid.SelectedIndex + 1);
            command.Parameters.AddWithValue("cost", tb_cost.Text);
            command.Parameters.AddWithValue("count", tb_count.Text);
            command.Parameters.AddWithValue("srok", tb_use.Text);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Заполнение ComboBox
        /// </summary>
        private void cbFill()
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM vid_uniforms", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_vid.Items.Add(sqlReader["Names"]);
            }
            sqlReader.Close();
        }
    }
}
