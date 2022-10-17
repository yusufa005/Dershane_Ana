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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dershane_Ana
{
    public partial class Not_giris : Form
    {
        public Not_giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Not_giris_Load(object sender, EventArgs e)
        {
            listele();
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Ogrenci_kayıt";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comOgrenci_no_not.Items.Add(dr["Ogrenci_no_ekle"]);
            }
            baglanti.Close();
        }

        private void Ogrenci_ara_Click(object sender, EventArgs e)
        {

        }

        private void Not_ekle_Click(object sender, EventArgs e)
        {

            //ekle
            string cümle = $"insert into Not_giris(Ogrenci_ad_not,Ogrenci_no_not,Ders_not_adı,Ders_not_bölüm,Ders_öğretmen,sınav1,sınav2,Ortalama) values('{txtOgrenci_ad_not.Text}','{comOgrenci_no_not.Text}','{comNot_ders.Text}','{com_not_branş.Text}','{com_not_ogr.Text}','{txt_sınav1.Text}','{txt_sınav2.Text}','{txtOrtalama.Text}')"; 
            SqlCommand komut2 = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut2, cümle);
            listele();



        }



        private void Not_Sil_Click(object sender, EventArgs e)
        {
            //sil
            string cümle = $"delete from Not_giris where Ogrenci_no_not ='{comOgrenci_no_not.Text}'";
            SqlCommand komut = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut, cümle);
            listele();
        }

        private void Not_degistir_Click(object sender, EventArgs e)
        {
            string cümle = $"update Not_giris set Ders_not_adı='{comNot_ders.Text}', Ders_not_bölüm='{com_not_branş.Text}', Ders_öğretmen='{com_not_ogr.Text}', sınav1={txt_sınav1.Text}, sınav2={txt_sınav2.Text},Ortalama={txtOrtalama.Text}  where Ogrenci_no_not ='{comOgrenci_no_not.Text}'";
            SqlCommand komut = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut, cümle);
            listele();
        }

        private void comOgrenci_no_not_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_ort_Click(object sender, EventArgs e)
        {//ortalama
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(txt_sınav1.Text);
            sayi2 = Convert.ToInt16(txt_sınav2.Text);
            sonuc = (sayi1 + sayi2)/2;
            txtOrtalama.Text =  sonuc.ToString();
        }
        public void listele()
        {
            //listeleme
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");

            baglanti.Open();
            string kayit = "select * from Not_giris";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Not_giriş_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comOgrenci_no_not_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Ogrenci_kayıt where Ogrenci_no_ekle=" + comOgrenci_no_not.Text;
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtOgrenci_ad_not.Text = dr["Ogrenci_ad_ekle"].ToString();
            }
            baglanti.Close();
        }
    }
}
    
    

