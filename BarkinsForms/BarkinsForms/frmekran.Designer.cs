namespace BarkinsForms
{
    partial class frmekran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKontrolEkle = new System.Windows.Forms.Button();
            this.btnKontrolSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(426, 135);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(185, 52);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(279, 286);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(184, 52);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal et";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.Location = new System.Drawing.Point(53, 193);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(107, 23);
            this.btnTamEkran.TabIndex = 7;
            this.btnTamEkran.Text = "Tam Ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.Location = new System.Drawing.Point(426, 193);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(90, 23);
            this.btnKucult.TabIndex = 8;
            this.btnKucult.Text = "Küçült";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(279, 257);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(102, 23);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKontrolEkle
            // 
            this.btnKontrolEkle.Location = new System.Drawing.Point(38, 17);
            this.btnKontrolEkle.Name = "btnKontrolEkle";
            this.btnKontrolEkle.Size = new System.Drawing.Size(105, 23);
            this.btnKontrolEkle.TabIndex = 10;
            this.btnKontrolEkle.Text = "KontrolEkle";
            this.btnKontrolEkle.UseVisualStyleBackColor = true;
            this.btnKontrolEkle.Click += new System.EventHandler(this.Tıklandı);
            // 
            // btnKontrolSil
            // 
            this.btnKontrolSil.Location = new System.Drawing.Point(38, 53);
            this.btnKontrolSil.Name = "btnKontrolSil";
            this.btnKontrolSil.Size = new System.Drawing.Size(105, 23);
            this.btnKontrolSil.TabIndex = 11;
            this.btnKontrolSil.Text = "KontrolSil";
            this.btnKontrolSil.UseVisualStyleBackColor = true;
            this.btnKontrolSil.Click += new System.EventHandler(this.KontrolSilTıklandı);
            // 
            // frmekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 611);
            this.Controls.Add(this.btnKontrolSil);
            this.Controls.Add(this.btnKontrolEkle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmekran";
            this.Tag = "Yazılım Uzmanlığı";
            this.Text = "Veritabanı uygulaması";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Yardimİstendi);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kapaniyor);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kapandi);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Tiklandi);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.KontrolEklendi);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.KontrolSilindi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamEkran;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKontrolEkle;
        private System.Windows.Forms.Button btnKontrolSil;
    }
}

