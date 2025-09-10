using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalArka10.MySQL;

namespace FinalArka10.AyarlarFormlar.AyarlarPersoneller
{
    public partial class AyarlarPersonelEkle : Form
    {
        private FormAnaMenu mainMenuForm;
        public AyarlarPersonelEkle(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
        }

        private void ayarlarPersonellerGeriBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new Formlar.Ayarlar(mainMenuForm), sender);
        }

        private void ayarlarPersonellerDuzenleBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarPersoneller.AyarlarPersonelDuzenle(mainMenuForm), sender);
        }

        private void ayarlarPersonellerEkleBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarPersoneller.AyarlarPersonelEkle(mainMenuForm), sender);
        }

        private void personelEkleBtn_Click(object sender, EventArgs e)
        {
            string ad = adBox.Text;
            string soyad = soyadBox.Text;
            string dogum = dogumBox.Text;
            string adres = adresBox.Text;
            string telefon = telefonBox.Text;
            string pozisyon = pozisyonBox.Text;


            if (ad.Length == 0 || soyad.Length == 0 || dogum.Length == 0 || adres.Length == 0 || telefon.Length == 0 || pozisyon.Length == 0)
            {
                MessageBox.Show("Tüm bilgileri eksiksiz girmelisin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO personeller (ad, soyad, dtarihi, adres, telefon, notlar, poziyon) VALUES " +
                "(@parametre1, @parametre2, @parametre3, @parametre4, @parametre5, @parametre6, @parametre7)";

            bool success = DatabaseHelper.MySQL_Write(query, ad, soyad, dogum, adres, telefon, "", pozisyon);

            if (success)
            {
                MessageBox.Show("Personel başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
