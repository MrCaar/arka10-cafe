using System;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using FinalArka10.MySQL;

namespace FinalArka10
{
    public partial class FormAnaMenu : Form
    {
        //fields
        private Button currentbutton;
        private Random random;
        private int tempIndex;
        private Form activeform;
        private System.Windows.Forms.Timer oturumSayaci; // Sayaç nesnesi
        private int kalanSure = 60 * 60; // 10 dakika (saniye cinsinden)

        //constructor
        public FormAnaMenu()
        {
            InitializeComponent();
            random = new Random();
            OturumSayaciniBaslat(); // Sayaç başlatılıyor

            FormAnaMenu.staticFormAna = this;
        }
        public static FormAnaMenu staticFormAna;
        

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender, bool isRegionButton)
        {
            if (btnSender != null && btnSender is Button && isRegionButton)
            {
                if (currentbutton != (Button)btnSender)
                {
                    DisableButton(); // Di�er butonlar� s�f�rla
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new Font("Montserrat", 12.5F, FontStyle.Bold); // Aktif butonun fontunu b�y�t
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelLogo2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        public void OpenChieldForm(Form chieldForm, object btnSender, bool affectUI = true)
        {
            if (activeform != null)
            {
                activeform.Close();
            }

            bool isRegionButton = btnSender is Button button && panelMenu.Controls.Contains(button);

            if (affectUI && isRegionButton)
            {
                ActivateButton(btnSender, isRegionButton); // UI'yi sadece ana men�den gelen �a�r�larda etkile
            }

            activeform = chieldForm;
            chieldForm.TopLevel = false;
            chieldForm.FormBorderStyle = FormBorderStyle.None;
            chieldForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(chieldForm);
            this.panelDesktopPanel.Tag = chieldForm;
            chieldForm.BringToFront();
            chieldForm.Show();
            lblTitle.Text = chieldForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Montserrat", 11F, FontStyle.Bold); // Varsay�lan font boyutunu ve stilini geri y�kle
                }
            }
        }




        #region Ana men� butonlar�
        private void siparislerBtn_Click(object sender, EventArgs e)
        {
            openSiparisler(sender);
        }

        public void openSiparisler(object sender)
        {
            OpenChieldForm(new Formlar.Siparisler(this), sender, true);
        }

        private void ikinciformBtn_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new Formlar.IkinciForm(), sender, true);
        }


        private void urunlerBtn_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new Formlar.Urunler(this), sender, true);
        }

        private void stokBtn_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new Formlar.Stok(this), sender, true);
        }

        private void personellerBtn_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new Formlar.Personeller(), sender, true);
        }

        private void ayarlarBtn_Click(object sender, EventArgs e)
        {
            // FormAnaMenu'yu parametre olarak g�nderiyoruz
            OpenChieldForm(new Formlar.Ayarlar(this), sender);
        }

        #endregion



        private void FormAnaMenu_Load(object sender, EventArgs e)
        {

            if (MySQL.DatabaseHelper.IsDatabaseConnected())
            {
                dbcheck.Text = "Online";
                dbcheck.ForeColor = Color.Green;
            }
            else
            {
                dbcheck.Text = "Offline";
                dbcheck.ForeColor = Color.Red;
            }

            //this.FormBorderStyle = FormBorderStyle.None;  // Kenarlıklar ve başlık çubuğunu kaldır
            //this.WindowState = FormWindowState.Maximized; // Formu tam ekran yap
            //this.TopMost = true; // Formun her zaman üstte olmasını sağlar
        }



        private void OturumSayaciniBaslat()
        {
            // Sayaç oluştur ve ayarla
            oturumSayaci = new System.Windows.Forms.Timer();
            oturumSayaci.Interval = 1000; // 1 saniye
            oturumSayaci.Tick += OturumSayaci_Tick;
            oturumSayaci.Start();

            // Label'ı başlangıç süresiyle güncelle
            SayacEkraniniGuncelle();
        }

        private void OturumSayaci_Tick(object sender, EventArgs e)
        {
            kalanSure--;

            if (kalanSure <= 0)
            {
                oturumSayaci.Stop(); // Sayaç durduruluyor
                MessageBox.Show("Oturum süresi doldu. Yeniden giriş yapmanız gerekiyor.", "Oturum Zaman Aşımı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Login formuna dön ve bu formu kapat
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                SayacEkraniniGuncelle();
            }
        }

        private void SayacEkraniniGuncelle()
        {
            // Kalan süreyi dakika:saniye formatında lblSayac üzerinde göster
            int dakika = kalanSure / 60;
            int saniye = kalanSure % 60;
            lblSayac.Text = "Oturum Kalan Süre: " + $"{dakika:D2}:{saniye:D2}";
        }


    }
}
