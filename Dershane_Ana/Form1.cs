using System.Security.Cryptography;

namespace Dershane_Ana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Karne_Click(object sender, EventArgs e)
        {
            Genel_rapor frm = new Genel_rapor();
            frm.ShowDialog();
        }

        private void C�k�s_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ogretmen_Kyt_Click(object sender, EventArgs e)
        {
            Ogretmen_kay�t frm= new Ogretmen_kay�t();
            frm.Show();

        }

        private void Ogrenci_Kyt_Click(object sender, EventArgs e)
        {
            �grenci_kay�t frm = new �grenci_kay�t();
            frm.Show();
        }

        private void Ders_Kyt_Click(object sender, EventArgs e)
        {
            Ders_kay�t frm = new Ders_kay�t();
            frm.Show();
        }

        private void Not_grs_Click(object sender, EventArgs e)
        {
            Not_giris frm = new Not_giris();
            frm.Show();
        }

        private void Ogretmen_Kyt_Click_1(object sender, EventArgs e)
        {
            Ogretmen_kay�t frm = new Ogretmen_kay�t();
            frm.Show();
        }

        private void C�k�s_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ogrenci_Kyt_Click_1(object sender, EventArgs e)
        {
            �grenci_kay�t frm = new �grenci_kay�t();
            frm.Show();
        }

        private void Ders_Kyt_Click_1(object sender, EventArgs e)
        {
            Ders_kay�t frm = new Ders_kay�t();
            frm.Show();






        }

        private void Not_grs_Click_1(object sender, EventArgs e)
        {
            Not_giris frm = new Not_giris();
            frm.Show();
        }

        private void Karne_Click_1(object sender, EventArgs e)
        {
            Genel_rapor frm = new Genel_rapor();
            frm.Show();
        }
    }
}