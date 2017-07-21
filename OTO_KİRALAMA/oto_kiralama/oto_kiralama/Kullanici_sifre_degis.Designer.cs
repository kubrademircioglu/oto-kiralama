namespace oto_kiralama
{
    partial class Kullanici_sifre_degis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_sifre_degis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ksd = new System.Windows.Forms.ComboBox();
            this.textBox_ksdyeniparola = new System.Windows.Forms.TextBox();
            this.button_ksdkaydet = new System.Windows.Forms.Button();
            this.button_ksddön = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Parola";
            // 
            // comboBox_ksd
            // 
            this.comboBox_ksd.FormattingEnabled = true;
            this.comboBox_ksd.Location = new System.Drawing.Point(136, 22);
            this.comboBox_ksd.Name = "comboBox_ksd";
            this.comboBox_ksd.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ksd.TabIndex = 2;
            this.comboBox_ksd.SelectedIndexChanged += new System.EventHandler(this.comboBox_ksd_SelectedIndexChanged);
            // 
            // textBox_ksdyeniparola
            // 
            this.textBox_ksdyeniparola.Location = new System.Drawing.Point(136, 160);
            this.textBox_ksdyeniparola.Name = "textBox_ksdyeniparola";
            this.textBox_ksdyeniparola.Size = new System.Drawing.Size(121, 20);
            this.textBox_ksdyeniparola.TabIndex = 3;
            // 
            // button_ksdkaydet
            // 
            this.button_ksdkaydet.Location = new System.Drawing.Point(87, 193);
            this.button_ksdkaydet.Name = "button_ksdkaydet";
            this.button_ksdkaydet.Size = new System.Drawing.Size(132, 30);
            this.button_ksdkaydet.TabIndex = 4;
            this.button_ksdkaydet.Text = "KAYDET";
            this.button_ksdkaydet.UseVisualStyleBackColor = true;
            this.button_ksdkaydet.Click += new System.EventHandler(this.button_ksdkaydet_Click);
            // 
            // button_ksddön
            // 
            this.button_ksddön.Location = new System.Drawing.Point(60, 246);
            this.button_ksddön.Name = "button_ksddön";
            this.button_ksddön.Size = new System.Drawing.Size(188, 30);
            this.button_ksddön.TabIndex = 5;
            this.button_ksddön.Text = "ADMİN YETKİLERİNE GERİ DÖN";
            this.button_ksddön.UseVisualStyleBackColor = true;
            this.button_ksddön.Click += new System.EventHandler(this.button_ksddön_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Şifreyi Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eski Şifre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Kullanici_sifre_degis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ksddön);
            this.Controls.Add(this.button_ksdkaydet);
            this.Controls.Add(this.textBox_ksdyeniparola);
            this.Controls.Add(this.comboBox_ksd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanici_sifre_degis";
            this.Text = "Kullanici_sifre_degis";
            this.Load += new System.EventHandler(this.Kullanici_sifre_degis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ksd;
        private System.Windows.Forms.TextBox textBox_ksdyeniparola;
        private System.Windows.Forms.Button button_ksdkaydet;
        private System.Windows.Forms.Button button_ksddön;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}