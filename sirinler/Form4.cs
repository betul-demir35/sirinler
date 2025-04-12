using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sirinler
{
    public partial class Form4 : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=sirin;Trusted_Connection=True;";
        private bool siralamaTers = false; // Sıralama yönünü kontrol edecek

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            ComboBoxDoldur();
        }

        private void VerileriGetir(string orderBy = "ASC")
        {
            string query = $"SELECT * FROM sirin ORDER BY ID {orderBy}"; // ID'ye göre sıralama yap

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboBoxDoldur()
        {
            // Combobox içine varsayılan avatar seçeneklerini ekleyelim
            comboBox1.Items.Add("Avatar1");
            comboBox1.Items.Add("Avatar2");
            comboBox1.Items.Add("Avatar3");
            comboBox1.SelectedIndex = 0; // Varsayılan olarak ilkini seç
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO sirin (username, password, email, avatar) VALUES (@username, @password, @email, @avatar)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", textBox1.Text);
                        command.Parameters.AddWithValue("@password", textBox2.Text);
                        command.Parameters.AddWithValue("@email", textBox3.Text);
                        command.Parameters.AddWithValue("@avatar", comboBox1.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

            string query = "DELETE FROM sirin WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

            string query = "UPDATE sirin SET username = @username, password = @password, email = @email, avatar = @avatar WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@username", textBox1.Text);
                        command.Parameters.AddWithValue("@password", textBox2.Text);
                        command.Parameters.AddWithValue("@email", textBox3.Text);
                        command.Parameters.AddWithValue("@avatar", comboBox1.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (siralamaTers)
            {
                VerileriGetir("ASC"); // ID'ye göre küçükten büyüğe sırala
                siralamaTers = false;
            }
            else
            {
                VerileriGetir("DESC"); // ID'ye göre büyükten küçüğe sırala
                siralamaTers = true;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void üyeKayıtFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // Form1'i aç
            this.Close();
        }

        private void girişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();  // Form1'i aç
            this.Close();
        }
    }
}
