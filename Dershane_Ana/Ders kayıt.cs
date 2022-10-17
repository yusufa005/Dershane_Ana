using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Ana
{
    public partial class Ders_kayıt : Form
    {
        public Ders_kayıt()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ders_ekle_Click(object sender, EventArgs e)
        {
            //ekle
            string cümle = $"insert into Ders_kayıt(Ders_adı,Ders_bölüm) values('{comDers_ad.Text}','{comDers_branş.Text}')";
            SqlCommand komut2 = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut2, cümle);
            listele();
        }

        private void Ders_Sil_Click(object sender, EventArgs e)
        {
            //sil
            string cümle = $"delete from Ders_kayıt where Ders_adı ='{comDers_ad.Text}'";
            SqlCommand komut = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut, cümle);
            listele();
        }

        public void listele()
        {
            //listeleme
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");

            baglanti.Open();
            string kayit = "select * from Ders_kayıt";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Ders_kayıt_Load(object sender, EventArgs e)
        {
          
        }

        private void Ders_kayıt_Load_1(object sender, EventArgs e)
        {
  listele();
        }
    }
    }

