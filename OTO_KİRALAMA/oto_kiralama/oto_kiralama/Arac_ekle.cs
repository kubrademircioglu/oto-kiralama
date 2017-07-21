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
    public partial class Arac_ekle : Form
    {
        public Arac_ekle()
        {
            InitializeComponent();
        }

        private void Arac_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            string cmdStr = "Insert into arac ([marka],[model],[yıl],[yakıt],[vites],[km],[renk],[kasa_tipi]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text  + "')";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("araç sisteme eklenmiştir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici_yetkileri ky = new Kullanici_yetkileri();
            ky.Show();
            this.Close();
        }
    }
}
