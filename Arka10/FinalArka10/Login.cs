using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinalArka10
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string tx1 = textBox1.Text;

            if (tx1 == "Password")
            {
                MessageBox.Show("Başarıyla giriş yapıldı!");
                FormAnaMenu anaMenu = new FormAnaMenu(); // FormAnaMenu nesnesi oluştur
                anaMenu.Show(); // Yeni formu göster
                this.Hide(); // Mevcut formu gizle
            }
            else
            {
                MessageBox.Show("Yazdığınız passcode geçersiz.");
            }

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void AddToTextBox(string value)
        {
            // TextBox içeriğine yeni değeri ekle
            textBox1.Text += value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // TextBox içindeki metni al
            string text = textBox1.Text;

            // Eğer TextBox boş değilse bir harfi sil
            if (!string.IsNullOrEmpty(text))
            {
                // Son karakteri kaldır
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToTextBox("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToTextBox("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToTextBox("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToTextBox("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToTextBox("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToTextBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToTextBox("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddToTextBox("0");
        }
    }
}
