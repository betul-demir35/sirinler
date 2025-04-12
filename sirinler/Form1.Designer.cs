namespace sirinler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxAvatar = new PictureBox();
            menuStrip1 = new MenuStrip();
            geriDönToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            txtSurname = new TextBox();
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(628, 170);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 45);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "isim";
            toolTip1.SetToolTip(txtUsername, "isim giriniz");
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(628, 325);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 44);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "şifre";
            toolTip2.SetToolTip(txtPassword, "şifre giriniz");
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.ForeColor = SystemColors.WindowFrame;
            txtEmail.Location = new Point(628, 274);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 45);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "e-mail";
            toolTip3.SetToolTip(txtEmail, "email giriniz");
            // 
            // btnRegister
            // 
            btnRegister.BackgroundImage = Properties.Resources.group2;
            btnRegister.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegister.Location = new Point(673, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.RightToLeft = RightToLeft.Yes;
            btnRegister.Size = new Size(133, 35);
            btnRegister.TabIndex = 6;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(969, 535);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = Color.Transparent;
            pictureBoxAvatar.Image = (Image)resources.GetObject("pictureBoxAvatar.Image");
            pictureBoxAvatar.Location = new Point(663, 42);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(143, 104);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 9;
            pictureBoxAvatar.TabStop = false;
            toolTip4.SetToolTip(pictureBoxAvatar, "avatar seçiniz");
            pictureBoxAvatar.Click += Avatar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { geriDönToolStripMenuItem, çıkışToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // geriDönToolStripMenuItem
            // 
            geriDönToolStripMenuItem.BackColor = Color.WhiteSmoke;
            geriDönToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            geriDönToolStripMenuItem.Name = "geriDönToolStripMenuItem";
            geriDönToolStripMenuItem.Size = new Size(79, 24);
            geriDönToolStripMenuItem.Text = "geri dön";
            geriDönToolStripMenuItem.Click += geriDönToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.BackColor = Color.WhiteSmoke;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(51, 24);
            çıkışToolStripMenuItem.Text = "çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.BackColor = Color.WhiteSmoke;
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(69, 24);
            yardımToolStripMenuItem.Text = "yardım";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.WhiteSmoke;
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSurname.ForeColor = SystemColors.WindowFrame;
            txtSurname.Location = new Point(628, 223);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(200, 45);
            txtSurname.TabIndex = 11;
            txtSurname.Text = "soyisim";
            toolTip1.SetToolTip(txtSurname, "isim giriniz");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(969, 563);
            Controls.Add(txtSurname);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxAvatar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem geriDönToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private TextBox txtSurname;
    }
}
