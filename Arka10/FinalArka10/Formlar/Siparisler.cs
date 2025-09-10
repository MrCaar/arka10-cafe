using System;
using System.Data;
using System.Windows.Forms;
using FinalArka10.MySQL;

namespace FinalArka10.Formlar
{
    public partial class Siparisler : Form
    {
        private readonly FormAnaMenu mainMenuForm;

        public Siparisler(FormAnaMenu mainMenuForm) //FormAnaMenu mainMenu
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
        }

        public void bahceBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new SiparislerAltFormlar.Bahce(mainMenuForm), sender);
        }

        public void salonBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new SiparislerAltFormlar.Salon(mainMenuForm), sender);
        }

        public void terasBtn_Click(object sender, EventArgs e)
        {
            mainMenuForm.OpenChieldForm(new SiparislerAltFormlar.Teras(mainMenuForm), sender);
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            // FlowLayoutPanel'in özelliklerini ayarla
            
        }


    }
}
