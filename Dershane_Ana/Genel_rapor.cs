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
    public partial class Genel_rapor : Form
    {
        public Genel_rapor()
        {
            InitializeComponent();
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
        private void Genel_rapor_Load(object sender, EventArgs e)
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
                comboBox2.Items.Add(dr["Ogrenci_no_ekle"]);
            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");

            baglanti.Open();
            string kayit = "SELECT *FROM Not_giris where Ogrenci_no_not=" + comboBox2.Text;
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
