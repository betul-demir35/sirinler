namespace sirinler
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabelSifremiUnuttum = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBoxAvatar = new PictureBox();
            checkBoxBeniHatirla = new CheckBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            toolTip6 = new ToolTip(components);
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.group1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(304, 387);
            button2.Name = "button2";
            button2.Size = new Size(104, 35);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(160, 297);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 51);
            textBox2.TabIndex = 1;
            textBox2.Text = "şifre";
            toolTip2.SetToolTip(textBox2, "şifre giriniz");
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(160, 224);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "isim";
            toolTip1.SetToolTip(textBox1, "isim giriniz");
            // 
            // linkLabelSifremiUnuttum
            // 
            linkLabelSifremiUnuttum.AutoSize = true;
            linkLabelSifremiUnuttum.BackColor = Color.Transparent;
            linkLabelSifremiUnuttum.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabelSifremiUnuttum.LinkColor = Color.Black;
            linkLabelSifremiUnuttum.Location = new Point(160, 351);
            linkLabelSifremiUnuttum.Margin = new Padding(4, 0, 4, 0);
            linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            linkLabelSifremiUnuttum.Size = new Size(182, 27);
            linkLabelSifremiUnuttum.TabIndex = 3;
            linkLabelSifremiUnuttum.TabStop = true;
            linkLabelSifremiUnuttum.Text = "şifremi unuttum";
            toolTip6.SetToolTip(linkLabelSifremiUnuttum, "şifremi unuttum");
            linkLabelSifremiUnuttum.LinkClicked += linkLabelSifremiUnuttum_LinkClicked_1;
            linkLabelSifremiUnuttum.Click += linkLabelSifremiUnuttum_LinkClicked_1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(160, 387);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 28);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "yeni üye";
            toolTip5.SetToolTip(linkLabel2, "üye kaydı");
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            linkLabel2.Click += linkLabel2_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(974, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.gargamelden_kaçış__1_;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(-36, -49);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 178);
            panel1.TabIndex = 8;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = Color.Transparent;
            pictureBoxAvatar.BackgroundImage = (Image)resources.GetObject("pictureBoxAvatar.BackgroundImage");
            pictureBoxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar.Image = Properties.Resources.Flying_Smurf_Sticker___Flying_Smurf_Smurf102___GIF_탐색_및_공유;
            pictureBoxAvatar.Location = new Point(237, 111);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(125, 107);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 9;
            pictureBoxAvatar.TabStop = false;
            toolTip3.SetToolTip(pictureBoxAvatar, "avatar seçiniz");
            pictureBoxAvatar.Click += pictureBoxAvatar_Click;
            // 
            // checkBoxBeniHatirla
            // 
            checkBoxBeniHatirla.AutoSize = true;
            checkBoxBeniHatirla.BackColor = Color.Transparent;
            checkBoxBeniHatirla.Location = new Point(12, 298);
            checkBoxBeniHatirla.Name = "checkBoxBeniHatirla";
            checkBoxBeniHatirla.Size = new Size(128, 25);
            checkBoxBeniHatirla.TabIndex = 10;
            checkBoxBeniHatirla.Text = "beni hatırla";
            checkBoxBeniHatirla.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 25.8F);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(274, 0);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 52);
            label1.TabIndex = 11;
            label1.Text = "HOŞGELDİN ŞİRİN";
            toolTip4.SetToolTip(label1, "hoşgeldiniz");
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(755, 1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(215, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.BackColor = Color.White;
            hakkımızdaToolStripMenuItem.Image = Properties.Resources.settings;
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(118, 24);
            hakkımızdaToolStripMenuItem.Text = "hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.BackColor = Color.White;
            yardımToolStripMenuItem.ForeColor = Color.Black;
            yardımToolStripMenuItem.Image = Properties.Resources.question;
            yardımToolStripMenuItem.ImageAlign = ContentAlignment.TopRight;
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(89, 24);
            yardımToolStripMenuItem.Text = "yardım";
            yardımToolStripMenuItem.Click += yardımToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._switch;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(1019, 0);
            button3.Name = "button3";
            button3.Size = new Size(39, 36);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(656, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 300);
            panel2.TabIndex = 15;
            panel2.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(298, 294);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(290, 260);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hakkımızda";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(278, 254);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(290, 261);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "görüşleriniz";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(222, 30);
            button1.Name = "button1";
            button1.Size = new Size(62, 175);
            button1.TabIndex = 3;
            button1.Text = "gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InfoText;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.ForeColor = SystemColors.Menu;
            textBox5.Location = new Point(3, 162);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 64);
            textBox5.TabIndex = 2;
            textBox5.Text = "ÖNERİ";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InfoText;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = SystemColors.Menu;
            textBox4.Location = new Point(3, 81);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 65);
            textBox4.TabIndex = 1;
            textBox4.Text = "ŞİKAYET";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InfoText;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(3, 6);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 59);
            textBox3.TabIndex = 0;
            textBox3.Text = "DİLEK";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.close1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.ImageAlign = ContentAlignment.TopRight;
            button4.Location = new Point(937, 32);
            button4.Name = "button4";
            button4.Size = new Size(22, 22);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(0, 535);
            button5.Name = "button5";
            button5.Size = new Size(66, 28);
            button5.TabIndex = 16;
            button5.Text = "!";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.indir2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(969, 563);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(checkBoxBeniHatirla);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(panel1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabelSifremiUnuttum);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private LinkLabel linkLabelSifremiUnuttum;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBoxAvatar;
        private CheckBox checkBoxBeniHatirla;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private Button button3;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private Panel panel2;
        private Button button4;
        private Label label4;
        private Button button5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
    }
}