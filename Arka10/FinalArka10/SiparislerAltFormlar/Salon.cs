using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using FinalArka10.Formlar;
using FinalArka10.MySQL;

namespace FinalArka10.SiparislerAltFormlar
{
    public partial class Salon : Form
    {
        private readonly FormAnaMenu mainMenuForm;

        public Salon(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
        }

        private void salonBtn_Click(object sender, EventArgs e)
        {
            // Şu anda Salon formundasınız, işlem yapmayabilir veya log yazabilirsiniz.
        }

        private void bahceBtn_Click(object sender, EventArgs e)
        {
            // FormAnaMenu üzerinden Bahçe formunu açabilirsiniz.
            mainMenuForm.OpenChieldForm(new SiparislerAltFormlar.Bahce(mainMenuForm), sender);
        }

        private void terasBtn_Click(object sender, EventArgs e)
        {
            // FormAnaMenu üzerinden Teras formunu açabilirsiniz.
            mainMenuForm.OpenChieldForm(new SiparislerAltFormlar.Teras(mainMenuForm), sender);
        }

        private void Salon_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.WrapContents = true; // Butonlar taşarsa yeni satıra geçsin
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Sol'dan sağa doğru sıralama
            flowLayoutPanel1.AutoScroll = true; // Gerektiğinde kaydırma çubuğu gözüksün

            // Masaları veritabanından al
            DataTable masalarTable = DatabaseHelper.GetTables("salon"); // GetTables fonksiyonundan masaları al

            // DataTable'dan masaid bilgilerini al
            foreach (DataRow row in masalarTable.Rows)
            {
                string masaId = row["masaid"].ToString(); // masaid'yi al
                string masaDurum = row["masadurum"].ToString();

                // Rezervasyon bilgilerini al
                long rezerveTime = row["rezerve_time"] != DBNull.Value ? Convert.ToInt64(row["rezerve_time"]) : 0;
                long rezerveEndTime = row["rezerve_end_time"] != DBNull.Value ? Convert.ToInt64(row["rezerve_end_time"]) : 0;
                DateTime currentTime = DateTime.Now;
                long currentUnixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();

                // Butonun arkaplan resmini belirle
                string backgroundImagePath = "images/bosmasa.png"; // Varsayılan olarak boş masa

                if (masaDurum.Equals("pasif"))
                {
                    backgroundImagePath = "images/pasifmasa.png";
                }
                else if (masaDurum == "dolu" || row["masaozet"].ToString().Length > 2)
                {
                    backgroundImagePath = "images/dolumasa.png";
                }
                else if (masaDurum == "bos" && rezerveTime > 0 && rezerveEndTime > 0)
                {
                    if (currentUnixTime >= rezerveTime && currentUnixTime <= rezerveEndTime)
                    {
                        backgroundImagePath = "images/rezervemasa.png";
                    }
                }

                Button btn = new Button
                {
                    Text = masaId,          // Butonun Text özelliği masaid ile aynı olacak
                    Name = masaId,          // Name özelliği de masaid ile aynı olacak
                    Width = 100,            // Buton genişliği
                    Height = 100,           // Buton yüksekliği
                    BackgroundImage = Image.FromFile(backgroundImagePath), // Resim dosyasının yolu
                    BackgroundImageLayout = ImageLayout.Stretch, // Resmin butona nasıl sığdırılacağını belirler
                    ForeColor = Color.White,
                    Font = new Font("Montserrat", 12, FontStyle.Bold) // Yazı tipi: Montserrat, Boyut: 12, Kalın
                };

                btn.Click += (s, args) =>
                {
                    // Hangi butona tıklandığını burada yakalayabilirsiniz
                    Button clickedButton = (Button)s; // tıklanan butonu al
                    string clickedMasaId = clickedButton.Name; // tıklanan butonun Name'i yani masaid

                    PublicKodlar.selectedTable = clickedMasaId;
                    mainMenuForm.OpenChieldForm(new IkinciForm(), sender, true);
                };

                // Butonu FlowLayoutPanel'e ekle
                flowLayoutPanel1.Controls.Add(btn);

                // 5 buton eklediysek, yeni satıra geç
                if (flowLayoutPanel1.Controls.Count % 6 == 0)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true); // Yeni satıra geçmek için
                }
            }
        }


    }
}
