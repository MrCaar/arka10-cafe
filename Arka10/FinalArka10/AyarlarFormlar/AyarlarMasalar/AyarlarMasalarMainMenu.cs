using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.AyarlarFormlar.AyarlarMasalar
{

    public partial class AyarlarMasalarMainMenu : Form
    {
        private FormAnaMenu mainMenuForm;
        public AyarlarMasalarMainMenu(FormAnaMenu mainMenu)
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
    }
}
