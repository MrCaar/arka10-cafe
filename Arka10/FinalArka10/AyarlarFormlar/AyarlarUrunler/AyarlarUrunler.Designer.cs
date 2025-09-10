namespace FinalArka10.AyarlarFormlar.AyarlarUrunler
{
    partial class AyarlarUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ayarlarUrunlerBtn = new Button();
            ayarlarUrunlerGeriBtn = new Button();
            panel1 = new Panel();
            urunEkleBtn = new Button();
            label1 = new Label();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtUrunID = new TextBox();
            label4 = new Label();
            txtFiyat = new TextBox();
            label5 = new Label();
            urunfotoEkle = new Button();
            openFileDialog1 = new OpenFileDialog();
            cmbKategori = new ComboBox();
            label6 = new Label();
            urunDuzenleButton = new Button();
            urunDeleteButton = new Button();
            urunGetir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ayarlarUrunlerBtn
            // 
            ayarlarUrunlerBtn.BackColor = Color.Gainsboro;
            ayarlarUrunlerBtn.Dock = DockStyle.Top;
            ayarlarUrunlerBtn.FlatAppearance.BorderSize = 0;
            ayarlarUrunlerBtn.FlatStyle = FlatStyle.Flat;
            ayarlarUrunlerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            ayarlarUrunlerBtn.ForeColor = Color.Black;
            ayarlarUrunlerBtn.Image = Properties.Resources.serach;
            ayarlarUrunlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ayarlarUrunlerBtn.Location = new Point(0, 45);
            ayarlarUrunlerBtn.Margin = new Padding(3, 2, 3, 2);
            ayarlarUrunlerBtn.Name = "ayarlarUrunlerBtn";
            ayarlarUrunlerBtn.Padding = new Padding(10, 0, 0, 0);
            ayarlarUrunlerBtn.Size = new Size(192, 45);
            ayarlarUrunlerBtn.TabIndex = 9;
            ayarlarUrunlerBtn.Text = "  Ürünler";
            ayarlarUrunlerBtn.TextAlign = ContentAlignment.MiddleLeft;
            ayarlarUrunlerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ayarlarUrunlerBtn.UseVisualStyleBackColor = false;
            // 
            // ayarlarUrunlerGeriBtn
            // 
            ayarlarUrunlerGeriBtn.Dock = DockStyle.Top;
            ayarlarUrunlerGeriBtn.FlatAppearance.BorderSize = 0;
            ayarlarUrunlerGeriBtn.FlatStyle = FlatStyle.Flat;
            ayarlarUrunlerGeriBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            ayarlarUrunlerGeriBtn.ForeColor = Color.Gainsboro;
            ayarlarUrunlerGeriBtn.Image = Properties.Resources.back;
            ayarlarUrunlerGeriBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ayarlarUrunlerGeriBtn.Location = new Point(0, 0);
            ayarlarUrunlerGeriBtn.Margin = new Padding(3, 2, 3, 2);
            ayarlarUrunlerGeriBtn.Name = "ayarlarUrunlerGeriBtn";
            ayarlarUrunlerGeriBtn.Padding = new Padding(10, 0, 0, 0);
            ayarlarUrunlerGeriBtn.Size = new Size(192, 45);
            ayarlarUrunlerGeriBtn.TabIndex = 7;
            ayarlarUrunlerGeriBtn.Text = "  Geri";
            ayarlarUrunlerGeriBtn.TextAlign = ContentAlignment.MiddleLeft;
            ayarlarUrunlerGeriBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ayarlarUrunlerGeriBtn.UseVisualStyleBackColor = true;
            ayarlarUrunlerGeriBtn.Click += ayarlarUrunlerGeriBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 74);
            panel1.Controls.Add(ayarlarUrunlerBtn);
            panel1.Controls.Add(ayarlarUrunlerGeriBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(797, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 505);
            panel1.TabIndex = 7;
            // 
            // urunEkleBtn
            // 
            urunEkleBtn.Font = new Font("Microsoft Sans Serif", 8.999999F);
            urunEkleBtn.Location = new Point(22, 276);
            urunEkleBtn.Margin = new Padding(3, 2, 3, 2);
            urunEkleBtn.Name = "urunEkleBtn";
            urunEkleBtn.Size = new Size(201, 61);
            urunEkleBtn.TabIndex = 8;
            urunEkleBtn.Text = "Ekle";
            urunEkleBtn.UseVisualStyleBackColor = true;
            urunEkleBtn.Click += urunEkleBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 9;
            label1.Text = "Yeni Ürün Ekleme";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(22, 119);
            txtUrunAdi.Margin = new Padding(3, 2, 3, 2);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(110, 23);
            txtUrunAdi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Ürün adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label3.Location = new Point(22, 60);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 12;
            label3.Text = "ÜrünId";
            // 
            // txtUrunID
            // 
            txtUrunID.Location = new Point(22, 77);
            txtUrunID.Margin = new Padding(3, 2, 3, 2);
            txtUrunID.Name = "txtUrunID";
            txtUrunID.Size = new Size(110, 23);
            txtUrunID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label4.Location = new Point(21, 144);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 14;
            label4.Text = "Ürün Fiyatı";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(22, 161);
            txtFiyat.Margin = new Padding(3, 2, 3, 2);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(110, 23);
            txtFiyat.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label5.Location = new Point(22, 230);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 16;
            label5.Text = "Ürün Fotoğrafı";
            // 
            // urunfotoEkle
            // 
            urunfotoEkle.Font = new Font("Microsoft Sans Serif", 8.999999F);
            urunfotoEkle.Location = new Point(22, 248);
            urunfotoEkle.Name = "urunfotoEkle";
            urunfotoEkle.Size = new Size(129, 23);
            urunfotoEkle.TabIndex = 17;
            urunfotoEkle.Text = "Fotoğraf Ekle";
            urunfotoEkle.UseVisualStyleBackColor = true;
            urunfotoEkle.Click += urunfotoEkle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "tatlilar", "icecekler", "yiyecekler", "nargile" });
            cmbKategori.Location = new Point(22, 204);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label6.Location = new Point(22, 186);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 19;
            label6.Text = "Kategori";
            // 
            // urunDuzenleButton
            // 
            urunDuzenleButton.Font = new Font("Microsoft Sans Serif", 8.999999F);
            urunDuzenleButton.Location = new Point(242, 341);
            urunDuzenleButton.Margin = new Padding(3, 2, 3, 2);
            urunDuzenleButton.Name = "urunDuzenleButton";
            urunDuzenleButton.Size = new Size(201, 61);
            urunDuzenleButton.TabIndex = 20;
            urunDuzenleButton.Text = "Güncelle";
            urunDuzenleButton.UseVisualStyleBackColor = true;
            urunDuzenleButton.Click += urunDuzenleButton_Click;
            // 
            // urunDeleteButton
            // 
            urunDeleteButton.Font = new Font("Microsoft Sans Serif", 8.999999F);
            urunDeleteButton.Location = new Point(21, 341);
            urunDeleteButton.Margin = new Padding(3, 2, 3, 2);
            urunDeleteButton.Name = "urunDeleteButton";
            urunDeleteButton.Size = new Size(201, 61);
            urunDeleteButton.TabIndex = 21;
            urunDeleteButton.Text = "Sil";
            urunDeleteButton.UseVisualStyleBackColor = true;
            urunDeleteButton.Click += urunDeleteButton_Click;
            // 
            // urunGetir
            // 
            urunGetir.Font = new Font("Microsoft Sans Serif", 8.999999F);
            urunGetir.Location = new Point(242, 276);
            urunGetir.Margin = new Padding(3, 2, 3, 2);
            urunGetir.Name = "urunGetir";
            urunGetir.Size = new Size(201, 61);
            urunGetir.TabIndex = 22;
            urunGetir.Text = "Getir";
            urunGetir.UseVisualStyleBackColor = true;
            urunGetir.Click += urunGetir_Click;
            // 
            // AyarlarUrunler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(989, 505);
            Controls.Add(urunGetir);
            Controls.Add(urunDeleteButton);
            Controls.Add(urunDuzenleButton);
            Controls.Add(label6);
            Controls.Add(cmbKategori);
            Controls.Add(urunfotoEkle);
            Controls.Add(label5);
            Controls.Add(txtFiyat);
            Controls.Add(label4);
            Controls.Add(txtUrunID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Controls.Add(urunEkleBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AyarlarUrunler";
            Text = "AyarlarUrunler";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ayarlarUrunlerBtn;
        private Button ayarlarUrunlerGeriBtn;
        private Panel panel1;
        private Button urunEkleBtn;
        private Label label1;
        private TextBox txtUrunAdi;
        private Label label2;
        private Label label3;
        private TextBox txtUrunID;
        private Label label4;
        private TextBox txtFiyat;
        private Label label5;
        private Button urunfotoEkle;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbKategori;
        private Label label6;
        private Button urunDuzenleButton;
        private Button urunDeleteButton;
        private Button urunGetir;
    }
}