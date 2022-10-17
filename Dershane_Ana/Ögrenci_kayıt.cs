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
    public partial class Ögrenci_kayıt : Form
    {
        public Ögrenci_kayıt()
        {
            InitializeComponent();
        }

        private void Ogrenci_ekle_Click(object sender, EventArgs e)
        {
            //ekle
            string cümle = $"insert into Ogrenci_kayıt(Ogrenci_ad_ekle,Ogrenci_no_ekle,Ogrenci_branş) values('{txtOgrenci_ad.Text}',{txtOgrenci_no.Text},'{com_Ogrenci_branş.Text}')";
            SqlCommand komut2 = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut2, cümle);
           
            
        }

        private void Ogrenci_sil_Click(object sender, EventArgs e)
        {//sil
            string cümle = $"delete from Ogrenci_kayıt where Ogrenci_ad_ekle ='{txtOgrenci_ad.Text}'";
            SqlCommand komut = new SqlCommand();
            Dershane dershane = new Dershane();
            dershane.ekle_sil_güncelle(komut, cümle);
        }
    }
}
