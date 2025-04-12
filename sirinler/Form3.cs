using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;//avatar
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Configuration;//ayar
using System.Net; // InputBox için 
using System.Net.Mail;
using Microsoft.VisualBasic.ApplicationServices;


namespace sirinler
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=sirin;Integrated Security=True;";
        private string selectedAvatar = "";
        private Panel avatarPanel;
        private string verificationCode = "";
        public Form3()
        {
            InitializeComponent();
            InitializeAvatarSelection(); // seçim paneli
            avatarPanel.Visible = false;

            if (Properties.Settings.Default.BeniHatirla) //beni hatırla text
            {
                textBox1.Text = Properties.Settings.Default.KullaniciAdi;
                textBox2.Text = Properties.Settings.Default.Sifre;
                checkBoxBeniHatirla.Checked = true;
            }
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            checkBoxBeniHatirla.Checked = Properties.Settings.Default.BeniHatirla;

            if (checkBoxBeniHatirla.Checked)
            {
                textBox1.Text = Properties.Settings.Default.KullaniciAdi;
                textBox2.Text = Properties.Settings.Default.Sifre;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        private void InitializeAvatarSelection()
        {
            avatarPanel = new Panel();
            avatarPanel.Size = new Size(220, 100);//boy
            avatarPanel.Location = new Point(pictureBoxAvatar.Left - avatarPanel.Width - 10, pictureBoxAvatar.Top);//solda açıl
            avatarPanel.Visible = false;
            avatarPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(avatarPanel);
            string[] avatarPaths = { "avatar1.png", "avatar2.png", "avatar3.png" };

            for (int i = 0; i < avatarPaths.Length; i++)
            {
                if (File.Exists(avatarPaths[i]))
                {
                    PictureBox picAvatar = new PictureBox();
                    picAvatar.Image = Image.FromFile(avatarPaths[i]);
                    picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAvatar.Size = new Size(60, 60);
                    picAvatar.Location = new Point(i * 70, 10);
                    picAvatar.Tag = avatarPaths[i]; // Dosya adını 
                    picAvatar.Click += new EventHandler(Avatar_Click);
                    avatarPanel.Controls.Add(picAvatar);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı: " + avatarPaths[i]);
                }
            }
            Button btnTamam = new Button();
            btnTamam.Text = "Tamam";
            btnTamam.Location = new Point(60, 70);
            btnTamam.Size = new Size(100, 25);
            btnTamam.Click += new EventHandler(BtnTamam_Click);
            avatarPanel.Controls.Add(btnTamam);
        }
        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            avatarPanel.Visible = !avatarPanel.Visible;
            avatarPanel.BringToFront();
            avatarPanel.Refresh();
            avatarPanel.Location = new Point(pictureBoxAvatar.Left - avatarPanel.Width - 10, pictureBoxAvatar.Top);
        }
        private void Avatar_Click(object sender, EventArgs e)
        {
            PictureBox tiklananResim = sender as PictureBox;
            if (tiklananResim != null)
            {
                selectedAvatar = tiklananResim.Tag.ToString();
            }
        }


        // "Tamam" butonuna basıldığında seçilen avatar pictureBox'a yüklenir
        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAvatar))
            {
                if (pictureBoxAvatar.Image != null)
                {
                    pictureBoxAvatar.Image.Dispose();
                }
                pictureBoxAvatar.Image = Image.FromFile(selectedAvatar);
                pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            avatarPanel.Visible = false;
        }



        // Kullanıcı giriş butonuna basıldığında çalışır
        private void button2_Click(object sender, EventArgs e)
        {
            // TextBox'lardan kullanıcı adı ve şifre alınır
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            // Eğer herhangi bir alan boşsa, uyarı verilir
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(selectedAvatar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve bir avatar seçin!");
                return;
            }

            // Şifre en az 8 karakter olmalı
            if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!");
                return;
            }

            // SQL Server bağlantısı açılıyor (try–catch kaldırıldı, hata alırsanız hata mesajı çıkacaktır)
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();

            // SQL sorgusu hazırlanıyor: Kullanıcı adı, şifre ve avatar kontrolü
            string sqlSorgu = "SELECT COUNT(*) FROM dbo.sirin WHERE Username = @username AND [Password] = @password AND Avatar = @avatar";
            SqlCommand komut = new SqlCommand(sqlSorgu, baglanti);
            komut.Parameters.AddWithValue("@username", kullaniciAdi);
            komut.Parameters.AddWithValue("@password", sifre);
            komut.Parameters.AddWithValue("@avatar", selectedAvatar);

            // Sorgu çalıştırılıyor
            int kullaniciVarMi = (int)komut.ExecuteScalar();

            // Kullanıcı var ise giriş başarılı mesajı veriliyor, yoksa hata mesajı
            if (kullaniciVarMi > 0)
            {
                MessageBox.Show("Giriş Başarılı!");
            }
            else
            {
                MessageBox.Show("Kaydınız yok veya bilgiler yanlış! Lütfen yeni kayıt oluşturun.");
            }

            // "Beni Hatırla" seçeneğine göre ayarlar kaydediliyor
            if (checkBoxBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = kullaniciAdi;
                Properties.Settings.Default.Sifre = sifre;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.BeniHatirla = false;
            }
            Properties.Settings.Default.Save();

            baglanti.Close();
        }
        private void linkLabelSifremiUnuttum_LinkClicked_1(object sender, EventArgs e)
        {
            // 1. Adım: Kullanıcıdan e-posta adresini al
            string email = Interaction.InputBox("E-posta adresinizi girin:", "Şifremi Unuttum", "");
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Lütfen e-posta adresinizi girin.");
                return;
            }

            // 2. Adım: 6 haneli doğrulama kodu oluştur
            Random rnd = new Random();
            int verificationCode = rnd.Next(100000, 1000000); // 100000-999999

            // 3. Adım: Kod e-posta ile gönder
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("sevvalkarabulut124@gmail.com");
            mail.To.Add("betulokul222@gmail.com");
            mail.Subject = "Doğrulama Kodu";
            mail.Body = "Doğrulama Kodunuz: " + verificationCode;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.EnableSsl = true;
            smtpServer.UseDefaultCredentials = false;
            // Eğer 2FA aktif ve App Password oluşturduysanız, "uygulama_sifresi" kısmına o 16 karakterlik şifreyi yazın.
            smtpServer.Credentials = new NetworkCredential("sevvalkarabulut124@gmail.com", "fsbf cjga sexr ybvo");

            try
            {
                smtpServer.Send(mail);
                MessageBox.Show("Doğrulama kodu e-posta adresinize gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
            }

            // 4. Adım: Kullanıcıdan kodu girmesini iste
            string codeInputStr = Interaction.InputBox("E-posta adresinize gönderilen 6 haneli kodu girin:", "Kod Doğrulama", "");
            if (!int.TryParse(codeInputStr, out int codeInput))
            {
                MessageBox.Show("Geçerli bir kod girmediniz.");
                return;
            }
            if (codeInput != verificationCode)
            {
                MessageBox.Show("Yanlış doğrulama kodu!");
                return;
            }

            // 5. Adım: Yeni şifre ve şifre onayı al
            string newPassword = Interaction.InputBox("Yeni şifrenizi girin:", "Şifre Yenileme", "");
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen yeni şifrenizi girin.");
                return;
            }
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!");
                return;
            }
            string confirmPassword = Interaction.InputBox("Yeni şifrenizi tekrar girin:", "Şifre Onayı", "");
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor! Lütfen tekrar deneyin.");
                return;
            }

            // 6. Adım: Veritabanında şifreyi güncelle
            SqlConnection baglanti = new SqlConnection(connectionString);
            try
            {
                baglanti.Open();
                string sqlSorgu = "UPDATE dbo.sirin SET [Password] = @password WHERE Email = @email";
                SqlCommand komut = new SqlCommand(sqlSorgu, baglanti);
                komut.Parameters.AddWithValue("@password", newPassword);
                komut.Parameters.AddWithValue("@email", email);
                int etkilenenSatir = komut.ExecuteNonQuery();

                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Şifreniz başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("E-posta adresi bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }



        // "Geri Dön" linkine tıklandığında Form1 açılır
        private void linkLabel2_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        // "İleti Gönder" butonuna basıldığında mesaj kutusu gösterilir
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletiniz başarıyla gönderilmiştir");
        }

        // "Çıkış" butonuna basıldığında program kapatılır
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // "Yardım" menü seçeneği tıklandığında, bilgi mesajı gösterilir
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Çocukların eğlenerek oynayacağı gargamelden kaçış çocukların motor becerilerini geliştirmek için bir numaradır.\n" +
                "• İsim, şifre: Oyuna girmek için gerekli.\n" +
                "• İletişim, görüşleriniz: Her türlü fikirlerinizi iletebilirsiniz.\n\n" +
                "Ek bilgiler için lütfen 0366 866 10 04 numarasını arayın.",
                "Yardım",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // "Hakkımızda" menü seçeneği tıklandığında bilgi paneli açılır ve metin gösterilir
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label4.AutoSize = false;
            label4.Size = new Size(300, 200); // Panelin genişlik ve yükseklik ayarlanıyor
            label4.Text = "Biz, kullanıcı deneyimini en üst düzeye çıkarmayı hedefleyen yenilikçi bir ekip olarak,\n" +
                          "oyun sektöründe fark yaratmak için buradayız.\n" +
                          "Projemiz, oyuna tıklandığı anda çarpıcı açılış sesi, logo ve isimle başlayan,\n" +
                          "kullanıcıyı hemen içine çeken dinamik bir deneyim sunuyor.\n" +
                          "Giriş ekranımız, hem kayıtlı kullanıcılarımızın hem de yeni gelenlerin kolayca erişebileceği şekilde tasarlanmıştır.";
        }

        // "Kapat" butonuna basıldığında, bilgi paneli kapatılır
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        // Başka bir form (Form4) açmak için kullanılır
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        // Form kapatılırken, "Beni Hatırla" ayarları güncellenir
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = textBox1.Text;
                Properties.Settings.Default.Sifre = textBox2.Text;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.BeniHatirla = false;
            }
            Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. TextBox'lardan verileri al
            string dilek = textBox3.Text.Trim();
            string sikayet = textBox4.Text.Trim();
            string oner = textBox5.Text.Trim();

            // 2. E-posta içeriğini oluştur
            // Kullanıcı sadece birini veya birkaçını doldurabilir, boş kalsa bile gövdeye eklenir.
            string emailBody = "DİLEK:\n" + dilek + "\n\n" +
                               "ŞİKAYET:\n" + sikayet + "\n\n" +
                               "ÖNERİ:\n" + oner;

            // 3. E-postayı gönder
            try
            {
                // MailMessage nesnesi oluştur
                MailMessage mail = new MailMessage();

                // Kimlik doğrulaması yapılan Gmail hesabınız
                mail.From = new MailAddress("sumeyyebdemir@gmail.com");

                // Kendinize veya başka bir sabit e-posta adresine göndermek istiyorsanız:
                mail.To.Add("sumeyyebdemir@gmail.com");

                // Konu ve gövde
                mail.Subject = "Kullanıcı Görüşleri (Dilek - Şikayet - Öneri)";
                mail.Body = emailBody;

                // Gmail SMTP ayarları
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("sumeyyebdemir@gmail.com", "rpbj uvwv vivo pyoj");
                smtp.EnableSsl = true;

                // E-posta gönderimi
                smtp.Send(mail);

                // 4. Kullanıcıya gönderim sonucu mesajı göster
                MessageBox.Show("Görüşleriniz başarıyla iletildi!");

                // İsterseniz, gönderimden sonra textBox'ları temizleyebilirsiniz
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilirken hata oluştu: " + ex.Message);
            }
        }
    }
}