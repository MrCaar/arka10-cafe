using FinalArka10.MySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.AyarlarFormlar.AyarlarUrunler
{
    public partial class AyarlarUrunler : Form
    {
        private FormAnaMenu mainMenuForm; // Ana menü referansı
        public AyarlarUrunler(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu; // Ana menüden gelen referansı al
        }

        private void ayarlarUrunlerGeriBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new Formlar.Ayarlar(mainMenuForm), sender);
        }

        private void urunfotoEkle_Click(object sender, EventArgs e)
        {
            // Önce ÜrünID alanını kontrol et
            if (string.IsNullOrWhiteSpace(txtUrunID.Text))
            {
                MessageBox.Show("Lütfen önce ÜrünID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string urunID = txtUrunID.Text.Trim(); // ÜrünID'yi al ve temizle

            // OpenFileDialog oluştur
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG Dosyaları (*.png)|*.png";
                openFileDialog.Title = "Bir PNG dosyası seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Seçilen dosyanın yolu
                        string selectedFilePath = openFileDialog.FileName;

                        // Programın çalıştığı dizindeki images klasörünün yolu
                        string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");

                        // Eğer images klasörü yoksa oluştur
                        if (!Directory.Exists(targetDirectory))
                        {
                            Directory.CreateDirectory(targetDirectory);
                        }

                        // ÜrünID ile hedef dosya adı oluştur
                        string targetFileName = $"{urunID}.png";
                        string targetFilePath = Path.Combine(targetDirectory, targetFileName);

                        // Dosyayı kopyala ve yeni isimle kaydet
                        File.Copy(selectedFilePath, targetFilePath, true);

                        // Başarı mesajı göster
                        MessageBox.Show($"Fotoğraf başarıyla yüklendi ve şu isimle kaydedildi: {targetFileName}");
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda kullanıcıya bilgi ver
                        MessageBox.Show($"Fotoğraf yüklenirken bir hata oluştu: {ex.Message}");
                    }
                }
            }
        }

        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            // Girişlerin boş olup olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(txtUrunID.Text) ||
                string.IsNullOrWhiteSpace(txtUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Formdan verileri alıyoruz
                string urunID = txtUrunID.Text.Trim();
                string urunAdi = txtUrunAdi.Text.Trim();
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text.Trim());
                string kategori = cmbKategori.SelectedItem.ToString();
                string urunImage = $@"\{urunID}.png"; // urunimage sütunu için dosya adı

                // SQL INSERT sorgusu
                string query = "INSERT INTO urunler (kategori, urunid, urunadi, fiyat, urunimage, stok) VALUES (@parametre1, @parametre2, @parametre3, @parametre4, @parametre5, @parametre6)";

                // MySQL_Write metodunu kullanarak veriyi ekliyoruz
                bool success = DatabaseHelper.MySQL_Write(query, kategori, urunID, urunAdi, fiyat, urunImage, 20); // stok varsayılan olarak 20

                if (success)
                {
                    MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urunDuzenleButton_Click(object sender, EventArgs e)
        {
            string urunID = txtUrunID.Text.Trim();

            if (urunID.Length == 0)
            {
                MessageBox.Show("Ürün id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ürün var mı kontrol et
            DataTable urunKontrol = FinalArka10.MySQL.DatabaseHelper.MySQL_Read("SELECT COUNT(*) FROM urunler WHERE urunid = @parametre1", urunID);

            if (urunKontrol.Rows.Count > 0 && Convert.ToInt32(urunKontrol.Rows[0][0]) > 0)
            {
                // Ürün bulundu

                string urunAdi = txtUrunAdi.Text.Trim();
                string fiyat = txtFiyat.Text.Trim();
                string kategori = cmbKategori.SelectedItem.ToString();
                string urunImage = $@"\{urunID}.png";

                if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(fiyat) || string.IsNullOrEmpty(kategori))
                {
                    MessageBox.Show("Lütfen tüm alanları düzgünce doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (!decimal.TryParse(fiyat, out decimal fiyatReal))
                {
                    MessageBox.Show("Geçerli bir fiyat girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FinalArka10.MySQL.DatabaseHelper.MySQL_Write(
            "UPDATE urunler SET urunadi = @parametre1, fiyat = @parametre2, kategori = @parametre3, urunImage = @parametre4 WHERE urunid = @parametre5",
            urunAdi, fiyatReal, kategori, urunImage, urunID
                );


                MessageBox.Show("Ürün bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ürün bulunamad
                MessageBox.Show("Ürün bulunamadı! Lütfen geçerli bir Ürün ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void urunGetir_Click(object sender, EventArgs e)
        {
            string urunID = txtUrunID.Text.Trim();

            if (urunID.Length == 0)
            {
                MessageBox.Show("Ürün id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


           
            DataTable urunBilgisi = FinalArka10.MySQL.DatabaseHelper.MySQL_Read(
        "SELECT * FROM urunler WHERE urunid = @parametre1",
        urunID);

            // Ürün var mı kontrol et
            if (urunBilgisi.Rows.Count > 0)
            {
                //Ürün bilgilerini getir
                txtUrunAdi.Text = urunBilgisi.Rows[0]["urunadi"].ToString();
                txtFiyat.Text = urunBilgisi.Rows[0]["fiyat"].ToString();
                cmbKategori.SelectedItem = urunBilgisi.Rows[0]["kategori"].ToString();

                MessageBox.Show("Ürün bilgileri getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Ürün bulunamadı
                MessageBox.Show("Ürün bulunamadı! Lütfen geçerli bir Ürün ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urunDeleteButton_Click(object sender, EventArgs e)
        {
            string urunID = txtUrunID.Text.Trim();

            if (urunID.Length == 0)
            {
                MessageBox.Show("Ürün id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DataTable urunBilgisi = FinalArka10.MySQL.DatabaseHelper.MySQL_Read(
        "SELECT * FROM urunler WHERE urunid = @parametre1",
        urunID);


            //Ürün var mı kontrol et
            if (urunBilgisi.Rows.Count > 0)
            {
                // Ürünü db den sil
                bool isDeleted = FinalArka10.MySQL.DatabaseHelper.MySQL_Write(
                  "DELETE FROM urunler WHERE urunid = @parametre1",
                  urunID
              );

                MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ürün bulunamadı
                MessageBox.Show("Ürün bulunamadı! Lütfen geçerli bir Ürün ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}