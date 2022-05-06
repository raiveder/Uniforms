using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Uniforms
{
    public partial class Avtor : Form
    {
        public Avtor()
        {
            InitializeComponent();
            lb_check.Visible = false;
            lb_check_login.Visible = false;
            lb_check_password.Visible = false;
        }

        private void btn_entry_Click(object sender, EventArgs e)
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
                    if (tb_login.Text == Convert.ToString(sqlReader["login"]) && tb_password.Text == Convert.ToString(sqlReader["password"]))
                    {
                        check = true;
                    }
                }
                sqlReader.Close();
                if (check)
                {
                    Hide();
                    Choose choose = new Choose();
                    choose.Show();
                    choose.Location = Location;
                    Other.diagWrite("Удачная авторизация");
                }
                else
                {
                    Other.getTimer(lb_check_password);
                    Debug.WriteLine(tb_password.Text);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Hide();
            Reg reg = new Reg();
            reg.Show();
            reg.Location = Location;
        }
    }
}