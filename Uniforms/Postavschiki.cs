using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uniforms
{
    public partial class Postavschiki : Form
    {
        public Postavschiki()
        {
            InitializeComponent();
            cb_filtr.Items.Add("Наименование");
            cb_filtr.Items.Add("Контактное лицо");
            cb_filtr.Items.Add("ИНН");

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod_postavschika AS 'Код', Name_postavschika AS 'Наименование', FIO_contact_face AS 'Контактное лицо', Telephone_contact_face AS 'Телефон', INN AS 'ИНН' FROM postavschiki", Other.connect());
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
            Postavschiki_add add = new Postavschiki_add();
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

        private void Postavschiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter dataAdapter;
            if (cb_filtr.Text == "Наименование")
            {
                command = new SqlCommand("SELECT Kod_postavschika AS 'Код', Name_postavschika AS 'Наименование', FIO_contact_face AS 'Контактное лицо', Telephone_contact_face AS 'Телефон', INN AS 'ИНН' FROM postavschiki WHERE Name_postavschika LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "Контактное лицо")
            {
                command = new SqlCommand("SELECT Kod_postavschika AS 'Код', Name_postavschika AS 'Наименование', FIO_contact_face AS 'Контактное лицо', Telephone_contact_face AS 'Телефон', INN AS 'ИНН' FROM postavschiki WHERE FIO_contact_face LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "ИНН")
            {
                command = new SqlCommand("SELECT Kod_postavschika AS 'Код', Name_postavschika AS 'Наименование', FIO_contact_face AS 'Контактное лицо', Telephone_contact_face AS 'Телефон', INN AS 'ИНН' FROM postavschiki WHERE INN LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else
            {
                dataAdapter = new SqlDataAdapter("SELECT Kod_postavschika AS 'Код', Name_postavschika AS 'Наименование', FIO_contact_face AS 'Контактное лицо', Telephone_contact_face AS 'Телефон', INN AS 'ИНН' FROM postavschiki", Other.connect());
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
