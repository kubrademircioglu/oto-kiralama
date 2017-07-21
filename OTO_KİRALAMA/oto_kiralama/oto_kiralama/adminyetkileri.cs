using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oto_kiralama
{
    public partial class adminyetkileri : Form
    {
        public adminyetkileri()
        {
            InitializeComponent();
        }

        private void button_kyetkileri_Click(object sender, EventArgs e)
        {

        }

        private void adminyetkileri_Load(object sender, EventArgs e)
        {

        }

        private void button_kekleme_Click(object sender, EventArgs e)
        {
            Kullanici_eklemecs ekle = new Kullanici_eklemecs();
            ekle.Show();
            this.Close();
        }

        private void button_ksilme_Click(object sender, EventArgs e)
        {
            Kullanici_silme sil = new Kullanici_silme();
            sil.Show();
            this.Close();
        }

        private void button_ksifredegis_Click(object sender, EventArgs e)
        {
            
           Kullanici_sifre_degis degis = new Kullanici_sifre_degis();
            degis.Show();
            this.Close();

        }

        private void button_kaddegis_Click(object sender, EventArgs e)
        {
            Kullanici_ad_degis ad = new Kullanici_ad_degis();
            ad.Show();
            this.Close();
        }

        private void button_kanasayfa_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_yetkileri ku = new Kullanici_yetkileri();
            ku.Show();
            
        }

        private void button_kcikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
