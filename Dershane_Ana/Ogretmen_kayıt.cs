using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Dershane_Ana
{
    public partial class Ogretmen_kayıt : Form
    {
        public Ogretmen_kayıt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//sil
            string cümle = $"delete from Ogretmen_kayıt where Ogr_Ad_soyad ='{txtAd_soyad.Text}'";
            SqlCommand komut = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut, cümle);
            listele();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ogretmen_ekle_Click(object sender, EventArgs e)
        {//ekle
            string cümle = $"insert into Ogretmen_kayıt(Ogr_Ad_soyad,Ogr_tc_no,Ogr_Branş) values('{txtAd_soyad.Text}',{txt_tc.Text},'{com_branş.Text}')";
            SqlCommand komut2 = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut2, cümle);
            listele();

        }
        public void listele()
        {
            //listeleme
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");

            baglanti.Open();
            string kayit = "select * from Ogretmen_kayıt";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Ogretmen_kayıt_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
