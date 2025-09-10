using System;
using System.Windows.Forms;

namespace FinalArka10.Formlar
{
    public partial class Ayarlar : Form
    {
        private FormAnaMenu mainMenuForm; // Ana menü referansı

        public Ayarlar(FormAnaMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu; // Ana menüden gelen referansı al
        }

        private void siparislerBtn_Click(object sender, EventArgs e)
        {
            // OpenChieldForm metodunu kullanarak AyarlarMasalarMainMenu'yu aç
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarMasalar.AyarlarMasalarMainMenu(mainMenuForm), sender);
        }

        private void urunlerBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarUrunler.AyarlarUrunler(mainMenuForm), sender);
        }


        private void personellerBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new AyarlarFormlar.AyarlarPersoneller.AyarlarPersonelEkle(mainMenuForm), sender);
        }
    }
}
