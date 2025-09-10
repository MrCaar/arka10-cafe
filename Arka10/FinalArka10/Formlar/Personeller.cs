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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }


        private void Personeller_Load(object sender, EventArgs e)
        {
            DataTable persons = MySQL.DatabaseHelper.GetPersons();

            foreach (DataRow row in persons.Rows)
            {

                Button personButton = new Button();

                // Button tasarımını ayarla
                personButton.Dock = DockStyle.Top;
                personButton.FlatAppearance.BorderSize = 0;
                personButton.FlatStyle = FlatStyle.Flat;
                personButton.Font = new Font("Montserrat", 7.25F, FontStyle.Bold);
                personButton.ForeColor = Color.Gainsboro;
                personButton.Image = Properties.Resources.usersolid; // Kendi resminizi kullanın
                personButton.ImageAlign = ContentAlignment.MiddleLeft;
                personButton.Margin = new Padding(3, 2, 3, 2);
                personButton.Padding = new Padding(10, 0, 0, 0);
                personButton.Size = new Size(192, 45);
                personButton.Text = row["ad"].ToString() + " " + row["soyad"].ToString();
                personButton.TextAlign = ContentAlignment.MiddleLeft;
                personButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                personButton.UseVisualStyleBackColor = true;

                // İsteğe bağlı: Tıklama olayını ekleyin
                personButton.Click += (s, eArgs) =>
                {
                    // MessageBox.Show($"Seçilen kişi: {personButton.Text}");
                    updateInformations(personButton.Text);
                };

                // Butonu formun bir Panel veya başka bir konteynerine ekleyin
                panel1.Controls.Add(personButton); // Eğer bir `Panel` varsa, `panel1.Controls.Add(personButton)` gibi ekleyin.
            }
        }

        private void updateInformations(String selected)
        {
            DataTable persons = MySQL.DatabaseHelper.GetPersons();

            DataRow found = null;
            foreach (DataRow row in persons.Rows)
            {
                String tamAdi = row["ad"].ToString() + " " + row["soyad"].ToString();
                if (selected.Equals(tamAdi))
                {
                    found = row;
                    break;
                }
            }

            if (found == null)
            {
                MessageBox.Show("Seçilen yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.id.Text = found["id"].ToString();
            this.ad.Text = found["ad"].ToString();
            this.soyad.Text = found["soyad"].ToString();
            this.date.Text = found["dtarihi"].ToString();
            this.address.Text = found["adres"].ToString();
            this.telefon.Text = found["telefon"].ToString();
            this.pozisyon.Text = found["pozisyon"].ToString();

            this.id.Visible = true;
            this.ad.Visible = true;
            this.soyad.Visible = true;
            this.date.Visible = true;
            this.address.Visible = true;
            this.telefon.Visible = true;
            this.pozisyon.Visible = true;



        }

    }
}
