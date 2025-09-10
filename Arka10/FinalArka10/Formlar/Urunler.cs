using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.Formlar
{

    public partial class Urunler : Form
    {

        private FormAnaMenu mainAnaMenu;
        public Urunler(FormAnaMenu mainAnaMenu)
        {
            this.mainAnaMenu = mainAnaMenu;
            InitializeComponent();
        }
        private DataTable loadedData;

        private void Urunler_Load(object sender, EventArgs e)
        {
            DataTable products = MySQL.DatabaseHelper.GetProducts(""); // Veritabanından ürünleri al
            loadedData = products;

            // Ürünleri yükle
            LoadProducts(loadedData);
        }

        private void LoadProducts(DataTable products)
        {
            // Önceki ürünleri temizle
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in products.Rows)
            {
                Panel productPanel = new Panel
                {
                    Size = new Size(120, 160), // Panel boyutu
                    Margin = new Padding(10), // Kenar boşlukları
                    BorderStyle = BorderStyle.FixedSingle
                };

                string imagePath = Path.Combine(Application.StartupPath + "images" + row["urunimage"].ToString());
                imagePath = imagePath.Replace("\\", "/"); // Yolu düz eğik çizgiye çevir

                // Ürün resmi
                PictureBox productImage = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                // Resmi yüklemeden önce dosyanın varlığını kontrol et
                if (File.Exists(imagePath))
                {
                    try
                    {
                        productImage.Image = Image.FromFile(imagePath); // Resmi yükle

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenemedi: " + ex.Message);
                        // Alternatif bir resim gösterilebilir
                    }
                }
                else
                {
                    // Resim yoksa alternatif bir resim göster
                }

                // Ürün adı
                Label productName = new Label
                {
                    Text = row["urunadi"].ToString(),
                    Location = new Point(10, 115),
                    AutoSize = false,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Montserrat", 9, FontStyle.Bold)
                };

                // Ürün fiyatı
                Label productPrice = new Label
                {
                    Text = $"{row["fiyat"]} ₺",
                    Location = new Point(10, 135),
                    AutoSize = false,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Montserrat", 8, FontStyle.Regular)
                };

                // Panel içine elemanları ekle
                productPanel.Controls.Add(productImage);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(productPrice);



                // Resme tıklama olayları
                productImage.Click += (sender, e) =>
                {
                    string urunId = row["urunid"].ToString();
                    string urunAd = row["urunadi"].ToString();
                    UrunDuzenle duzenle = new UrunDuzenle(mainAnaMenu, urunId, urunAd, Convert.ToDecimal(row["fiyat"]));

                    duzenle.StartPosition = FormStartPosition.CenterParent; // Ortada açılır
                    duzenle.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyutlu dialog görünümü
                    duzenle.MinimizeBox = false; // Minimize butonunu kaldırır
                    duzenle.MaximizeBox = false; // Maximize butonunu kaldırır

                    // Formu model olarak aç
                    duzenle.ShowDialog();

                };


                // Paneli formdaki bir container'a ekle
                flowLayoutPanel1.Controls.Add(productPanel);
            }

            // Yeniden çizme işlemi
            flowLayoutPanel1.Invalidate();
            flowLayoutPanel1.Refresh();
        }

        private void ProductImage_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Textbox içeriğine göre filtrele
            string searchQuery = textBox1.Text.ToLower(); // Arama sorgusunu küçük harfe çevir
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Arama sorgusuna göre filtrelenmiş DataTable oluştur
                DataTable filteredData = loadedData.Clone(); // Yapıyı kopyala, ancak veri kopyalamaz
                foreach (DataRow row in loadedData.Rows)
                {
                    if (row["urunadi"].ToString().ToLower().Contains(searchQuery))
                    {
                        filteredData.ImportRow(row); // Arama sorgusuna uyan satırı ekle
                    }
                }

                // Filtrelenmiş veriyi yükle
                LoadProducts(filteredData);
            }
            else
            {
                // Arama kutusu boşsa tüm ürünleri yükle
                LoadProducts(loadedData);
            }
        }



        private void iceceklerBtn_Click(object sender, EventArgs e)
        {
            // İçecekler kategorisine göre filtrele
            DataTable icecekler = MySQL.DatabaseHelper.GetProducts("icecekler");
            loadedData = icecekler;
            LoadProducts(icecekler);
        }

        private void yiyeceklerBtn_Click(object sender, EventArgs e)
        {
            // Yiyecekler kategorisine göre filtrele
            DataTable yiyecekler = MySQL.DatabaseHelper.GetProducts("yiyecekler");
            loadedData = yiyecekler;
            LoadProducts(yiyecekler);
        }

        private void tatlilarBtn_Click(object sender, EventArgs e)
        {
            // Tatlılar kategorisine göre filtrele
            DataTable tatlilar = MySQL.DatabaseHelper.GetProducts("tatlilar");
            loadedData = tatlilar;
            LoadProducts(tatlilar);
        }

        // Byte array'den Image'e dönüştürmek için yardımcı metot

    }
}
