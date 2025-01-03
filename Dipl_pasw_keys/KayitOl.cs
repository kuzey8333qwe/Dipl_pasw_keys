using MySql.Data.MySqlClient;
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

namespace Dipl_pasw_keys
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
            btnŞifreÖner.Click += btnŞifreÖner_Click;
            
            
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
        public static string SifreOlustur(int uzunluk)
        {
            const string karakterler = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890()";
            StringBuilder sonuc = new StringBuilder();
            Random rastgele = new Random();
            for (int i = 0; i < uzunluk; i++)
            {
                sonuc.Append(karakterler[rastgele.Next(karakterler.Length)]);
            }
            return sonuc.ToString();
        }


        MySqlConnection conn = new MySqlConnection("server=localhost; Database=dipl_pasw_keys; Uid=root; Pwd='Dabuluardabulu1ck'");

        public string sha256KoduOlustur(string s)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s)); // ComputeHash bir byte dizisi döner
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2")); // Byte'ları hex formatına çevir
            }
            return sb.ToString(); // StringBuilder'ı string olarak döndür
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı kontrolü için SQL sorgusu
            string sql = "SELECT kul_kod FROM kullanicilar WHERE kul_kod=@P1";

            try
            {
                conn.Open();

                // Kullanıcı adı kontrolü
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P1", txtKullaniciKodu.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Kullanıcı adı zaten mevcut
                    MessageBox.Show(txtKullaniciAdi.Text + " isminde bir kullanıcı zaten mevcut.");
                }
                else
                {
                    // Yeni kullanıcı eklenebilir
                    reader.Close(); // DataReader kapatılmalı

                    // Kullanıcı ekleme sorgusu
                    string insertSql = "INSERT INTO kullanicilar (kul_kod, kul_pw, kul_ad) VALUES (@P1, @P2, @P3)";
                    cmd = new MySqlCommand(insertSql, conn);
                    cmd.Parameters.AddWithValue("@P1", txtKullaniciKodu.Text); // Kullanıcı kodu
                    cmd.Parameters.AddWithValue("@P2", sha256KoduOlustur(txtSifre.Text)); // Şifre
                    cmd.Parameters.AddWithValue("@P3", txtKullaniciAdi.Text); // Kullanıcı adı

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yeni kullanıcı başarıyla eklendi!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("VT bağlantısında sorun oluştu, hata kodu: H001\n" + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        
        
            private void btnŞifreÖner_Click(object sender, EventArgs e)
            {
                string onerilenSifre = SifreOlustur(8); // Önerilen şifre uzunluğunu belirleyebilirsiniz.
                txtSifre.Text = onerilenSifre;
            }
        private bool sifreGosteriliyor = false;
        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            
        }
    }
}
