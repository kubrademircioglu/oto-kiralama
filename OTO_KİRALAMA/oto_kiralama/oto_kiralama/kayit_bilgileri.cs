using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace oto_kiralama
{
    public partial class kayit_bilgileri : Form
    {   
        public kayit_bilgileri()
        {
            InitializeComponent();
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (richTextBox1.Text == ""))
            {
                MessageBox.Show("Boş alan bırakılmaz..");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                string cmdStr = "Insert into müsteri ([ad],[soyad],[tc],[tel_no],[yas],[kan_grubu],[adres]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + richTextBox1.Text + "')";
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kayıt işleminiz gerçekleşmiştir.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

