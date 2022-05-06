using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Uniforms
{
    public partial class Postavschiki_add : Form
    {
        public Postavschiki_add()
        {
            InitializeComponent();
            lb_notify.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Postavschiki postavschiki = new Postavschiki();
            postavschiki.Show();
            postavschiki.Location = Location;
        }

        private void Postavschiki_add_FormClosing(object sender, FormClosingEventArgs e)
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
            try
            {
                if (tb_name.Text == "")
                {
                    MessageBox.Show("Введите наименование корректно!", "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_contact_face.Text == "")
                {
                    MessageBox.Show("Введите ФИО корректно!", "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mb_phone.MaskCompleted == false || mb_phone.Text.Substring(0, 5) != "+7 (9")
                {
                    MessageBox.Show("Введите корректный номер телефона!", "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_inn.Text == "" || Regex.IsMatch(tb_inn.Text.Substring(0), @"^[0-9]+$") == false || tb_inn.Text.Length != 12)
                {
                    MessageBox.Show("Введите ИНН корректно!", "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    check = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Проверьте введённые данные!", "Добавление поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление данных в БД
        /// </summary>
        private void fillTable()
        {
            SqlCommand command = new SqlCommand("INSERT INTO postavschiki VALUES(@name, @contact, @tel, @inn)", Other.connect());
            command.Parameters.AddWithValue("name", tb_name.Text);
            command.Parameters.AddWithValue("contact", tb_contact_face.Text);
            command.Parameters.AddWithValue("tel", mb_phone.Text);
            command.Parameters.AddWithValue("inn", tb_inn.Text);
            command.ExecuteNonQuery();
            Other.diagWrite("Добавление поставщика: " + tb_name.Text);
        }
    }
}
