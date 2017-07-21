using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oto_kiralama
{
    public partial class Kullanici_eklemecs : Form
    {
        public Kullanici_eklemecs()
        {
            InitializeComponent();
            
        }

        private void Kullanici_eklemecs_Load(object sender, EventArgs e)
        {

        }

        private void button_kekle_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "")|| (textBox2.Text == "")|| (textBox3.Text == ""))
            { MessageBox.Show("Boş alan bırakılamaz!");
              
            }
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";

            string cmdStr = "Insert into ekleKullanici ([kullaniciAd],[kullaniciSifre],[yetkiTuru]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show(textBox1.Text + " " + "isimli kullanıcı sisteme eklenmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminyetkileri ay = new adminyetkileri();
            ay.Show();
            this.Close();
        }
    }
}
