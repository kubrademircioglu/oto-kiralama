using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace oto_kiralama
{
    public partial class Form1 : Form
    {
        public static int kullaniciNo;
        public static string kullaniciAd;
        private string kullaniciSifre;
        public static string yetkiTuru;
        public int id;
        public string yetki;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar='*';

        }

        private void button_fgiris_Click(object sender, EventArgs e)
        {
            /*if (String.IsNullOrWhiteSpace(textBox1.Text) ||
            String.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "HATA",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } */
            
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                cnn.Open();
                DataSet ds = new DataSet();

                //-- Kullanıcı Adına göre şifreyi alıyoruz..
                SqlDataAdapter sda = new SqlDataAdapter("select * from ekleKullanici where kullaniciAd = '" + textBox1.Text + "'", cnn);
                sda.Fill(ds);

                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Geçersiz Kullanıcı.", "oto_kiralama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBox1.Text == "")
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz!");
                if (textBox2.Text == "")
                    MessageBox.Show("Lütfen şifrenizi giriniz!");
                   

                kullaniciAd = ds.Tables[0].Rows[0][1].ToString();
                kullaniciNo = (int)ds.Tables[0].Rows[0][0];
                yetkiTuru = ds.Tables[0].Rows[0][3].ToString();
                string sifre = ds.Tables[0].Rows[0][2].ToString();
                kullaniciSifre = sifre;

                //-- Karşılaştırma yapılıyor...
                if (sifre == textBox2.Text)
                {
                   
                    if (yetkiTuru == "Admin")
                    {
                        adminyetkileri ac = new adminyetkileri();
                        ac.Show();
                        this.Visible = false;
                        
                    }
                    else if (yetkiTuru == "Kullanici")
                    {
                        Kullanici_yetkileri kullanici = new Kullanici_yetkileri();
                        kullanici.Show();
                        


                    }
                    else if (yetkiTuru == "Müşteri")
                    {
                        Müşteri_Anasayfa musteri = new Müşteri_Anasayfa();
                        musteri.Show();
                        

                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Giriş Yaptınız", "oto_kiralama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

              
            }

        private void button_fcikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

