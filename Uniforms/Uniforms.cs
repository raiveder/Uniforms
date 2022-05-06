using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Uniforms
{
    public partial class Uniforms : Form
    {

        public Uniforms()
        {
            InitializeComponent();
            cb_filtr.Items.Add("Вид формы");
            cb_filtr.Items.Add("Количество");

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod_uniform AS 'Код', uniforms.Names AS 'Наименование', vid_uniforms.Names AS 'Вид', Cost AS 'Стоимость', Kol_vo AS 'Количество', Srok_use AS 'Срок использования' FROM uniforms INNER JOIN vid_uniforms ON vid_uniforms.Kod_vida = uniforms.Kod_vida", Other.connect());
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
            Uniforms_add add = new Uniforms_add();
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

        private void btn_change_Click(object sender, EventArgs e)
        {
            Hide();
            Uniforms_change change = new Uniforms_change();
            change.Show();
            change.Location = Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Uniforms_give give = new Uniforms_give();
            give.Show();
            give.Location = Location;
        }

        private void Uniforms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter dataAdapter;
            if (cb_filtr.Text == "Вид формы")
            {
                command = new SqlCommand("SELECT Kod_uniform AS 'Код', uniforms.Names AS 'Наименование', vid_uniforms.Names AS 'Вид', Cost AS 'Стоимость', Kol_vo AS 'Количество', Srok_use AS 'Срок использования' FROM uniforms INNER JOIN vid_uniforms ON vid_uniforms.Kod_vida = uniforms.Kod_vida WHERE vid_uniforms.Names LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", "%" + tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else if (cb_filtr.Text == "Количество")
            {
                command = new SqlCommand("SELECT Kod_uniform AS 'Код', uniforms.Names AS 'Наименование', vid_uniforms.Names AS 'Вид', Cost AS 'Стоимость', Kol_vo AS 'Количество', Srok_use AS 'Срок использования' FROM uniforms INNER JOIN vid_uniforms ON vid_uniforms.Kod_vida = uniforms.Kod_vida WHERE Cost LIKE @value", Other.connect());
                command.Parameters.AddWithValue("value", tb_filtr.Text + "%");
                dataAdapter = new SqlDataAdapter(command);
            }
            else
            {
                dataAdapter = new SqlDataAdapter("SELECT Kod_uniform AS 'Код', uniforms.Names AS 'Наименование', vid_uniforms.Names AS 'Вид', Cost AS 'Стоимость', Kol_vo AS 'Количество', Srok_use AS 'Срок использования' FROM uniforms INNER JOIN vid_uniforms ON vid_uniforms.Kod_vida = uniforms.Kod_vida", Other.connect());
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
