using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Uniforms
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            lb_check.Visible = false;
            lb_check_login.Visible = false;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (tb_login.Text == "" || tb_password.Text == "")
            {
                Other.getTimer(lb_check);
            }
            else
            {
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT login, password FROM logined", Other.connect());
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (tb_login.Text == Convert.ToString(sqlReader["login"]))
                    {
                        check = true;
                    }
                }
                sqlReader.Close();
                if (tb_login.Text == "administrator")
                {
                    check = true;
                }
                if (check)
                {
                    Other.getTimer(lb_check_login);
                    Other.diagWrite("Попытка регистрации с уже существующим логином: " + tb_login.Text);
                }
                else
                {
                    command = new SqlCommand("INSERT INTO logined VALUES(@log, @pas)", Other.connect());
                    command.Parameters.AddWithValue("log", tb_login.Text);
                    command.Parameters.AddWithValue("pas", tb_password.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Trace.WriteLine("Логин: " + tb_login.Text + "\nПароль: " + tb_password.Text);
                    Hide();
                    Choose choose = new Choose();
                    choose.Show();
                    choose.Location = Location;
                    Other.diagWrite("Успешная регистрация\nЛогин: " + tb_password.Text + "\nПароль: " + tb_password.Text);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Avtor avtor = new Avtor();
            avtor.Show();
            avtor.Location = Location;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}