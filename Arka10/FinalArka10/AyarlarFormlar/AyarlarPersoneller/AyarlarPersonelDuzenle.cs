using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.AyarlarFormlar.AyarlarPersoneller
{
    public partial class AyarlarPersonelDuzenle : Form
    {
        private FormAnaMenu mainMenuForm;
        public AyarlarPersonelDuzenle(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
        }

        private void ayarlarPersonellerGeriBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarPersoneller.AyarlarPersonelEkle(mainMenuForm), sender);
        }

        private void getirButton_Click(object sender, EventArgs e)
        {

            string id = idBox.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("Ürün id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DataTable personelBilgisi = FinalArka10.MySQL.DatabaseHelper.MySQL_Read(
        "SELECT * FROM personeller WHERE id = @parametre1", id);

            // Personel var mı kontrol et
            if (personelBilgisi.Rows.Count > 0)
            {
                //Personel bilgilerini getir

                adBox.Text = personelBilgisi.Rows[0]["ad"].ToString();
                soyadBox.Text = personelBilgisi.Rows[0]["soyad"].ToString();
                dogumBox.Text = personelBilgisi.Rows[0]["dTarihi"].ToString();
                adresBox.Text = personelBilgisi.Rows[0]["adres"].ToString();
                telefonBox.Text = personelBilgisi.Rows[0]["telefon"].ToString();
                pozisyonBox.Text = personelBilgisi.Rows[0]["pozisyon"].ToString();

                MessageBox.Show("Personel bilgileri getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Ürün bulunamadı
                MessageBox.Show("Personel bulunamadı! Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }


        private void silButton_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();

            if (id.Length == 0)
            {
                MessageBox.Show("Personel id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DataTable urunBilgisi = FinalArka10.MySQL.DatabaseHelper.MySQL_Read(
        "SELECT * FROM personeller WHERE id = @parametre1",
        id);


            //Personel var mı kontrol et
            if (urunBilgisi.Rows.Count > 0)
            {
                // Ürünü db den sil
                bool isDeleted = FinalArka10.MySQL.DatabaseHelper.MySQL_Write(
                  "DELETE FROM personeller WHERE id = @parametre1",
                  id
              );

                MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ürün bulunamadı
                MessageBox.Show("Personel bulunamadı! Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();

            if (id.Length == 0)
            {
                MessageBox.Show("Ürün id girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Personel var mı kontrol et
            DataTable urunKontrol = FinalArka10.MySQL.DatabaseHelper.MySQL_Read("SELECT COUNT(*) FROM personeller WHERE id = @parametre1", id);

            if (urunKontrol.Rows.Count > 0 && Convert.ToInt32(urunKontrol.Rows[0][0]) > 0)
            {

                string ad = adBox.Text.Trim();
                string soyad = soyadBox.Text.Trim();
                string dogum = dogumBox.Text.Trim();
                string adres = adresBox.Text.Trim();
                string telefon = telefonBox.Text.Trim();
                string pozisyon = pozisyonBox.Text.Trim();

                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(dogum) ||
                    string.IsNullOrEmpty(adres) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(pozisyon))
                {
                    MessageBox.Show("Lütfen tüm alanları düzgünce doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                try
                {
                    FinalArka10.MySQL.DatabaseHelper.MySQL_Write(
            "UPDATE personeller SET ad = @parametre1, soyad = @parametre2, dtarihi = @parametre3, adres = @parametre4, telefon = @parametre5, pozisyon = @parametre6 WHERE id = @parametre6",
                ad, soyad, dogum, adres, telefon, id, pozisyon
                );
                }
                catch (Exception ignored)
                {
                    MessageBox.Show("Personel güncellenemedi! Lütfen girdiklerini kontrol et.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Personel bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Personel bulunamad
                MessageBox.Show("Personel bulunamadı! Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AyarlarPersonelDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
