using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace BarkinsForms
{
    public partial class frmekran : Form
    {
        public frmekran()
        {
            InitializeComponent();
            Bitmap bmpDosya = new Bitmap(@"C:\Users\barkines\Desktop\setup-512.png");
            this.BackgroundImage = bmpDosya;
            this.BackgroundImageLayout = ImageLayout.Center;
            //this.ForeColor = Color.FromArgb(123,67,202);
            this.Font = new Font("Comic Sans MS", 20, FontStyle.Italic);
            Random rndRastgele = new Random();
            int K = rndRastgele.Next(0, 256);
            int Y = rndRastgele.Next(0, 256);
            int M = rndRastgele.Next(0, 256);
            this.ForeColor = Color.FromArgb(K, Y, M);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            string baslikMetni = "Barkin's Program";
            this.Text = baslikMetni;
            bool beklemeSimgesi = false;
            this.UseWaitCursor = beklemeSimgesi;
            this.Enabled = true;
            DateTime dTarih = new DateTime(1993, 10, 19);
            this.Tag = dTarih;
            this.Size = new Size(550, 650);
            this.WindowState = FormWindowState.Minimized;
            this.HelpButton = true;
            //this.ShowInTaskbar = false;
            //this.TopMost = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;




        }

        private void arttır_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tagmetni = String.Format("{0}", this.Tag);
            if (tagmetni != "Sistem Uzmanlığı")
            {
                MessageBox.Show("Welcome to barkin's System");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            MessageBox.Show("Veritabanına kayıt edildi, Hoşgeldiniz!" + ad + soyad, "BarkinsSystem");


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Font yaziStil = new Font("Arial", 15, FontStyle.Bold);
            this.Font = yaziStil;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Font yaziStil2 = new Font("Arial", 15, FontStyle.Bold);
            this.Font = yaziStil2;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemler yapıldı!");
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem iptal edildi!");
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        int tiklamaNo = 0;
        private void Tiklandi(object sender, EventArgs e)
        {
            tiklamaNo++;
            MessageBox.Show(string.Format("Forma {0}. defa tıkladınız!"), Convert.ToString(tiklamaNo));

        }
        private void Kaydiriliyor(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                MessageBox.Show("Yatay Kaydırılıyor!");
            }
            else MessageBox.Show("Dikey Kaydırılıyor!");
            MessageBox.Show(string.Format("Eski değer {0},yeni değer{1}", e.OldValue, e.NewValue));
        }



        private void Tıklandı(object sender, EventArgs e)
        {
            Label lblEtiket = new Label();
            lblEtiket.Text = "Yeni Kontrol";
            this.Controls.Add(lblEtiket);
        }

        private void KontrolEklendi(object sender, ControlEventArgs e)
        {
            MessageBox.Show(e.Control.GetType().ToString() + " Sınıfından bir kontrol eklendi");
        }
        private void KontrolSilindi(object sender, ControlEventArgs e)
        {
            MessageBox.Show(e.Control.GetType().ToString() + " Sınıfından bir kontrol silindi");
        }

        private void KontrolSilTıklandı(object sender, EventArgs e)
        {
            try
            {
                this.Controls.RemoveAt(0);
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }

        private void Kapandi(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString());
        }

        private void Kapaniyor(object sender, FormClosingEventArgs e)
        {
            DialogResult drDiyalog = new DialogResult();
            drDiyalog = MessageBox.Show("Form Kapatılsınmı?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drDiyalog == DialogResult.Yes) e.Cancel = false;
            else if (drDiyalog == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show("Form Kapanmayacak");
            }

        }

        private void Yardimİstendi(object sender, CancelEventArgs e)
        {
            string DosyaKonumu = @"C:\Users\barkines\Desktop\yardimistendi.txt";
            Process.Start(DosyaKonumu);
        }

    }


}    

  

   



