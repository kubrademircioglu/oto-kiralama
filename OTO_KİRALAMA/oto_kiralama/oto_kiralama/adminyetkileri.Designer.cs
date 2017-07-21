namespace oto_kiralama
{
    partial class adminyetkileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminyetkileri));
            this.button_kekleme = new System.Windows.Forms.Button();
            this.button_ksilme = new System.Windows.Forms.Button();
            this.button_kaddegis = new System.Windows.Forms.Button();
            this.button_ksifredegis = new System.Windows.Forms.Button();
            this.button_kanasayfa = new System.Windows.Forms.Button();
            this.button_kcikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kekleme
            // 
            this.button_kekleme.Location = new System.Drawing.Point(89, 47);
            this.button_kekleme.Name = "button_kekleme";
            this.button_kekleme.Size = new System.Drawing.Size(191, 34);
            this.button_kekleme.TabIndex = 0;
            this.button_kekleme.Text = "KULLANICI EKLEME";
            this.button_kekleme.UseVisualStyleBackColor = true;
            this.button_kekleme.Click += new System.EventHandler(this.button_kekleme_Click);
            // 
            // button_ksilme
            // 
            this.button_ksilme.Location = new System.Drawing.Point(89, 99);
            this.button_ksilme.Name = "button_ksilme";
            this.button_ksilme.Size = new System.Drawing.Size(191, 32);
            this.button_ksilme.TabIndex = 1;
            this.button_ksilme.Text = "KULLANICI SİLME";
            this.button_ksilme.UseVisualStyleBackColor = true;
            this.button_ksilme.Click += new System.EventHandler(this.button_ksilme_Click);
            // 
            // button_kaddegis
            // 
            this.button_kaddegis.Location = new System.Drawing.Point(89, 201);
            this.button_kaddegis.Name = "button_kaddegis";
            this.button_kaddegis.Size = new System.Drawing.Size(191, 34);
            this.button_kaddegis.TabIndex = 2;
            this.button_kaddegis.Text = "KULLANICI AD DEĞİŞTİRME";
            this.button_kaddegis.UseVisualStyleBackColor = true;
            this.button_kaddegis.Click += new System.EventHandler(this.button_kaddegis_Click);
            // 
            // button_ksifredegis
            // 
            this.button_ksifredegis.Location = new System.Drawing.Point(89, 148);
            this.button_ksifredegis.Name = "button_ksifredegis";
            this.button_ksifredegis.Size = new System.Drawing.Size(191, 36);
            this.button_ksifredegis.TabIndex = 3;
            this.button_ksifredegis.Text = "KULLANICI ŞİFRE DEĞİŞTİRME";
            this.button_ksifredegis.UseVisualStyleBackColor = true;
            this.button_ksifredegis.Click += new System.EventHandler(this.button_ksifredegis_Click);
            // 
            // button_kanasayfa
            // 
            this.button_kanasayfa.Location = new System.Drawing.Point(89, 251);
            this.button_kanasayfa.Name = "button_kanasayfa";
            this.button_kanasayfa.Size = new System.Drawing.Size(191, 32);
            this.button_kanasayfa.TabIndex = 4;
            this.button_kanasayfa.Text = "ANA SAYFA";
            this.button_kanasayfa.UseVisualStyleBackColor = true;
            this.button_kanasayfa.Click += new System.EventHandler(this.button_kanasayfa_Click);
            // 
            // button_kcikis
            // 
            this.button_kcikis.Location = new System.Drawing.Point(89, 348);
            this.button_kcikis.Name = "button_kcikis";
            this.button_kcikis.Size = new System.Drawing.Size(191, 31);
            this.button_kcikis.TabIndex = 6;
            this.button_kcikis.Text = "ÇIKIŞ";
            this.button_kcikis.UseVisualStyleBackColor = true;
            this.button_kcikis.Click += new System.EventHandler(this.button_kcikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yapmak istediğiniz işlemi seçiniz.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "KULLANICI YETKİLERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminyetkileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kcikis);
            this.Controls.Add(this.button_kanasayfa);
            this.Controls.Add(this.button_ksifredegis);
            this.Controls.Add(this.button_kaddegis);
            this.Controls.Add(this.button_ksilme);
            this.Controls.Add(this.button_kekleme);
            this.Name = "adminyetkileri";
            this.Text = "adminyetkileri";
            this.Load += new System.EventHandler(this.adminyetkileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kekleme;
        private System.Windows.Forms.Button button_ksilme;
        private System.Windows.Forms.Button button_kaddegis;
        private System.Windows.Forms.Button button_ksifredegis;
        private System.Windows.Forms.Button button_kanasayfa;
        private System.Windows.Forms.Button button_kcikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}