using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace murat_internet_cafe_otomasyonu
{
    public partial class Frmkullanici : Form
    {
        public Frmkullanici()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            kullanici.KullaniciGirisi(textBox1, textBox2);
            if (kullanici.durum == true)
            {
                this.Hide();
                frmSatis frm = new frmSatis();
                frm.Show();
               


            }
            else if (kullanici.durum == false)  
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı","uyarı ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }
    }
}
