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
    public partial class Kullanici_silme : Form
    {
        public Kullanici_silme()
        {
            InitializeComponent();
        }

        private void Kullanici_silme_Load(object sender, EventArgs e)
        {

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
                comboBox1.Items.Add(oku[0]);

            }
            baglanti.Close();

        }

        private void button_ksdön_Click(object sender, EventArgs e)
        {
            adminyetkileri adm = new adminyetkileri();
            adm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox1.SelectedItem.ToString();
           
        }

        private void button_ksil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";

            string cmdStr = "Delete from ekleKullanici where [kullaniciAd]='" + textBox1.Text + "'";
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand(cmdStr, baglanti);
            kaydet.ExecuteNonQuery();
            MessageBox.Show(textBox1.Text + " " + "isimli kullanıcı silinmiştir.");
        }
    }
}
