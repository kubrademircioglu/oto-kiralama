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
    public partial class Kullanici_ad_degis : Form
    {
        public Kullanici_ad_degis()
        {
            InitializeComponent();
        }

        private void Kullanici_ad_degis_Load(object sender, EventArgs e)
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

        private void textBox_kadyeniad_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button_kadkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            string cmdStr = "Update ekleKullanici set [kullaniciAd]='" + textBox2.Text + "' where [kullaniciAd]='" + textBox1.Text + "'";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show(textBox1.Text + " " + "isimli kullanıcı" + " " + textBox2.Text + " " + "ismi ile güncellenmiştir");
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button_kaddön_Click(object sender, EventArgs e)
        {
            adminyetkileri ay = new adminyetkileri();
            ay.Show();
            this.Close();
        }
    }
}
