using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.Formlar
{
    public partial class IkinciForm : Form
    {
        private Dictionary<string, int> selectedProducts = new Dictionary<string, int>();
        public static decimal toplamTutar = 0;


        public IkinciForm()
        {
            InitializeComponent();
        }

        private DataTable loadedData;

        public static void ApplyDiscount(TextBox discountTextBox)
        {
            if (decimal.TryParse(discountTextBox.Text, out decimal discountPercentage) && discountPercentage > 0 && discountPercentage <= 100)
            {
                string masaId = PublicKodlar.selectedTable;
                DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

                if (result.Rows.Count > 0)
                {
                    string masaozetJson = result.Rows[0]["masaozet"].ToString();
                    using var document = System.Text.Json.JsonDocument.Parse(masaozetJson);
                    var masaozet = document.RootElement;

                    if (!string.IsNullOrEmpty(masaozetJson))
                    {
                        if (masaozet.TryGetProperty("toplamTutar", out var toplamTutarProperty))
                        {
                            toplamTutar = toplamTutarProperty.GetDecimal();
                        }
                    }

                    decimal discountAmount = toplamTutar * (discountPercentage / 100);

                    toplamTutar -= discountAmount;

                    masaozet.TryGetProperty("siparisler", out var random123);

                    var updatedSummary = new

                    {
                        siparisler = random123,
                        toplamTutar = toplamTutar
                    };


                    
                    IkinciForm.toplamTutarLabel.Text = $"{toplamTutar}₺";

                    string updatedJson = System.Text.Json.JsonSerializer.Serialize(updatedSummary);

                    MySQL.DatabaseHelper.MySQL_Write(
                        "UPDATE masalar SET masaozet = @parametre1 WHERE masaid = @parametre2",
                        updatedJson,
                        masaId
                    );

                    MessageBox.Show($"%{discountPercentage} indirim uygulandı. Yeni toplam tutar: {toplamTutar} ₺", "İndirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Masa bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir indirim oranı girin (1-100 arası).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //d
        private static bool toplamTutarInitialized = false;
     

        public static void OdeKismi(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out decimal deductionAmount) && deductionAmount > 0)
            {
                // Sadece ilk kez toplamTutar'ı başlat
                if (!toplamTutarInitialized)
                {
                    DataTable masaozet = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", PublicKodlar.selectedTable);
                    if (masaozet.Rows.Count > 0)
                    {
                        string masaozetstring = masaozet.Rows[0]["masaozet"].ToString();

                        try
                        {
                            using var document = System.Text.Json.JsonDocument.Parse(masaozetstring);
                            var rootElement = document.RootElement;
                            if (rootElement.TryGetProperty("toplamTutar", out var toplamTutarProperty))
                            {
                                toplamTutar = toplamTutarProperty.GetDecimal();
                                toplamTutarInitialized = true; // Sadece başarılı bir şekilde alındıysa ayarla
                            }
                            else
                            {
                                MessageBox.Show("Toplam tutar bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        catch (System.Text.Json.JsonException ex)
                        {
                            MessageBox.Show($"JSON parsing hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Masaozet bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (deductionAmount > toplamTutar)
                {
                    MessageBox.Show("Düşeceğiniz tutar toplamdan düşük olmaz x:" + deductionAmount + " y: " + toplamTutar, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                toplamTutar -= deductionAmount;

                // Toplam tutar 0'ın altına düşmesin
                if (toplamTutar < 0)
                {
                    toplamTutar = 0;
                }

                if (toplamTutarLabel != null)
                {
                    toplamTutarLabel.Text = $"{toplamTutar} ₺";
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IkinciForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Masa İsmi: " + PublicKodlar.selectedTable;

            tutar_guncelle();

            // Form yüklenirken listbox'ı ve label'ı güncelle
            UpdateListBoxFromDatabase();
            // (UpdateListBoxFromDatabase içinde zaten toplamTutarLabel güncellenebilir, 
            //  eğer güncellenmiyorsa kendiniz burada da atayabilirsiniz)
            toplamTutarLabel.Text = $"{IkinciForm.toplamTutar} ₺";

            string masaId = PublicKodlar.selectedTable;
            // Masa durumu vs. gibi diğer kontroller
            DataTable result2 = MySQL.DatabaseHelper.MySQL_Read("SELECT masadurum FROM masalar WHERE masaid = @parametre1", masaId);

            if (result2.Rows.Count > 0)
            {
                string currentDurum = result2.Rows[0]["masadurum"].ToString();

                if (currentDurum == "pasif")
                {
                    button5.Text = "  Aktif et";
                }
                else
                {
                    button5.Text = "  Pasife Düşür";
                }
            }
        }


        private void tutar_guncelle()
        {
            // --- ÖNEMLİ KISIM: Form yüklenirken toplam tutarı tekrar okuyun ---
            string masaId = PublicKodlar.selectedTable;
            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

            if (result.Rows.Count > 0)
            {
                string masaozetJson = result.Rows[0]["masaozet"].ToString();
                if (!string.IsNullOrEmpty(masaozetJson))
                {
                    using var document = System.Text.Json.JsonDocument.Parse(masaozetJson);
                    var masaozet = document.RootElement;
                    if (masaozet.TryGetProperty("toplamTutar", out var toplamTutarProperty))
                    {
                        // Statik değişkeni güncelle
                        IkinciForm.toplamTutar = toplamTutarProperty.GetDecimal();
                    }
                    else
                    {
                        // toplamTutar property yoksa 0 olarak varsayalım
                        IkinciForm.toplamTutar = 0;
                    }
                }
                else
                {
                    // masaozetJson boş ise 0 alalım
                    IkinciForm.toplamTutar = 0;
                }
            }
            else
            {
                // hiç kayıt yoksa 0
                IkinciForm.toplamTutar = 0;
            }
        }


        private void LoadProducts(DataTable products)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in products.Rows)
            {
                Panel productPanel = new Panel
                {
                    Size = new Size(120, 160),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                string imagePath = Path.Combine(Application.StartupPath + "images" + row["urunimage"].ToString());
                imagePath = imagePath.Replace("\\", "/");

                PictureBox productImage = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                productImage.Click += (s, args) =>
                {
                    string urunAdi = row["urunid"].ToString();
                    decimal urunFiyat = Convert.ToDecimal(row["fiyat"]);

                    int stok = Convert.ToInt32(row["stok"]);
                    if (stok <= 0)
                    {
                        MessageBox.Show("Seçilen ürün stokta yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    string masaId = PublicKodlar.selectedTable;
                    DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masadurum FROM masalar WHERE masaid = @parametre1", masaId);
                    string currentDurum = result.Rows[0]["masadurum"].ToString();

                    if (currentDurum.Equals("pasif"))
                    {
                        MessageBox.Show("Masa pasif ürün eklenemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!stokKontrol(urunAdi))
                    {
                        MessageBox.Show("Ürün stokta yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    stokAzalt(urunAdi);



                    // Ürün ekle veya miktarını artır ve veritabanını güncelle
                    UpdateTableSummaryWithProduct(urunAdi, urunFiyat);
                    UpdateListBoxFromDatabase(); // ListBox'ı güncelle
                    MessageBox.Show($"{row["urunAdi"].ToString()} başarıyla masaya eklendi");
                    tutar_guncelle();
                };

                if (File.Exists(imagePath))
                {
                    try
                    {
                        productImage.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenemedi: " + ex.Message);
                    }
                }

                Label productName = new Label
                {
                    Text = row["urunadi"].ToString(),
                    Location = new Point(10, 115),
                    AutoSize = false,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Montserrat", 9, FontStyle.Bold)
                };

                Label productPrice = new Label
                {
                    Text = $"{row["fiyat"]} ₺",
                    Location = new Point(10, 135),
                    AutoSize = false,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Montserrat", 8, FontStyle.Regular)
                };

                productPanel.Controls.Add(productImage);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(productPrice);

                flowLayoutPanel1.Controls.Add(productPanel);
            }

            flowLayoutPanel1.Invalidate();
            flowLayoutPanel1.Refresh();
        }

        private void stokArt(string urunId)
        {
            DataRow row = MySQL.DatabaseHelper.GetProduct(urunId);
            int stok = Convert.ToInt32(row["stok"]);
            stok++;

            MySQL.DatabaseHelper.MySQL_Write("UPDATE urunler SET stok = @parametre1 WHERE urunid = @parametre2", stok, urunId);
        }
        private void stokAzalt(string urunId)
        {
            DataRow row = MySQL.DatabaseHelper.GetProduct(urunId);
            int stok = Convert.ToInt32(row["stok"]);
            stok--;

            MySQL.DatabaseHelper.MySQL_Write("UPDATE urunler SET stok = @parametre1 WHERE urunid = @parametre2", stok, urunId);
        }
        private bool stokKontrol(string urunId)
        {
            DataRow row = MySQL.DatabaseHelper.GetProduct(urunId);
            return Convert.ToInt32(row["stok"]) > 0;
        }


        private void UpdateTableSummaryWithProduct(string urunId, decimal urunFiyat)
        {
            // Veritabanından mevcut masaozet'i al
            string masaId = PublicKodlar.selectedTable;
            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

            Dictionary<string, int> siparisler = new Dictionary<string, int>();
            decimal toplamTutar = 0;

            if (result.Rows.Count > 0)
            {
                string masaozetJson = result.Rows[0]["masaozet"].ToString();

                if (!string.IsNullOrEmpty(masaozetJson))
                {
                    using var document = System.Text.Json.JsonDocument.Parse(masaozetJson);
                    var masaozet = document.RootElement;

                    if (masaozet.TryGetProperty("siparisler", out var siparislerProperty))
                    {
                        siparisler = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, int>>(siparislerProperty.GetRawText());
                    }

                    if (masaozet.TryGetProperty("toplamTutar", out var toplamTutarProperty))
                    {
                        toplamTutar = toplamTutarProperty.GetDecimal();
                    }
                }
            }

            // Ürün ekle veya güncelle
            if (siparisler.ContainsKey(urunId))
            {
                siparisler[urunId]++;
            }
            else
            {
                siparisler.Add(urunId, 1);
            }

            // Toplam tutarı güncelle
            toplamTutar += urunFiyat;

            // Yeni masaozet JSON'u oluştur
            var updatedSummary = new
            {
                siparisler = siparisler,
                toplamTutar = toplamTutar
            };

            string updatedJson = System.Text.Json.JsonSerializer.Serialize(updatedSummary);

            // Veritabanına yaz
            MySQL.DatabaseHelper.MySQL_Write(
                "UPDATE masalar SET masaozet = @parametre1 WHERE masaid = @parametre2",
                updatedJson,
                masaId
            );
        }

        private void UpdateListBoxFromDatabase()
        {
            listBox1.Items.Clear();

            // Veritabanından masaozet'i al
            string masaId = PublicKodlar.selectedTable;
            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

            if (result.Rows.Count > 0)
            {
                string masaozetJson = result.Rows[0]["masaozet"].ToString();

                if (!string.IsNullOrEmpty(masaozetJson))
                {
                    using var document = System.Text.Json.JsonDocument.Parse(masaozetJson);
                    var masaozet = document.RootElement;

                    if (masaozet.TryGetProperty("siparisler", out var siparislerProperty))
                    {
                        var siparisler = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, int>>(siparislerProperty.GetRawText());

                        foreach (var product in siparisler)
                        {
                            DataRow productRow = MySQL.DatabaseHelper.GetProduct(product.Key);
                            decimal price = Convert.ToDecimal(productRow["fiyat"]);
                            string itemText = $"{product.Key} {product.Value}x | {product.Value * price} ₺";
                            listBox1.Items.Add(itemText);
                        }
                    }
                }
            }

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal toplamTutar = 0;

            foreach (var item in listBox1.Items)
            {
                string itemText = item.ToString();
                string[] parts = itemText.Split('|');
                string pricePart = parts[1].Trim().Replace("₺", "");

                if (decimal.TryParse(pricePart, out decimal price))
                {
                    toplamTutar += price;
                }
            }

            toplamTutarLabel.Text = $"{toplamTutar}₺";
        }

        private void IncreaseSelectedItem()
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = listBox1.SelectedItem.ToString();
            string[] parts = selectedItem.Split(' ');
            string urunId = parts[0];

            DataRow productRow = MySQL.DatabaseHelper.GetProduct(urunId);
            decimal price = Convert.ToDecimal(productRow["fiyat"]);


            if (!stokKontrol(urunId))
            {
                MessageBox.Show("Ürün stokta yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stokAzalt(urunId);



            UpdateTableSummaryWithProduct(urunId, price);
            UpdateListBoxFromDatabase();
        }

        private void DecreaseSelectedItem()
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string selectedItem = listBox1.SelectedItem.ToString();
            string[] parts = selectedItem.Split(' ');
            string urunId = parts[0];

            stokArt(urunId);

            string masaId = PublicKodlar.selectedTable;
            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

            if (result.Rows.Count > 0)
            {
                string masaozetJson = result.Rows[0]["masaozet"].ToString();

                if (!string.IsNullOrEmpty(masaozetJson))
                {
                    using var document = System.Text.Json.JsonDocument.Parse(masaozetJson);
                    var masaozet = document.RootElement;

                    if (masaozet.TryGetProperty("siparisler", out var siparislerProperty))
                    {
                        var siparisler = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, int>>(siparislerProperty.GetRawText());

                        if (siparisler.ContainsKey(urunId))
                        {
                            siparisler[urunId]--;

                            if (siparisler[urunId] <= 0)
                            {
                                siparisler.Remove(urunId);
                            }

                            decimal urunFiyat = Convert.ToDecimal(MySQL.DatabaseHelper.GetProduct(urunId)["fiyat"]);
                            decimal toplamTutar = masaozet.GetProperty("toplamTutar").GetDecimal() - urunFiyat;

                            var updatedSummary = new
                            {
                                siparisler = siparisler,
                                toplamTutar = toplamTutar
                            };

                            string updatedJson = System.Text.Json.JsonSerializer.Serialize(updatedSummary);

                            MySQL.DatabaseHelper.MySQL_Write(
                                "UPDATE masalar SET masaozet = @parametre1 WHERE masaid = @parametre2",
                                updatedJson,
                                masaId
                            );

                            UpdateListBoxFromDatabase();
                        }
                    }
                }
            }
        }








        private void a(object sender, TabControlEventArgs e)
        {
            DataTable products = MySQL.DatabaseHelper.GetProducts("");
            loadedData = products;

            LoadProducts(loadedData);
        }


        private void asd(object sender, EventArgs e)
        {
        }

        private void tab3(object sender, EventArgs e)
        {

        }




        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indirimBtn_Click(object sender, EventArgs e)
        {
            // Indirim formunun bir örneğini oluştur
            Indirim indirimForm = new Indirim();

            // Popup görünümü için bazı özellikleri ayarla (isteğe bağlı)
            indirimForm.StartPosition = FormStartPosition.CenterParent; // Ortada açılır
            indirimForm.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyutlu dialog görünümü
            indirimForm.MinimizeBox = false; // Minimize butonunu kaldırır
            indirimForm.MaximizeBox = false; // Maximize butonunu kaldırır

            // Formu model olarak aç
            indirimForm.ShowDialog();
        }

        private void kuverBtn_Click(object sender, EventArgs e)
        {
        }

        private void rezerveBtn_Click(object sender, EventArgs e)
        {
            // Rezerve formunun bir örneğini oluştur
            Rezerve rezerveForm = new Rezerve();

            // Popup görünümü için bazı özellikleri ayarla (isteğe bağlı)
            rezerveForm.StartPosition = FormStartPosition.CenterParent; // Ortada açılır
            rezerveForm.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyutlu dialog görünümü
            rezerveForm.MinimizeBox = false; // Minimize butonunu kaldırır
            rezerveForm.MaximizeBox = false; // Maximize butonunu kaldırır

            // Formu model olarak aç
            rezerveForm.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncreaseSelectedItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DecreaseSelectedItem();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            string masaId = PublicKodlar.selectedTable;


            DataTable durumKontrol = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);
            if (durumKontrol.Rows.Count > 0)
            {
                if (durumKontrol.Rows[0]["masaozet"].ToString().Length > 2)
                {
                    MessageBox.Show($"Masa {masaId} boş değil. Düzenlemek için boşalt", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masadurum FROM masalar WHERE masaid = @parametre1", masaId);

            if (result.Rows.Count > 0)
            {
                string currentDurum = result.Rows[0]["masadurum"].ToString();

                if (currentDurum == "pasif")
                {
                    // Masayı aç
                    MySQL.DatabaseHelper.MySQL_Write(
                        "UPDATE masalar SET masadurum = @parametre1 WHERE masaid = @parametre2",
                        "bos",
                        masaId
                    );
                    MessageBox.Show($"Masa {masaId} açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Button)sender).Text = "  Pasife Düşür";
                }
                else
                {
                    // Masayı pasifleştir
                    MySQL.DatabaseHelper.MySQL_Write(
                        "UPDATE masalar SET masadurum = @parametre1 WHERE masaid = @parametre2",
                        "pasif",
                        masaId
                    );
                    MessageBox.Show($"Masa {masaId} pasifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Button)sender).Text = "  Aktif Et";
                }
            }
            else
            {
                MessageBox.Show("Masa bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string masaId = PublicKodlar.selectedTable;

            DataTable result = MySQL.DatabaseHelper.MySQL_Read("SELECT masaozet FROM masalar WHERE masaid = @parametre1", masaId);

            if (result.Rows.Count > 0)
            {
                string masaozetJson = result.Rows[0]["masaozet"].ToString();

                if (masaozetJson.Length <= 2)
                {
                    MessageBox.Show($"Masa {masaId} boş iken sipariş kapatılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Rastgele bir siparis_id oluştur
                string siparisId = Guid.NewGuid().ToString();

                // Geçerli zaman damgasını al
                string currentTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // masaozet'i içerik tablosuna kaydet
                MySQL.DatabaseHelper.MySQL_Write(
                    "INSERT INTO siparisler_log (siparis_id, icerik, kapanis_tarihi) VALUES (@parametre1, @parametre2, @parametre3)",
                    siparisId,
                    masaozetJson,
                    currentTimestamp
                );

                // Masayı kapat ve durumunu güncelle
                MySQL.DatabaseHelper.MySQL_Write(
                    "UPDATE masalar SET masadurum = @parametre1, masaozet = @parametre2 WHERE masaid = @parametre3",
                    "bos",
                    "{}",
                    masaId
                );

                MessageBox.Show($"Masa {masaId} kapatıldı ve sipariş ID: {siparisId} olarak kaydedildi. Kapanış Tarihi: {DateTime.Now}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormAnaMenu.staticFormAna.openSiparisler(null);
            }
            else
            {
                MessageBox.Show("Masa bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Rezerve formunun bir örneğini oluştur
            Nakit nakitForm = new Nakit();

            // Popup görünümü için bazı özellikleri ayarla (isteğe bağlı)
            nakitForm.StartPosition = FormStartPosition.CenterParent; // Ortada açılır
            nakitForm.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyutlu dialog görünümü
            nakitForm.MinimizeBox = false; // Minimize butonunu kaldırır
            nakitForm.MaximizeBox = false; // Maximize butonunu kaldırır

            // Formu model olarak aç
            nakitForm.ShowDialog();
        }


    }
}