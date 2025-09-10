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

namespace FinalArka10.AyarlarFormlar.AyarlarMasalar
{
    public partial class AyarlarBahce : Form
    {
        private readonly FormAnaMenu mainMenuForm;
        public AyarlarBahce(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
        }

        private void ayarlarMasaGeriBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new Formlar.Ayarlar(mainMenuForm), sender);
        }

        private void ayarlarSalonBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarMasalar.AyarlarSalon(mainMenuForm), sender);
        }

        private void ayarlarBahceBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarMasalar.AyarlarBahce(mainMenuForm), sender);
        }

        private void ayarlarTerasBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarMasalar.AyarlarTeras(mainMenuForm), sender);
        }

        private void AyarlarBahce_Load(object sender, EventArgs e)
        {
            // MySQL'den masaları yükle
            DataTable masalar = DatabaseHelper.GetTables("bahce");

            foreach (DataRow row in masalar.Rows)
            {
                // Masaları tablo verilerine göre oluştur
                string masaId = row["masaid"].ToString();
                string masaKategori = row["masakategori"].ToString();

                Button btn = new Button
                {
                    Text = masaId, // Örneğin: "salon 1"
                    Name = masaId, // Örneğin: "masa1"
                    Width = 140,
                    Height = 93
                };

                FlowLayoutPanelAyarlarBahce.Controls.Add(btn);
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            // Yeni masa ekle
            string masaId = DatabaseHelper.InsertTable("bahce", "{}");
            PublicKodlar.MasaEkle("B", PublicKodlar.BahceMasalari);

            // Yeni butonu FlowLayoutPanel'e ekle
            string yeniMasa = PublicKodlar.BahceMasalari[^1]; // Listenin son elemanı yeni masa
            Button btn = new Button
            {
                Text = masaId,
                Name = masaId,
                Width = 140,
                Height = 93
            };
            FlowLayoutPanelAyarlarBahce.Controls.Add(btn);


            // Yeni butonu FlowLayoutPanel'e ekle
            
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (FlowLayoutPanelAyarlarBahce.Controls.Count > 0)
            {
                // Son butonu seç
                var lastButton = FlowLayoutPanelAyarlarBahce.Controls[FlowLayoutPanelAyarlarBahce.Controls.Count - 1] as Button;

                if (lastButton != null)
                {
                    // Button'un Name'inden ID'yi çıkar
                    string masaId = lastButton.Name; // Örneğin "masa5"

                    // Masa ID'sine göre MySQL'den sil
                    bool isDeleted = DatabaseHelper.DeleteTable(masaId.ToString());
                    if (isDeleted)
                    {
                        MessageBox.Show($"Masa ID: {masaId} başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // FlowLayoutPanel'den ve listeden butonu kaldır
                        PublicKodlar.MasaSil(PublicKodlar.BahceMasalari);
                        FlowLayoutPanelAyarlarBahce.Controls.Remove(lastButton);
                    }
                    else
                    {
                        MessageBox.Show($"Masa ID: {masaId} silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("FlowLayoutPanel'de silinecek buton bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
