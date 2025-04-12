using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace sirinler
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form2()
        {
            InitializeComponent();
            PlaySound(); // Form açıldığında sesi oynat

            // Form özellikleri
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(690, 485);
            this.BackColor = Color.White;

            // PictureBox ile GIF ekleme
            PictureBox loadingGif = new PictureBox
            {
                Size = new Size(690, 485),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                loadingGif.Image = Image.FromFile(@"C:\Users\EXCALİBUR\Source\Repos\sirinler\sirinler\loading-thinking.gif");
            }
            catch (Exception ex)
            {
                MessageBox.Show("GIF yüklenirken hata oluştu: " + ex.Message);
            }

            this.Controls.Add(loadingGif);

            // Timer ile form geçişini ayarla
            timer = new System.Windows.Forms.Timer
            {
                Interval = 5000 // 5 saniye sonra form geçişi
            };

            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();

            };
            timer.Start();
        }

        private void PlaySound()
        {
            try
            {
                string soundPath = @"C:\Users\EXCALİBUR\Source\Repos\sirinler\sirinler\ses.wav";

                if (!System.IO.File.Exists(soundPath))
                {
                    MessageBox.Show("Ses dosyası bulunamadı! Yol: " + soundPath);
                    return;
                }

                SoundPlayer player = new SoundPlayer(soundPath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses çalınırken hata oluştu: " + ex.Message);
            }
        }
    }
}