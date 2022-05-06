using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Uniforms
{
    public partial class Sotrudniki_add : Form
    {
        public Sotrudniki_add()
        {
            InitializeComponent();
            cbFill();
            lb_notify.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Sotrudniki sotrudniki = new Sotrudniki();
            sotrudniki.Show();
            sotrudniki.Location = Location;
        }

        private void Sotrudniki_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool check = false;
            checkData(ref check);
            if(check)
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
                if (tb_surname.Text == "" || Regex.IsMatch(tb_surname.Text.Substring(1), @"^[а-я]+$") == false || Regex.IsMatch(Convert.ToString(tb_surname.Text[0]), @"[А-Я]") == false)
                {
                    MessageBox.Show("Введите фамилию корректно!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_name.Text == "" || Regex.IsMatch(tb_name.Text.Substring(1), @"^[а-я]+$") == false || Regex.IsMatch(Convert.ToString(tb_name.Text[0]), @"[А-Я]") == false)
                {
                    MessageBox.Show("Введите имя корректно!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_patronimyc.Text == "" || Regex.IsMatch(tb_patronimyc.Text.Substring(1), @"^[а-я]+$") == false || Regex.IsMatch(Convert.ToString(tb_patronimyc.Text[0]), @"[А-Я]") == false)
                {
                    MessageBox.Show("Введите отчество корректно!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_dolgnost.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите должность из списка!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_otdel.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите отдел из списка!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_work.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите профессию из списка!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mb_birthdate.MaskCompleted == false || Convert.ToInt32(mb_birthdate.Text.Substring(0, 4)) < year - 80 || Convert.ToInt32(mb_birthdate.Text.Substring(0, 4)) > year
                    || Convert.ToInt32(mb_birthdate.Text.Substring(5, 2)) > 12 || Convert.ToInt32(mb_birthdate.Text.Substring(0, 4)) == year && Convert.ToInt32(mb_birthdate.Text.Substring(5, 2)) > month
                    || Convert.ToInt32(mb_birthdate.Text.Substring(0, 4)) == year && Convert.ToInt32(mb_birthdate.Text.Substring(5, 2)) == month && Convert.ToInt32(mb_birthdate.Text.Substring(8, 2)) > day)
                {
                    MessageBox.Show("Введите корректную дату рождения!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mb_phone.MaskCompleted == false || mb_phone.Text.Substring(0, 5) != "+7 (9")
                {
                    MessageBox.Show("Введите корректный номер телефона!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    check = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Проверьте введённые данные!", "Добавление сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление данных в БД
        /// </summary>
        private void fillTable()
        {
            SqlCommand command = new SqlCommand("INSERT INTO sotrudniki VALUES(@fam, @name, @otc, @date, @tel, @work, @dolg, @otdel)", Other.connect());
            command.Parameters.AddWithValue("fam", tb_surname.Text);
            command.Parameters.AddWithValue("name", tb_name.Text);
            command.Parameters.AddWithValue("otc", tb_patronimyc.Text);
            command.Parameters.AddWithValue("date", mb_birthdate.Text);
            command.Parameters.AddWithValue("tel", mb_phone.Text);
            command.Parameters.AddWithValue("work", cb_work.SelectedIndex + 1);
            command.Parameters.AddWithValue("dolg", cb_dolgnost.SelectedIndex + 1);
            command.Parameters.AddWithValue("otdel", cb_otdel.SelectedIndex + 1);
            command.ExecuteNonQuery();
            Other.diagWrite("Добавление сотрудника: " + tb_surname.Text + " " + tb_name.Text + " " + tb_patronimyc.Text);
        }
        
        /// <summary>
        /// Заполнение ComboBox
        /// </summary>
        private void cbFill()
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM dolgnosti", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_dolgnost.Items.Add(sqlReader["Name_dolgnosti"]);
            }

            command = new SqlCommand("SELECT * FROM otdel", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_otdel.Items.Add(sqlReader["Name_otdela"]);
            }

            command = new SqlCommand("SELECT * FROM professii", Other.connect());
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cb_work.Items.Add(sqlReader["Name_professii"]);
            }
            sqlReader.Close();
        }
    }
}