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
    public partial class Kullanici_sifre_degis : Form
    {
        public Kullanici_sifre_degis()
        {
            InitializeComponent();
        }

        private void Kullanici_sifre_degis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veritabaniDataSet.kullanicilar' table. You can move, or remove it, as needed.

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;
            kmt.CommandText = "select kullaniciAd from ekleKullanici";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox_ksd.Items.Add(oku[0]);
                

            }
            baglanti.Close();
            textBox2.Visible = false;
            

        }

        private void button_ksddön_Click(object sender, EventArgs e)
        {
            adminyetkileri adm = new adminyetkileri();
            adm.Show();
            this.Close();
        }

        private void comboBox_ksd_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox_ksd.SelectedItem.ToString();
                   }

       

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            SqlConnection ac = new SqlConnection();
            ac.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            ac.Open();
            string sorgu = "select kullaniciSifre from ekleKullanici where kullaniciAd='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sorgu, ac);
            SqlDataReader cikti = cmd.ExecuteReader();
            if (cikti.Read())
            {
                textBox2.Text = cikti["kullaniciSifre"].ToString();
                button1.Visible = false;
            }
            else
            { MessageBox.Show("kayıt bulunamadı"); }
            ac.Close();
        }
        private void button_ksdkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();

            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            string cmdStr = "Update ekleKullanici set [kullaniciSifre]='" + textBox_ksdyeniparola.Text + "' where [kullaniciSifre]='" + textBox2.Text + "'";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sifre guncellenmiştir");
        }
    }
}
