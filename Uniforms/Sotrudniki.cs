using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Uniforms
{
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
            cb_filtr.Items.Add("Фамилия");
            cb_filtr.Items.Add("Отдел");
            cb_filtr.Items.Add("Должность");
            cb_filtr.Items.Add("Профессия");

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela", Other.connect());
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Hide();
            Sotrudniki_add add = new Sotrudniki_add();
            add.Show();
            add.Location = Location;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Choose choose = new Choose();
            choose.Show();
            choose.Location = Location;
        }

        private void Sotrudniki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter dataAdapter;
            if (cb_filtr.Text == "Фамилия")
            {
                command = new SqlCommand("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela WHERE Surname LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "Отдел")
            {
                command = new SqlCommand("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela WHERE Name_otdela LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "Профессия")
            {
                command = new SqlCommand("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela WHERE Name_professii LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "Должность")
            {
                command = new SqlCommand("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela WHERE Name_dolgnosti LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else
            {
                dataAdapter = new SqlDataAdapter("SELECT Kod_sotrudnika AS 'Код', Surname AS 'Фамилия', Names AS 'Имя', Patronymic AS 'Отчество', Date_birthday AS 'Дата рождения', Telephone AS 'Телефон', Name_professii AS 'Профессия', Name_dolgnosti AS 'Должность', Name_otdela AS 'Отдел' FROM sotrudniki INNER JOIN professii ON professii.Kod_professii = sotrudniki.Kod_professii INNER JOIN dolgnosti ON dolgnosti.Kod_dolgnosti = sotrudniki.Kod_dolgnosti INNER JOIN otdel ON otdel.Kod_otdela = sotrudniki.Kod_otdela", Other.connect());
            }
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
