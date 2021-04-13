using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kelimeoyunu
{
    public partial class giris : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=admin;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        
       

        public giris()
        {
            InitializeComponent();

            baglantiKontrol();
        }
        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                baglantiBtn.BackColor = Color.Green;
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                baglantiBtn.BackColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giris_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (kAdiTextbox.Text!="")
            {
              
                anasayfa a1 = new anasayfa();
                a1.kullaniciAdi = kAdiTextbox.Text;
                a1.Show();

                
             
            }
            else
            {
                if (kAdiTextbox.Text == "")
                {
                    errorProviderkadi.SetError(kAdiTextbox, "Ad alanı boş bırakılamaz");
                }            
            }
          
        }

        private void bilgiBtn_MouseHover(object sender, EventArgs e)
        {
            soruekleBtn.Visible = false;
            bilgiPnl.Visible = true;
            
        }

        private void bilgiBtn_MouseLeave(object sender, EventArgs e)
        {
            bilgiPnl.Visible = false;

            soruekleBtn.Visible = true;
        }

        private void soruekleBtn_Click(object sender, EventArgs e)
        {
            soruekle s1 = new soruekle();
            s1.Show();
        }
    }
    }

