using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace murat_internet_cafe_otomasyonu
{

    internal class veritabani
    {
      public static  SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=InternetCafe;Integrated Security=True;");
      public static DataTable sepetlistele(DataGridView gridView)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from TBLSepet", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            gridView.DataSource = tbl;
            return tbl;
        }

        public static DataTable comboyabosmasagetir(ComboBox cmb)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from TBLMasalar where Durumu='BOŞ' ", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "Masalar";
            cmb.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }
         
        public static void esg(SqlCommand command,string sorgu)
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            baglanti.Close();

        }

        public static SqlDataReader listvievdekayitlarigoster(ListView list)
        {
            list.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLHareketler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                list.Items.Add(item);


            }
                baglanti.Close();
            return dr;
            

        } 
    }
}
