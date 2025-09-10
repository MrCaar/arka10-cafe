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
    public partial class Indirim : Form
    {
        public Indirim()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        


        private void okButton_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği indirimi al
            //SecilenIndirim = IndirimText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            IkinciForm.ApplyDiscount(IndirimText);
        }

        private void IndirimText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
