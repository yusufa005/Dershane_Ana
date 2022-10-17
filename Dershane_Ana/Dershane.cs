using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dershane_Ana
{
     class Dershane
    {
       SqlConnection baglanti = new SqlConnection("Data Source=YUSUFLAPTOP;Initial Catalog=Dershane;Integrated Security=True ");
        DataTable tablo;
            public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        { //sorgu kısmı
             baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }

}
