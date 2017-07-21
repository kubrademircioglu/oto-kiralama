using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;


namespace oto_kiralama
{
    public partial class Müşteri_Anasayfa : Form
    {
        public String exceleGelecekler;
        public Microsoft.Office.Interop.Excel.Application ExcelNesnesi;
        public Microsoft.Office.Interop.Excel.Worksheet tablo;
        public Müşteri_Anasayfa()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Müşteri_Anasayfa_Load(object sender, EventArgs e)

        {
            ExcelNesnesi = new Microsoft.Office.Interop.Excel.Application();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
             dataGridView3.Visible=false;
             dataGridView5.Visible = false;
             dataGridView4.Visible = false;
             dataGridView6.Visible = false;
            comboBox2.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
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
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView6.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select * from arac";
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            exceleGelecekler = cmdStr;
            dataGridView1.DataSource = dt;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label2.Visible = true;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;

            kmt.CommandText = "select model from arac where marka='"+ comboBox1.Text+"'";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0]);

            }

            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView6.Visible = false;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select * from arac where model='"+comboBox2.SelectedItem.ToString()+"' and marka='"+comboBox1.SelectedItem.ToString()+"'";
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            exceleGelecekler = cmdStr;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView6.Visible = false;
            if (comboBox3.SelectedIndex == 0)
                dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = true;
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                baglanti.Open();
                string cmdStr = "select * from arac where kasa_tipi='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                exceleGelecekler = cmdStr;
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                baglanti.Open();
                string cmdStr = "select * from arac where yakıt='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                exceleGelecekler = cmdStr;
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                 
            }
            if (comboBox3.SelectedIndex == 2)
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                baglanti.Open();
                string cmdStr = "select * from arac where vites='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                exceleGelecekler = cmdStr;
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            kayit_bilgileri kb = new kayit_bilgileri();
            kb.Show();
            this.Close();
        }
       
          
       
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            var dt = dataGridView3.DataSource as DataTable;
            var index = e.RowIndex;
           var row = dt.Rows[index];
           var arac_id = row["arac_id"];
           var ucret_id = row["ucret_id"];
           var marka = row["marka"];
           var model = row["model"];
           var yıl = row["yıl"];
           var yakıt = row["yakıt"];
           var vites = row["vites"];
           var km = row["km"];
           var renk = row["renk"];
           var kasa_tipi = row["kasa_tipi"];

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select arac_id,ucret_id,ucret,gun_bilgisi from ucret where arac_id='" + arac_id + "'";
            exceleGelecekler = cmdStr;
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt6 = new DataTable();
            da.Fill(dt6);
            dataGridView4.DataSource = dt6;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView6.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
            var dt = dataGridView2.DataSource as DataTable;
            var index = e.RowIndex;
            var row = dt.Rows[index];
            var arac_id = row["arac_id"];
            var ucret_id = row["ucret_id"];
            var marka = row["marka"];
            var model = row["model"];
            var yıl = row["yıl"];
            var yakıt = row["yakıt"];
            var vites = row["vites"];
            var km = row["km"];
            var renk = row["renk"];
            var kasa_tipi = row["kasa_tipi"];

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select arac_id,ucret_id,ucret,gun_bilgisi from ucret where arac_id='" + arac_id + "'";
            exceleGelecekler = cmdStr;
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt6 = new DataTable();
            da.Fill(dt6);
            dataGridView5.DataSource = dt6;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView6.Visible = true;
            var dt = dataGridView1.DataSource as DataTable;
            var index = e.RowIndex;
            var row = dt.Rows[index];
            var arac_id = row["arac_id"];
            var ucret_id = row["ucret_id"];
            var marka = row["marka"];
            var model = row["model"];
            var yıl = row["yıl"];
            var yakıt = row["yakıt"];
            var vites = row["vites"];
            var km = row["km"];
            var renk = row["renk"];
            var kasa_tipi = row["kasa_tipi"];

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            string cmdStr = "select arac_id,ucret_id,ucret,gun_bilgisi from ucret where arac_id='" + arac_id + "'";
            exceleGelecekler = cmdStr;
            SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt6 = new DataTable();
            da.Fill(dt6);
            dataGridView6.DataSource = dt6;


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            kayit_bilgileri k = new kayit_bilgileri();
            k.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
            baglanti.Open();
            DataSet excelDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(exceleGelecekler, baglanti); 
            da.Fill(excelDataSet, "kuls");


            ExcelNesnesi.Workbooks.Add(true);
            ExcelNesnesi.Visible = true;
            tablo = (Microsoft.Office.Interop.Excel.Worksheet)ExcelNesnesi.ActiveSheet;

            foreach (System.Data.DataTable table in excelDataSet.Tables)
            {
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    tablo.Cells[1, i] = table.Columns[i - 1].ColumnName;    
                }

                for (int j = 0; j < table.Rows.Count; j++)
                    for (int k = 0; k < table.Columns.Count; k++)
                        tablo.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
            }
        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Lutfen bir dosya secin";
            dosyaAc.Filter = "Metin Dosyaları |*.txt";
            dosyaAc.Multiselect = false;
            StreamReader oku;
            ArrayList disardan = new ArrayList();
            try
            { 
            

                string s;
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    oku = new StreamReader(dosyaAc.FileName);
                    while ((s = oku.ReadLine()) != null)
                    {
                        disardan.Add(s);
                    }
                 

                    oku.Close();
                }
                else
                {
                    MessageBox.Show("Dosya Açma Hatası");
                }
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=.\SQLEXPRESS; Database=veritabani;Trusted_Connection=true;";
                baglanti.Open();
                string cmdStr = "Insert into arac ([marka],[model],[yıl],[yakıt],[vites],[km],[renk],[kasa_tipi]) values('" + disardan[0] + "','" + disardan[1] + "','" + disardan[2] + "','" + disardan[3] + "','" + disardan[4] + "','" + disardan[5] + "','" + disardan[6] + "','" + disardan[7] + "')";
                exceleGelecekler = cmdStr;
                SqlCommand cmd = new SqlCommand(cmdStr, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Verileriniz Tabloya Eklenmiştir.");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Text Dosyası Seçmelisiniz");
            }
            

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
