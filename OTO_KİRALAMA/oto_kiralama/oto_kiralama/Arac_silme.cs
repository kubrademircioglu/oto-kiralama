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
    public partial class Arac_silme : Form
    {
        public Arac_silme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kullanıcıyı Silmek İstediğinizden Emin Misiniz?", "Silme Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)

                button2.Visible = true;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";

            string cmdStr = "Delete from arac where arac_id='" + id + "'";
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand(cmdStr, baglanti);
            kaydet.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(kaydet);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Refresh();
            MessageBox.Show("Silme İşlemi Gerçekleştirildi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            
        }

        private void Arac_silme_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select * from arac";
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select * from arac";
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Güncelleme İşlemi Gerçekleştirildi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanici_yetkileri ky = new Kullanici_yetkileri();
            ky.Show();
            this.Close();
        }
    }
}
