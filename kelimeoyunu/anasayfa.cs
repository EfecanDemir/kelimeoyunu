using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kelimeoyunu
{
    public partial class anasayfa : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=admin;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        Random rastgele = new Random();
        int sn ;
        int saniye = 60;
        int dakika = 0;
        int a = 1;
        int harfalpuan=0;
        int cc=0;
        int rsayac = 1;
        int geneldogru = 0;
        int genelpuan = 0;
        int topharfalsayisi = 0;
        int randomsoru;
        int sorupuan = 0;


        public string kullaniciAdi { get; set; }

        public anasayfa()
        {
            InitializeComponent();

            baglantiKontrol();
            dataDoldur();


            birinciBtn.MaxLength = 1;
            ikinciBtn.MaxLength = 1;
            ucuncuBtn.MaxLength = 1;
            dorduncuBtn.MaxLength = 1;
            besinciBtn.MaxLength = 1;
            altinciBtn.MaxLength = 1;
            yedinciBtn.MaxLength = 1;
            sekizinciBtn.MaxLength = 1;
            dokuzuncuBtn.MaxLength = 1;
            onuncuBtn.MaxLength = 1;


        }

        void dataDoldur()
        {
            baglantiKontrol();

            komut = new MySqlCommand("select kullaniciadi,oynaniszaman,puan,harfalma,kalansure from oyuncular",baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "oyuncular");
            dataGridView1.DataSource = ds.Tables["oyuncular"];
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[0].HeaderText = "Kullanıcı Adı";
            this.dataGridView1.Columns[1].HeaderText = "Oynadığı Zaman";
            this.dataGridView1.Columns[2].HeaderText = "Puan";
            this.dataGridView1.Columns[3].HeaderText = "Harf Alma Sayısı";
            this.dataGridView1.Columns[4].HeaderText = "Kalan Süre";


            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Sienna;

            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Khaki;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.Khaki;
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.CornflowerBlue;

        }

        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }

        }
        private void onuncuBtn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kirmiziBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();  // genel 4 dk lık süre durdurulur.
            snLbl.Visible = true;
            kalansureeLbl.Visible = true;
            timer2.Start(); // 20 saniyelik cevaplama süresi başlar.
            sn = Convert.ToInt32("20");

            if (rsayac == 2)
            {
                rsayac++;
            }

            if (rsayac == 4)
            {
                rsayac++;
            }

            if (rsayac == 6)
            {
                rsayac++;
            }

            if (rsayac == 8)
            {
                rsayac++;
            }

            if (rsayac == 10)
            {
                rsayac++;
            }

            if (rsayac == 12)
            {
                rsayac++;
            }

            if (rsayac == 14)
            {
                rsayac++;
            }

            if (rsayac == 16)
            {
                rsayac++;
            }
            if (rsayac == 18)
            {
                rsayac++;
            }
            if (rsayac == 20)
            {
                rsayac++;
            }
            if (rsayac == 22)
            {
                rsayac++;
            }
            if (rsayac == 24)
            {
                rsayac++;
            }
            if (rsayac == 26)
            {
                rsayac++;
            }

            if (rsayac == 28)
            {
                rsayac++;
            }




            harfalBtn.Enabled = false;
            tahminetBtn.Enabled = true;

            kirmiziBtn.Enabled = false;

            birinciBtn.Enabled = true;
            ikinciBtn.Enabled = true;
            ucuncuBtn.Enabled = true;
            dorduncuBtn.Enabled = true;
            besinciBtn.Enabled = true;
            altinciBtn.Enabled = true;
            yedinciBtn.Enabled = true;
            sekizinciBtn.Enabled = true;
            dokuzuncuBtn.Enabled = true;
            onuncuBtn.Enabled = true;



           

        }

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32("4");
            baslaBtn.Enabled = false;
            baslaBtn.Visible = false;

            komut = new MySqlCommand();
            komut.Connection = baglanti;
            baglantiKontrol();

            kirmiziBtn.Enabled = true;
            harfalBtn.Enabled = true;


            kullaniciAdiLbl.Text = kullaniciAdi;
            oyuncuLbl.Visible = true;
            kullaniciAdiLbl.Visible = true;


            //bütün randomlar atanacak 
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT count(id) FROM dorthane";
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                randsorusayisiLbl.Text = dr["count(id)"].ToString();
                randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

            }
            dr.Close();

            int bir = rastgele.Next(1, randomsoru);

            if (rsayac == 1)
            {
                rsayac++;
                komut.CommandText = "SELECT * FROM dorthane where id=" + bir;
                dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    soruLbl.Text = dr["soru"].ToString();
                    sorusayisiLbl.Text = "Soru 1";



                    birinciBtn.Visible = true;
                    ikinciBtn.Visible = true;
                    ucuncuBtn.Visible = true;
                    dorduncuBtn.Visible = true;

                    birinciPnl.Visible = true;
                    ikinciPnl.Visible = true;
                    ucuncuPnl.Visible = true;
                    dorduncuPnl.Visible = true;

                    label3.Text = dr["cevap"].ToString();

                    sorupuan = 400;
                    sorupuanLbl.Text = sorupuan.ToString();

                }
                dr.Close();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000; // 1 saniye
            sn = sn - 1;
            snLbl.Text = sn.ToString();         
            if (sn == 0)
            {
                timer2.Stop();
                MessageBox.Show("Cevaplama Süreniz Bitti.");
                tahminetBtn.PerformClick();
                snLbl.Text = "20";
                
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniye
            saniye = saniye - 1;
            saniyeLbl.Text = saniye.ToString();
            dakikaLbl.Text = (dakika - 1).ToString();
            if (dakikaLbl.Text == "0" && saniyeLbl.Text == "1")
            {
                MessageBox.Show("Süreniz Bitti.");

                tekraroynaBtn.Visible = true;

                kullaniciAdiLbl.Text = kullaniciAdi;

                baglantiKontrol();
                string kayit2 = "insert into oyuncular(kullaniciadi,oynaniszaman,puan,harfalma,kalansure) values(@kullaniciadi,@oynaniszaman,@puan,@harfalma,@kalansure)";
                MySqlCommand komut = new MySqlCommand(kayit2, baglanti);
                komut.Parameters.AddWithValue("@kullaniciadi", kullaniciAdiLbl.Text);
                komut.Parameters.AddWithValue("@oynaniszaman", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@puan", puanLbl.Text);
                komut.Parameters.AddWithValue("@harfalma", topharfalsayisi);
                komut.Parameters.AddWithValue("@kalansure", dakikaLbl.Text + label2.Text + saniyeLbl.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                dataDoldur();

                //tüm oynayan kişileri txt ye çekme
                TextWriter writer = new StreamWriter(@"Tüm Yarışan Kişiler.txt");

                writer.Write("\t" + "KİŞİ SAYISI" + "\t" + "|");
                writer.Write("\t" + "KULLANICI ADI" + "\t" + "|");
                writer.Write("\t" + "OYNAMA TARİHİ" + "\t" + "|");
                writer.Write("\t" + "PUAN" + "\t" + "|");
                writer.Write("ALDIĞI HARF SAYISI" + "|");
                writer.Write("\t" + "KALAN SÜRE" + "\t" + "|");
                writer.WriteLine("\n" + "--------------------------------------------------------------------------------------------------------------------------------------------");

                int z = 1;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    writer.Write("\t" + z + "\t" + "\t" + "|");
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");

                    }
                    writer.WriteLine("");
                    writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                    z++;
                }
                writer.Close();

                //puana göre sıralama
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);

                TextWriter yazdir = new StreamWriter(@"İlk Beş Oyuncu.txt");

                yazdir.Write("\t" + "KİŞİ SAYISI" + "\t" + "|");
                yazdir.Write("\t" + "KULLANICI ADI" + "\t" + "|");
                yazdir.Write("\t" + "OYNAMA TARİHİ" + "\t" + "|");
                yazdir.Write("\t" + "PUAN" + "\t" + "|");
                yazdir.Write("ALDIĞI HARF SAYISI" + "|");
                yazdir.Write("\t" + "KALAN SÜRE" + "\t" + "|");
                yazdir.WriteLine("\n" + "--------------------------------------------------------------------------------------------------------------------------------------------");

                int x = 1;

                for (int i = 0; i < 5; i++)
                {
                    yazdir.Write("\t" + x + "\t" + "\t" + "|");
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        yazdir.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");

                    }
                    yazdir.WriteLine("");
                    yazdir.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                    x++;
                }
                yazdir.Close();

                kirmiziBtn.Enabled = false;
                tahminetBtn.Enabled = false;
                harfalBtn.Enabled = false;

                // en son durdurma


            }
            if (saniye == 0)
            {
                dakika = dakika - 1;
                dakikaLbl.Text = dakika.ToString();
                saniye = 60;
            }
            if (dakikaLbl.Text == "-1")
            {
                timer1.Stop();
                dakikaLbl.Text = "0";
                saniyeLbl.Text = "00";
            }
        }
        
        private void harfalBtn_Click(object sender, EventArgs e)
        {
            harfalpuan= harfalpuan+100; //anlık puan hesaplama
            sorupuanLbl.Text = sorupuan.ToString() + "(-" + (harfalpuan) + ")"; //O SORUDA ALDIĞI PUAN VE ALACAĞI PUAN HESABI
            topharfalsayisi++; // oyuncu kaç harf almış
            cc++; // döngüde harf sayısını aştığı takdirde harf al kapanır.
            string cevap = label3.Text;
       

            Random rnd = new Random();
            
            if (cc < cevap.Length)
            {
                for (int i = cevap.Length; i < cevap.Length+1; i++)
                {
                    int uret = rnd.Next(0, cevap.Length);
                    int yoksa = listBox1.Items.IndexOf(uret);
                    if(yoksa!=-1)
                    {
                        i--;
                        continue;
                    }
                    else if (yoksa==-1)
                    {
                       listBox1.Items.Add(uret);

                       if (0 == uret)
                       {
                          birinciBtn.Text = cevap[0].ToString();
                       }
                       else if (1 == uret)
                       {
                            ikinciBtn.Text = cevap[1].ToString();
                       }
                       else if (2 == uret)
                       {
                            ucuncuBtn.Text = cevap[2].ToString();
                       }
                       else if (3 == uret)
                       {
                            dorduncuBtn.Text = cevap[3].ToString();
                       }
                        else if (4 == uret)
                       {
                            besinciBtn.Text = cevap[4].ToString();
                       }
                        else if (5 == uret)
                       {
                            altinciBtn.Text = cevap[5].ToString();
                       }
                        else if (6== uret)
                       {
                            yedinciBtn.Text = cevap[6].ToString();
                       }
                        else if (7 == uret)
                       {
                            sekizinciBtn.Text = cevap[7].ToString();
                       }
                        else if (8 == uret)
                       {
                           dokuzuncuBtn.Text = cevap[8].ToString();
                       }
                        else if (9 == uret)
                       {
                           onuncuBtn.Text = cevap[9].ToString();
                       }
                    }             
                }
                
            }
            if (cc == cevap.Length)
            {
                for (int i = cevap.Length; i < cevap.Length + 1; i++)
                {
                    int uret = rnd.Next(0, cevap.Length);
                    int yoksa = listBox1.Items.IndexOf(uret);
                    if (yoksa != -1)
                    {
                        i--;
                        continue;
                    }
                    else if (yoksa == -1)
                    {
                        listBox1.Items.Add(uret);

                        if (0 == uret)
                        {
                            birinciBtn.Text = cevap[0].ToString();
                        }
                        else if (1 == uret)
                        {
                            ikinciBtn.Text = cevap[1].ToString();
                        }
                        else if (2 == uret)
                        {
                            ucuncuBtn.Text = cevap[2].ToString();
                        }
                        else if (3 == uret)
                        {
                            dorduncuBtn.Text = cevap[3].ToString();
                        }
                        else if (4 == uret)
                        {
                            besinciBtn.Text = cevap[4].ToString();
                        }
                        else if (5 == uret)
                        {
                            altinciBtn.Text = cevap[5].ToString();
                        }
                        else if (6 == uret)
                        {
                            yedinciBtn.Text = cevap[6].ToString();
                        }
                        else if (7 == uret)
                        {
                            sekizinciBtn.Text = cevap[7].ToString();
                        }
                        else if (8 == uret)
                        {
                            dokuzuncuBtn.Text = cevap[8].ToString();
                        }
                        else if (9 == uret)
                        {
                            onuncuBtn.Text = cevap[9].ToString();
                        }
                    }
                }
            }

            if (cc>=cevap.Length)
            {
                harfalBtn.Enabled = false;
                harfalBtn.Visible = false;
                //harfal butonu kapanır

                listBox1.Items.Clear();

                cc = 0;
            }

            
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void tahminetBtn_Click(object sender, EventArgs e)
        {
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            baglantiKontrol();


            timer2.Stop();
            snLbl.Visible = false;
            kalansureeLbl.Visible = false;
            snLbl.Text = "20";

            //2.SORU
            if (rsayac == 3)
            {
                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

               

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                MessageBox.Show("Cevabınız Doğru ");
                                geneldogru = 400;
                                genelpuan = geneldogru - harfalpuan;
                                puanLbl.Text = genelpuan.ToString();
                                harfalpuan = 0;                               
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n"+"Doğru Cevap:"+label3.Text);
                            harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" +  label3.Text);
                        harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text );
                    harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text );

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Enabled = true;
                harfalBtn.Visible = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM dorthane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {

                    komut.CommandText = "SELECT * FROM dorthane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 2";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 400;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }
            //3.SORU
            if (rsayac == 5)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                MessageBox.Show("Cevabınız Doğru");

                                genelpuan = genelpuan+400;
                                genelpuan = genelpuan - harfalpuan;
                                puanLbl.Text = genelpuan.ToString();
                                harfalpuan = 0; 
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM beshane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                   
                    komut.CommandText = "SELECT * FROM beshane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 3";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 500;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }

           
            }
           
            if (rsayac == 7)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    MessageBox.Show("Cevabınız Doğru");

                                    genelpuan = genelpuan + 500;
                                    genelpuan = genelpuan - harfalpuan;
                                    puanLbl.Text = genelpuan.ToString();
                                    harfalpuan = 0;

                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text);  harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;


                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM beshane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM beshane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 4";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 500;
                        sorupuanLbl.Text = sorupuan.ToString();
                    }
                    dr.Close();
                }

            }

            if (rsayac == 9)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    MessageBox.Show("Cevabınız Doğru");

                                    genelpuan = genelpuan + 500;
                                    genelpuan = genelpuan - harfalpuan;
                                    puanLbl.Text = genelpuan.ToString();
                                    harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text);  harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text);  harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM altihane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM altihane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 5";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 600;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 11)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        MessageBox.Show("Cevabınız Doğru");

                                        genelpuan = genelpuan + 600;
                                        genelpuan = genelpuan - harfalpuan;
                                        puanLbl.Text = genelpuan.ToString();
                                        harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM altihane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM altihane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 6";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;


                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 600;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 13)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        MessageBox.Show("Cevabınız Doğru");

                                        genelpuan = genelpuan + 600;
                                        genelpuan = genelpuan - harfalpuan;
                                        puanLbl.Text = genelpuan.ToString();
                                        harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM yedihane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM yedihane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 7";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        
                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 700;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 15)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            MessageBox.Show("Cevabınız Doğru");

                                            genelpuan = genelpuan + 700;
                                            genelpuan = genelpuan - harfalpuan;
                                            puanLbl.Text = genelpuan.ToString();
                                            harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM yedihane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM yedihane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 8";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 700;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 17)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            MessageBox.Show("Cevabınız Doğru");

                                            genelpuan = genelpuan + 700;
                                            genelpuan = genelpuan - harfalpuan;
                                            puanLbl.Text = genelpuan.ToString();
                                            harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM sekizhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM sekizhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 9";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 800;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 19)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                MessageBox.Show("Cevabınız Doğru");

                                                genelpuan = genelpuan + 800;
                                                genelpuan = genelpuan - harfalpuan;
                                                puanLbl.Text = genelpuan.ToString();
                                                harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM sekizhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM sekizhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 10";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 800;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 21)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                MessageBox.Show("Cevabınız Doğru");

                                                genelpuan = genelpuan + 800;
                                                genelpuan = genelpuan - harfalpuan;
                                                puanLbl.Text = genelpuan.ToString();
                                                harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM dokuzhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM dokuzhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 11";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;
                        dokuzuncuBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;
                        dokuzuncuPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 900;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 23)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                if (dokuzuncuBtn.Text == cevap[8].ToString())
                                                {
                                                    MessageBox.Show("Cevabınız Doğru");

                                                    genelpuan = genelpuan + 900;
                                                    genelpuan = genelpuan - harfalpuan;
                                                    puanLbl.Text = genelpuan.ToString();
                                                    harfalpuan = 0;
                                                }
                                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM dokuzhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM dokuzhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 12";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;
                        dokuzuncuBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;
                        dokuzuncuPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 900;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 25)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                if (dokuzuncuBtn.Text == cevap[8].ToString())
                                                {
                                                    MessageBox.Show("Cevabınız Doğru");

                                                    genelpuan = genelpuan + 900;
                                                    genelpuan = genelpuan - harfalpuan;
                                                    puanLbl.Text = genelpuan.ToString();
                                                    harfalpuan = 0;
                                                }
                                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM onhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM onhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 13";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;
                        dokuzuncuBtn.Visible = true;
                        onuncuBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;
                        dokuzuncuPnl.Visible = true;
                        onuncuPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 1000;
                        sorupuanLbl.Text = sorupuan.ToString();

                    }
                    dr.Close();
                }
            }

            if (rsayac == 27)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                if (dokuzuncuBtn.Text == cevap[8].ToString())
                                                {
                                                    if (onuncuBtn.Text == cevap[9].ToString())
                                                    {
                                                        MessageBox.Show("Cevabınız Doğru");

                                                        genelpuan = genelpuan + 1000;
                                                        genelpuan = genelpuan - harfalpuan;
                                                        puanLbl.Text = genelpuan.ToString();
                                                        harfalpuan = 0;
                                                    }
                                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                                }
                                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = true;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = true;

                timer1.Start();

                birinciBtn.Text = "";
                ikinciBtn.Text = "";
                ucuncuBtn.Text = "";
                dorduncuBtn.Text = "";
                besinciBtn.Text = "";
                altinciBtn.Text = "";
                yedinciBtn.Text = "";
                sekizinciBtn.Text = "";
                dokuzuncuBtn.Text = "";
                onuncuBtn.Text = "";

                //veritabanında tüm soruları sonradan eklense bile güncel çekebilmek için
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT count(id) FROM onhane";
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    randsorusayisiLbl.Text = dr["count(id)"].ToString();
                    randomsoru = Convert.ToInt32(randsorusayisiLbl.Text) + 1;

                }
                dr.Close();

                int bir = rastgele.Next(1, randomsoru);

                if (a == 1)
                {
                    rsayac++;
                    komut.CommandText = "SELECT * FROM onhane where id=" + bir;
                    dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        soruLbl.Text = dr["soru"].ToString();
                        sorusayisiLbl.Text = "Soru 14";

                        birinciBtn.Visible = true;
                        ikinciBtn.Visible = true;
                        ucuncuBtn.Visible = true;
                        dorduncuBtn.Visible = true;
                        besinciBtn.Visible = true;
                        altinciBtn.Visible = true;
                        yedinciBtn.Visible = true;
                        sekizinciBtn.Visible = true;
                        dokuzuncuBtn.Visible = true;
                        onuncuBtn.Visible = true;

                        birinciPnl.Visible = true;
                        ikinciPnl.Visible = true;
                        ucuncuPnl.Visible = true;
                        dorduncuPnl.Visible = true;
                        besinciPnl.Visible = true;
                        altinciPnl.Visible = true;
                        yedinciPnl.Visible = true;
                        sekizinciPnl.Visible = true;
                        dokuzuncuPnl.Visible = true;
                        onuncuPnl.Visible = true;

                        label3.Text = dr["cevap"].ToString();

                        sorupuan = 1000;
                        sorupuanLbl.Text = sorupuan.ToString();
                    }
                    dr.Close();
                }
            }

            if (rsayac == 29)
            {

                string cevap = label3.Text;
                for (int i = 0; i < cevap.Length; i++)
                {

                }

                birinciBtn.Enabled = false;
                ikinciBtn.Enabled = false;
                ucuncuBtn.Enabled = false;
                dorduncuBtn.Enabled = false;
                besinciBtn.Enabled = false;
                altinciBtn.Enabled = false;
                yedinciBtn.Enabled = false;
                sekizinciBtn.Enabled = false;
                dokuzuncuBtn.Enabled = false;
                onuncuBtn.Enabled = false;

                if (birinciBtn.Text == cevap[0].ToString())
                {
                    if (ikinciBtn.Text == cevap[1].ToString())
                    {
                        if (ucuncuBtn.Text == cevap[2].ToString())
                        {
                            if (dorduncuBtn.Text == cevap[3].ToString())
                            {
                                if (besinciBtn.Text == cevap[4].ToString())
                                {
                                    if (altinciBtn.Text == cevap[5].ToString())
                                    {
                                        if (yedinciBtn.Text == cevap[6].ToString())
                                        {
                                            if (sekizinciBtn.Text == cevap[7].ToString())
                                            {
                                                if (dokuzuncuBtn.Text == cevap[8].ToString())
                                                {
                                                    if (onuncuBtn.Text == cevap[9].ToString())
                                                    {
                                                        MessageBox.Show("Cevabınız Doğru");

                                                        genelpuan = genelpuan + 1000;
                                                        genelpuan = genelpuan - harfalpuan;
                                                        puanLbl.Text = genelpuan.ToString();
                                                        harfalpuan = 0;
                                                    }
                                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                                }
                                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                            }
                                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                        }
                                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                    }
                                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                                }
                                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                            }
                            else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                        }
                        else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;
                    }
                    else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); ; harfalpuan = 0;
                }
                else MessageBox.Show("Cevabınız Hatalı " + "\n" + "Doğru Cevap:" + label3.Text); harfalpuan = 0;

                // harf al her soru cevaplandığında sıfırlandı
                listBox1.Items.Clear();
                cc = 0;

                harfalBtn.Visible = true;
                harfalBtn.Enabled = false;
                tahminetBtn.Enabled = false;
                kirmiziBtn.Enabled = false;

                MessageBox.Show("Yarışma Bitti."+"\n"+"\n"+"Oyuncu Adı: "+kullaniciAdi+"\n"+"Oynanış Zaman: "+DateTime.Now.ToString()+"\n"+"Puan: "+puanLbl.Text+"\n"+"Harf Alma: "+topharfalsayisi+"\n"+"Kalan Süre: "+ dakikaLbl.Text + label2.Text + saniyeLbl.Text);
                //KAYIT ETTİRME PUAN TABLOSUNA KULLANICI ADI İLE PUANINI YAZDIRMA

                tekraroynaBtn.Visible = true;

                kullaniciAdiLbl.Text = kullaniciAdi;

                baglantiKontrol();
                string kayit2 = "insert into oyuncular(kullaniciadi,oynaniszaman,puan,harfalma,kalansure) values(@kullaniciadi,@oynaniszaman,@puan,@harfalma,@kalansure)";
                MySqlCommand komut = new MySqlCommand(kayit2, baglanti);
                komut.Parameters.AddWithValue("@kullaniciadi", kullaniciAdiLbl.Text);
                komut.Parameters.AddWithValue("@oynaniszaman", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@puan", puanLbl.Text);
                komut.Parameters.AddWithValue("@harfalma", topharfalsayisi);
                komut.Parameters.AddWithValue("@kalansure", dakikaLbl.Text+label2.Text+saniyeLbl.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                dataDoldur();


                //tüm oynayan kişileri txt ye çekme
                TextWriter writer = new StreamWriter(@"Tüm Yarışan Kişiler.txt");

                writer.Write("\t" + "KİŞİ SAYISI" + "\t" + "|");
                writer.Write("\t" + "KULLANICI ADI" + "\t" + "|");
                writer.Write("\t" + "OYNAMA TARİHİ" + "\t" +  "|");
                writer.Write("\t" + "PUAN" + "\t" + "|");
                writer.Write("ALDIĞI HARF SAYISI" + "|");
                writer.Write("\t" + "KALAN SÜRE" + "\t" + "|");
                writer.WriteLine("\n"+ "--------------------------------------------------------------------------------------------------------------------------------------------");

                int z = 1;

                for (int i = 0; i < dataGridView1.Rows.Count ; i++)
                {
                    writer.Write("\t" + z + "\t" + "\t" + "|");
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                      
                        writer.Write("\t"+ dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                   
                    }
                    writer.WriteLine("");
                    writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                    z++;
                }
                writer.Close();


                //puana göre sıralama
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);

                TextWriter yazdir = new StreamWriter(@"İlk Beş Oyuncu.txt");

                yazdir.Write("\t" + "KİŞİ SAYISI" + "\t" + "|");
                yazdir.Write("\t" + "KULLANICI ADI" + "\t" + "|");
                yazdir.Write("\t" + "OYNAMA TARİHİ" + "\t" + "|");
                yazdir.Write("\t" + "PUAN" + "\t" + "|");
                yazdir.Write("ALDIĞI HARF SAYISI" + "|");
                yazdir.Write("\t" + "KALAN SÜRE" + "\t" + "|");
                yazdir.WriteLine("\n" + "--------------------------------------------------------------------------------------------------------------------------------------------");

                int x = 1;

                for (int i = 0; i < 5; i++)
                {
                    yazdir.Write("\t" + x + "\t" + "\t" + "|");
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        yazdir.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");

                    }
                    yazdir.WriteLine("");
                    yazdir.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                    x++;
                }
                yazdir.Close();


            }


            rsayac++;
        }

        private void tekraroynaBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void puantablosuBtn_MouseHover(object sender, EventArgs e)
        {
            puantablosuBtn.Visible = false;
            dataGridView1.Visible = true;
            
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            puantablosuBtn.Visible = true;
        }
    } 
}

