using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Uniforms
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btn_sotrudniki_Click(object sender, EventArgs e)
        {
            Hide();
            Sotrudniki sotrudniki = new Sotrudniki();
            sotrudniki.Show();
            sotrudniki.Location = Location;
            Debug.WriteLine("Выбрана ветка 'Сотрудники''");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Avtor avtor = new Avtor();
            avtor.Show();
            avtor.Location = Location;
        }

        private void btn_postavschiki_Click(object sender, EventArgs e)
        {
            Hide();
            Postavschiki postavschiki = new Postavschiki();
            postavschiki.Show();
            postavschiki.Location = Location;
            Debug.WriteLine("Выбрана ветка 'Поставщики''");
        }

        private void btn_uniforms_Click(object sender, EventArgs e)
        {
            Hide();
            Uniforms uniforms = new Uniforms();
            uniforms.Show();
            uniforms.Location = Location;
            Debug.WriteLine("Выбрана ветка 'Спецодежда''");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Choose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
