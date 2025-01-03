using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipl_pasw_keys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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


        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("kullanıcı giriş panelinden çıkılsın mı", "Dipl_pasw_keys", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // SQL sorgusu: Kullanıcı adı ve şifreyi kontrol ediyoruz
            string sql = "SELECT kul_ad FROM kullanicilar WHERE kul_kod=@kul_kod AND kul_pw=@kul_pw";

            try
            {
                conn.Open();

                // Şifreyi şifreleme
                string sifrelenmisSifre = sha256KoduOlustur(txt_şifre.Text);

                // Komut nesnesini hazırlıyoruz
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kul_kod", txt_kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@kul_pw", sifrelenmisSifre); // Şifrelenmiş şifreyi kontrol et

                // Sorgu sonucunu DataReader ile alıyoruz
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Kullanıcı bilgileri doğru
                    reader.Read(); // Veriyi okuyarak aktif kullanıcı adını alıyoruz
                    CLS.Myglobals.Aktif_kullanici_adi = reader["kul_ad"].ToString();
                    CLS.Myglobals.Aktif_kullanici_kodu = txt_kullanici_adi.Text;

                    reader.Close(); // DataReader'ı kapatıyoruz

                    // Yeni forma geçiş
                    this.Hide();
                    new Anaform().ShowDialog();
                }
                else
                {
                    // Hatalı giriş
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriliyor
                MessageBox.Show("VT bağlantısında hata oluştu, hata kodu: H002\n" + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        MySqlConnection conn = new MySqlConnection("server=localhost; Database=dipl_pasw_keys; Uid=root; Pwd='Dabuluardabulu1ck'");

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
           
            KayitOl kayitFormu = new KayitOl(); 
            kayitFormu.ShowDialog();

        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
