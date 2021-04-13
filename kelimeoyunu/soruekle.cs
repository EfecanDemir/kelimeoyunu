using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kelimeoyunu
{
    public partial class soruekle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=admin;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;

        public soruekle()
        {
            InitializeComponent();

            baglantiKontrol();
        }
        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            if (baglanti.State == ConnectionState.Closed)
            {
            }
        }
        private void soruekle_Load(object sender, EventArgs e)
        {

        }

        private void soruekleBtn_Click(object sender, EventArgs e)
        {
            if(soruekleTxt.Text=="" || cevapekleTxt.Text == "")
            {
                if (soruekleTxt.Text == "")
                {
                    errorProvidersoru.SetError(soruekleTxt, "Soru alanı boş bırakılamaz");
                }

                if (cevapekleTxt.Text == "")
                {
                    errorProvidercevap.SetError(cevapekleTxt, "Cevap alanı boş bırakılamaz");
                }
            }
            else if (true)
            {
                string cevapekle=cevapekleTxt.Text;

                for (int i = 0; i < cevapekle.Length; i++)
                {

                }

                if (cevapekle.Length<4)
                {
                    MessageBox.Show("En Az 4, En Fazla 10 Haneli Kelime Cevabı Girebilirsiniz.");

                }else if (true)
                {



                    if (cevapekle.Length == 4)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM dorthane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();
                            
                        }
                        dr.Close();

                      
                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text)+1;
                            string kayit3 = "insert into dorthane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();
                            

                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 5)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM beshane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into beshane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 6)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM altihane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into altihane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 7)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM yedihane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into yedihane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 8)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM sekizhane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into sekizhane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 9)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM dokuzhane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into dokuzhane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }

                    if (cevapekle.Length == 10)
                    {
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT count(id) FROM onhane";
                        komut.CommandType = CommandType.Text;
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            idLbl.Text = dr["count(id)"].ToString();

                        }
                        dr.Close();


                        if (true)
                        {
                            int b = Convert.ToInt32(idLbl.Text) + 1;
                            string kayit3 = "insert into onhane(id,soru,cevap) values(@id,@soru,@cevap)";
                            MySqlCommand komut = new MySqlCommand(kayit3, baglanti);
                            komut.Parameters.AddWithValue("@id", b);
                            komut.Parameters.AddWithValue("@soru", soruekleTxt.Text);
                            komut.Parameters.AddWithValue("@cevap", cevapekleTxt.Text);

                            komut.ExecuteNonQuery();


                        }

                        baglanti.Close();
                    }


                    

                    MessageBox.Show("Soru Başarıyla Eklendi."+"\n"+cevapekle.Length+(" haneli gruba sorunuzu eklediniz."));
                }

            }

        }

        private void ciksBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soruekleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
