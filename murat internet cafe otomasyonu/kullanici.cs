using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace murat_internet_cafe_otomasyonu
{
    internal class kullanici
    {
        public static int kullaniciid=0;
        public static bool durum=false;
        public static SqlDataReader KullaniciGirisi(TextBox KullaniciAdi,TextBox Sifre )
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKullanici where KullaniciAdı='"+KullaniciAdi.Text+"' and Sifre='"+Sifre.Text+"'", veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               durum=true;
                kullaniciid = int.Parse (dr["KullaniciID"].ToString());

            }
            else
            {
               durum = false;
               // MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }   
            veritabani.baglanti.Close();
            return dr;
        }
    }
}
