using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Uniforms
{
    public partial class Uniforms_change : Form
    {
        public Uniforms_change()
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

        private void Uniforms_change_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_change_Click(object sender, EventArgs e)
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
            try
            {
                if (cb_name.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите вид формы из списка!", "Приём спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_sotrudnik.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите сотрудника из списка!", "Приём спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_count.Text == "" || Regex.IsMatch(tb_count.Text.Substring(0), @"^[0-9]+$") == false)
                {
                    MessageBox.Show("Введите количество корректно!", "Приём спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mb_change.MaskCompleted == false)
                {
                    MessageBox.Show("Введите дату сдачи корректно!", "Приём спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    check = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Проверьте введённые данные!", "Приём спецодежды", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление данных в БД
        /// </summary>
        private void fillTable()
        {
            SqlCommand command = new SqlCommand("INSERT INTO change_uniforms VALUES(@uniform, @sotrudnik, @change, @count)", Other.connect());
            command.Parameters.AddWithValue("uniform", cb_name.SelectedIndex + 1);
            command.Parameters.AddWithValue("sotrudnik", cb_sotrudnik.SelectedIndex + 1);
            command.Parameters.AddWithValue("change", mb_change.Text);
            command.Parameters.AddWithValue("count", tb_count.Text);
            command.ExecuteNonQuery();

            command = new SqlCommand("UPDATE Uniforms SET Kol_vo = (SELECT Kol_vo FROM uniforms WHERE Kod_uniform = @uniform)+@count WHERE Kod_uniform = @uniform", Other.connect());
            command.Parameters.AddWithValue("count", Convert.ToInt32(tb_count.Text));
            command.Parameters.AddWithValue("uniform", cb_name.SelectedIndex + 1);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Заполнение ComboBox
        /// </summary>
        private void cbFill()
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM uniforms", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_name.Items.Add(sqlReader["Names"]);
            }

            command = new SqlCommand("SELECT * FROM sotrudniki", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_sotrudnik.Items.Add(sqlReader["Surname"] + " " + sqlReader["Names"] + " " + sqlReader["Patronymic"]);
            }
            sqlReader.Close();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Hide();
            Uniforms uniforms = new Uniforms();
            uniforms.Show();
            uniforms.Location = Location;
        }
    }
}