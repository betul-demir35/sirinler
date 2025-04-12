using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Configuration;//ayar
using Microsoft.VisualBasic.ApplicationServices;

namespace sirinler
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=sirin;Integrated Security=True;";
        private string selectedAvatar = "default_avatar.png";
        private string verificationCode = "";
        private bool isVerified = false;
        private Panel avatarPanel;
      

        public Form1()
        {
            InitializeComponent();
            InitializeAvatarSelection(); // seçim paneli
            avatarPanel.Visible = false;

            // Form açılışında şifre alanı gizli olsun.
            txtPassword.Visible = false;

         
        }


        // btnRegister: İlk aşamada doğrulama, ikinci aşamada kayıt işlemi yapacak.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // İlk aşamada (şifre alanı görünmüyorsa): isim, soyisim ve e-posta bilgilerini kontrol et.
            if (!txtPassword.Visible)
            {
                string kullaniciAdi = txtUsername.Text.Trim();
                string soyad = txtSurname.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Lütfen kullanıcı adı, soyisim ve e-posta alanlarını doldurun!");
                    return;
                }

                // Doğrulama kodunu gönder
                SendVerificationCode(email, kullaniciAdi, soyad);
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("E-posta adresinize gönderilen doğrulama kodunu giriniz:", "Kod Onayı", "", -1, -1);

                if (userInput == verificationCode)
                {
                    MessageBox.Show("Doğrulama başarılı! Şifre alanı açıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Visible = true;
                    btnRegister.Text = "Kayıt Ol"; // Buton metnini güncelle
                    isVerified = true;
                }
                else
                {
                    MessageBox.Show("Yanlış kod girdiniz! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // İkinci aşamada: Şifre girilmişse ve geçerliyse kayıt işlemini yap.
                string kullaniciAdi = txtUsername.Text.Trim();
                string soyad = txtSurname.Text.Trim();
                string sifre = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen şifre alanını doldurun!");
                    return;
                }

                if (sifre.Length < 8)
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalıdır!");
                    return;
                }

                // Kayıt bilgilerini veritabanına ekle
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO sirin (Username, Surname, Password, Email, Avatar) VALUES (@Username, @Surname, @Password, @Email, @Avatar)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Surname", soyad);
                        cmd.Parameters.AddWithValue("@Password", sifre);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Avatar", selectedAvatar);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Kullanıcının adının ilk 3 harfi, soyadının son 2 harfi ve "2025" eklenerek doğrulama kodu oluşturulur.
        private string GenerateVerificationCode(string isim, string soyisim)
        {
            string first3 = isim.Length >= 3 ? isim.Substring(0, 3) : isim;
            string last2 = soyisim.Length >= 2 ? soyisim.Substring(soyisim.Length - 2) : soyisim;
            return first3 + last2 + "2025";
        }

        // Belirtilen e-posta adresine doğrulama kodu gönderilir.
        private void SendVerificationCode(string email, string isim, string soyisim)
        {
            verificationCode = GenerateVerificationCode(isim, soyisim);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sevvalkarabulut124@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Doğrulama Kodu";
                mail.Body = "Doğrulama Kodunuz: " + verificationCode;
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("sevvalkarabulut124@gmail.com", "bmcl knlk fiqx nisr");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                MessageBox.Show("Doğrulama kodu e-posta adresinize gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
            }
        }

       private void InitializeAvatarSelection()
{
    avatarPanel = new Panel
    {
        Size = new Size(300, 100),
        Location = new Point(10, 10), // Sabit bir konuma koyalım
        BackColor = Color.LightGray,  // Görünür olsun diye arka plan rengi veriyoruz
        Visible = false,
        BorderStyle = BorderStyle.FixedSingle
    };
    this.Controls.Add(avatarPanel);

    // Avatar resimlerinin olduğu klasör
    string avatarDirectory = @"C:\Users\EXCALİBUR\Source\Repos\sirinler\sirinler\bin\Debug\net8.0-windows";
    string[] avatarFiles = { "avatar1.png", "avatar2.png", "avatar3.png" };

    for (int i = 0; i < avatarFiles.Length; i++)
    {
        string fullPath = Path.Combine(avatarDirectory, avatarFiles[i]);
        if (File.Exists(fullPath))
        {
            PictureBox picAvatar = new PictureBox
            {
                Image = Image.FromFile(fullPath),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 60),
                Location = new Point(i * 70, 10),
                Tag = fullPath // Dosya yolunu Tag'e atıyoruz
            };
            picAvatar.Click += Avatar_Click;
            avatarPanel.Controls.Add(picAvatar);
        }
        else
        {
            MessageBox.Show("Dosya bulunamadı: " + fullPath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    Button btnTamam = new Button
    {
        Text = "Tamam",
        Location = new Point(60, 70),
        Size = new Size(100, 25)
    };
    btnTamam.Click += BtnTamam_Click;
    avatarPanel.Controls.Add(btnTamam);
}
        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            // Yalnızca avatar panelinin görünürlüğünü değiştiriyoruz.

            avatarPanel.Visible = !avatarPanel.Visible;
            avatarPanel.BringToFront();
            avatarPanel.Location = new Point(pictureBoxAvatar.Left - avatarPanel.Width - 10, pictureBoxAvatar.Top);
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            // Sender gerçekten PictureBox mı ve Tag'i string mi kontrol edelim
            if (sender is PictureBox tiklananResim && tiklananResim.Tag is string tagValue && !string.IsNullOrEmpty(tagValue))
            {
                selectedAvatar = tagValue;
                MessageBox.Show("Seçilen Avatar: " + selectedAvatar, "Bilgi");
            }
            else
            {
                MessageBox.Show("Hata: Tag değeri boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAvatar))
            {
                try
                {
                    if (pictureBoxAvatar.Image != null)
                    {
                        pictureBoxAvatar.Image.Dispose();
                    }
                    pictureBoxAvatar.Image = Image.FromFile(selectedAvatar);
                    pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Avatar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir avatar seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            avatarPanel.Visible = false;
        }



        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
