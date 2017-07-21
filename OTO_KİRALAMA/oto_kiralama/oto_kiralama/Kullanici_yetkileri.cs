using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oto_kiralama
{
    public partial class Kullanici_yetkileri : Form
    {
        public static string yetkiTuru;
        public Kullanici_yetkileri()
        {
            InitializeComponent();
        }

        private void Kullanici_yetkileri_Load(object sender, EventArgs e)
        {
           
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arac_ekle ekle = new Arac_ekle();
            ekle.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arac_silme sil = new Arac_silme();
            sil.Show();
            this.Close();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            /*arac_guncelleme ag = new arac_guncelleme();
            ag.Show();
            this.Close();*/
        }

        private void button_kykaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
