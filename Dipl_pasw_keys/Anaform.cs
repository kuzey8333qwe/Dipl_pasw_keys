using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dipl_pasw_keys
{
    public partial class Anaform : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database=dipl_pasw_keys; Uid=root; Pwd='Dabuluardabulu1ck'");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Anaform()
        {
            InitializeComponent();
        }
        private void Anaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void VeriGetir()
        {
            //form yüklenirken içerigin otomatik dolmasını kolonların gözükmesini saglar
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM sifreler", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void Anaform_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        public string AesleSifrele(string veri, string anahtar)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = new byte[32];
                Array.Copy(Encoding.UTF8.GetBytes(anahtar.PadRight(aesAlg.Key.Length)), aesAlg.Key, aesAlg.Key.Length);
                aesAlg.IV = new byte[16];

                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(veri);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        public string AesCoz(string sifrelenmisVeri, string anahtar)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = new byte[32];
                Array.Copy(Encoding.UTF8.GetBytes(anahtar.PadRight(aesAlg.Key.Length)), aesAlg.Key, aesAlg.Key.Length);
                aesAlg.IV = new byte[16];

                var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(sifrelenmisVeri)))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }




        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string sifrelenmisSifre = row.Cells["sif_kul_sifre"].Value.ToString();
                string anahtar = "BuÇokGizliBirAnahtar!"; // Aynı anahtar kullanılmalı
                string cozulenSifre = AesCoz(sifrelenmisSifre, anahtar);

                txtKayitNo.Text = row.Cells["sif_RECno"].Value.ToString();
                txtKullaniciAdiMail.Text = row.Cells["sif_kul_adi_mail"].Value.ToString();
                //txtSifre.Text = row.Cells["sif_kul_sifre"].Value.ToString();
                txtSifre.Text = cozulenSifre; // Şifrelenmiş yerine çözülen şifre
                txtNotlar.Text = row.Cells["sif_notlar"].Value.ToString();
                txtSiteAdi.Text = row.Cells["sif_site_adi"].Value.ToString();
                txtSiteUrl.Text = row.Cells["sif_site_url"].Value.ToString();            //data gridden üstüne tıklanıldııgnda textboxlar dolsun diye
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string anahtar = "BuÇokGizliBirAnahtar!"; // 32 karakterli bir anahtar (256 bit)
            string sifrelenmisSifre = AesleSifrele(txtSifre.Text, anahtar);

            string sql = "INSERT INTO sifreler(sif_kul_adi_mail, sif_kul_sifre, sif_notlar, sif_site_adi, sif_site_url, sif_kayit_tarih)" + "VALUES (@kuladimail, @kulsifre, @notlar, @siteadi, @siteurl, @kayittarih)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kuladimail", txtKullaniciAdiMail.Text);
            cmd.Parameters.AddWithValue("@kulsifre", sifrelenmisSifre);
            cmd.Parameters.AddWithValue("@notlar", txtNotlar.Text);
            cmd.Parameters.AddWithValue("@siteadi", txtSiteAdi.Text);
            cmd.Parameters.AddWithValue("@siteurl", txtSiteUrl.Text);
            cmd.Parameters.AddWithValue("@kayittarih", DateTime.Now); // Kayıt tarihini ekliyoruz.

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            VeriGetir();
            MessageBox.Show("Kayıt başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM sifreler WHERE sif_RECno=@RECno";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RECno", txtKayitNo.Text); // TextBox içeriği alınıyor

            conn.Open();
            cmd.ExecuteNonQuery();

            // AUTO_INCREMENT'i güncelle
            MySqlCommand otomatikArtmayıSıfırla = new MySqlCommand("ALTER TABLE sifreler AUTO_INCREMENT = 1", conn);
            otomatikArtmayıSıfırla.ExecuteNonQuery();

            conn.Close();

            VeriGetir();
            MessageBox.Show("Silme başarılı");
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE sifreler SET sif_kul_adi_mail=@kuladimail, sif_kul_sifre=@kulsifre, sif_notlar=@notlar, sif_site_adi=@siteadi, sif_site_url=@siteurl, sif_guncelleme_tarih=@guncellemetarih WHERE sif_RECno=@RECno";



                string anahtar = "BuÇokGizliBirAnahtar!"; // 32 karakterli bir anahtar (256 bit)                 //
                string sifrelenmisSifre = AesleSifrele(txtSifre.Text, anahtar);                                  //

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kuladimail", txtKullaniciAdiMail.Text);
                //cmd.Parameters.AddWithValue("@kulsifre", txtSifre.Text);                  //burayı ben yaptım ve üstede // lı yerleri ekledim
                cmd.Parameters.AddWithValue("@kulsifre", sifrelenmisSifre);
                cmd.Parameters.AddWithValue("@notlar", txtNotlar.Text);
                cmd.Parameters.AddWithValue("@siteadi", txtSiteAdi.Text);
                cmd.Parameters.AddWithValue("@siteurl", txtSiteUrl.Text);
                cmd.Parameters.AddWithValue("@guncellemetarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@RECno", txtKayitNo.Text);

                // Bağlantı kontrolü ve açma
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            VeriGetir(); // Verileri yenile
        }

        private void btnÖzelAra_Click(object sender, EventArgs e)
        {
            // Aranacak site adı
            string aranacakSiteAdı = txtSiteAdıAra.Text.Trim();

            if (string.IsNullOrEmpty(aranacakSiteAdı))
            {
                MessageBox.Show("Lütfen aranacak site adını giriniz.", "Uyarı");
                return;
            }

            // Veritabanı bağlantısı
            string connectionString = "server=localhost; Database=dipl_pasw_keys; Uid=root; Pwd='Dabuluardabulu1ck'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Arama sorgusu
                    string query = "SELECT * FROM sif_site_adi WHERE SiteAdı LIKE @siteAdı";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@siteAdı", "%" + aranacakSiteAdı + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Sonuçları göster
                            while (reader.Read())
                            {
                                MessageBox.Show("Bulunan Site Adı: " + reader["SiteAdı"].ToString(), "Sonuç");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aradığınız site adı bulunamadı.", "Sonuç");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata");
                }
            }
        }

        public void Temizle()
        {
            txtKullaniciAdiMail.Text = "";
            txtSifre.Text = "";
            txtNotlar.Text = "";
            txtSiteAdi.Text = "";
            txtSiteUrl.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        

        private void txtSite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {

        }
    }
}
