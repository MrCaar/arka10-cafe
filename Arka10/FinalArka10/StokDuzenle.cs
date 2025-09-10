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
    public partial class StokDuzenle : Form
    {


        private string urunId, urunAd;
        private PictureBox picture;

        private FormAnaMenu mainMenuForm;
        public StokDuzenle(FormAnaMenu mainMenuForm, string urunId, string urunAd, PictureBox picture)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
            this.urunAd = urunAd;
            this.picture = picture;
            this.urunId = urunId;
            

        }

        private void StokDuzenle_Load(object sender, EventArgs e)
        {
            urunAdText.Text += urunAd;

            DataRow product = MySQL.DatabaseHelper.GetProduct(urunId);

            stokBox.Text = product["stok"].ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği indirimi al
            //SecilenIndirim = IndirimText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void increase_Click(object sender, EventArgs e)
        {

            int stok = Convert.ToInt32(this.stokBox.Text);
            stok++;

            this.stokBox.Text = stok.ToString();
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            int stok = Convert.ToInt32(this.stokBox.Text);
            stok--;

            this.stokBox.Text = stok.ToString();
        }

        private void confirm_Click(object sender, EventArgs e)
        {

            int stok = Convert.ToInt32(this.stokBox.Text);

            string updateQuery = "UPDATE urunler SET stok = @parametre1 WHERE urunid = @parametre2";
            bool result = MySQL.DatabaseHelper.MySQL_Write(updateQuery, stok, this.urunId);

            if (result)
            {
                MessageBox.Show("Stok başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainMenuForm.OpenChieldForm(new Formlar.Stok(mainMenuForm), sender, true);

            }
            else
            {
                MessageBox.Show("Stok güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void stokBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Basılan tuşun rakam mı olduğunu kontrol et
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Eğer rakam değilse ve Backspace değilse, işlemi iptal et
                MessageBox.Show("Sadece rakam girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void stokBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
