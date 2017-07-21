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
    public partial class arac_guncelleme : Form
    {
        public arac_guncelleme()
        {   
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;

            kmt.CommandText = "select model from arac where marka='" + comboBox1.Text + "'";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0]);

            }

            baglanti.Close();
        }

        private void arac_guncelleme_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;

            kmt.CommandText = "select marka from arac";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);

            }

            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici_yetkileri ky = new Kullanici_yetkileri();
            ky.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection ac = new SqlConnection();
            ac.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            ac.Open();
            string sorgu = "select yıl from arac where model='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sorgu, ac);
            SqlDataReader cikti = cmd.ExecuteReader();
            if (cikti.Read())
            {
                textBox1.Text=cikti["yıl"].ToString();
               
                
            }
            else
            { MessageBox.Show("kayıt bulunamadı"); }
            ac.Close();

        }
    }
}
