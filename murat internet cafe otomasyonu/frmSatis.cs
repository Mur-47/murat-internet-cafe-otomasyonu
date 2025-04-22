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

namespace murat_internet_cafe_otomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=InternetCafe;Integrated Security=True;");
        private void frmSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet2.TBLSaatUcreti' table. You can move, or remove it, as needed.
            this.tBLSaatUcretiTableAdapter1.Fill(this.internetCafeDataSet2.TBLSaatUcreti);
            // TODO: This line of code loads data into the 'internetCafeDataSet1.TBLSaatUcreti' table. You can move, or remove it, as needed.
            this.tBLSaatUcretiTableAdapter.Fill(this.internetCafeDataSet1.TBLSaatUcreti);
            rbsuresiz.Checked = true;
            Yenile();
            cmbBosMasa.Text="";
            timer1.Start();
        }

        private void Yenile()
        {
            veritabani.sepetlistele(dataGridView1);
            veritabani.listvievdekayitlarigoster(listView1);
            veritabani.comboyabosmasagetir(cmbBosMasa);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from TBLMasalar where Durumu='BOŞ' ", veritabani.baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cmbBosMasa.DataSource = tbl;
            cmbBosMasa.DisplayMember = "Masalar";
            cmbBosMasa.ValueMember = "MasaID";
            baglanti.Close();

            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    if (item.Name != btnmasaac.Name)
                    {
                        veritabani.baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from TBLMasalar ", veritabani.baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.LightGreen;
                            }


                            if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.OrangeRed;
                            }
                        }
                        veritabani.baglanti.Close();
                    } 
                }
            }
        }

        Button  btn;
        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            if (btn.BackColor==Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem1.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem1.Visible = false;
            }
            if (btn.BackColor==Color.LightGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem1.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem1.Visible = true;
            }

        }
        RadioButton rb;
        private void RadioButtonSecili(object sender, EventArgs e)
        {
            rb = sender as RadioButton;
        }
       
        private void btnmasaac_Click(object sender, EventArgs e)
        {
            if (kullanici.kullaniciid==3)
            {
                string sqlsorgu = "insert into TBLSepet(MasaID,Masa,AcilisTuru,Baslangıc,Tarih) values ('" + cmbBosMasa.Text.Substring(5) + "','" + cmbBosMasa.Text + "'" +
                        ",'" + rb.Text + "', @Baslangıc, @Tarih )";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@Baslangıc",DateTime.Parse(DateTime.Now.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));

                veritabani.esg(komut, sqlsorgu);
                MessageBox.Show(cmbBosMasa.Text.Substring(5) + " Nolu Masa Açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Yenile();
                rbsuresiz.Checked = true;


            }
            else
            {
                MessageBox.Show("Böyle Bir Yetkiniz Bulunmuyor.!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                if (cmbBosMasa.Text != "")
                {

                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaşlangıcTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaşlangıcTarihi;
                    Double saatfarkı2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = saatfarkı2.ToString("0.00");
                    double toplamtutar = saatfarkı2 * double.Parse(cmbBosMasa.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["BitisSaati"].Value = BitisTarihi;
                }
                if (cmbBosMasa.Text == "")
                {
                    MessageBox.Show("Önce Saat Ücreti Belirtilmelidir.!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
