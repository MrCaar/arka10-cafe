using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.Formlar
{
    public partial class UrunDuzenle : Form
    {


        private string urunId, urunAd;
        private decimal fiyat;

        private FormAnaMenu mainMenuForm;



        public UrunDuzenle(FormAnaMenu mainMenuForm, string urunId, string urunAd, decimal fiyat)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
            this.urunAd = urunAd;
            this.fiyat = fiyat;
            this.urunId = urunId;

        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {

            urunIdLabel.Text = urunId;
            urunIdLabel.Visible = true;


            adBox.Text = urunAd;
            fiyatBox.Text = fiyat.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {

            bool changed = false;
            if (adBox.Text != urunAd)
            {

                MySQL.DatabaseHelper.MySQL_Write(
                "UPDATE urunler SET urunadi = @parametre1 WHERE urunid = @parametre2",
                adBox.Text, urunId
                );
                changed = true;

            }
            if (fiyatBox.Text != fiyat.ToString())
            {

                try
                {
                    decimal yeniFiyat = Convert.ToDecimal(fiyatBox.Text);
                    MySQL.DatabaseHelper.MySQL_Write(
                        "UPDATE urunler SET fiyat = @parametre1 WHERE urunid = @parametre2",
                        yeniFiyat, urunId
                    );
                    changed = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Geçersiz fiyat birimi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (changed)
            {
                MessageBox.Show("Veriler güncellendi!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                mainMenuForm.OpenChieldForm(new Formlar.Urunler(mainMenuForm), sender, true);

            } else
            {
                MessageBox.Show("Veriler aynı hiçbir şey değişmedi!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
