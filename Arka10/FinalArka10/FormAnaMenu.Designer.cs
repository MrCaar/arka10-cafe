namespace FinalArka10
{
    partial class FormAnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaMenu));
            panelMenu = new Panel();
            lblSayac = new Label();
            dbcheck = new Label();
            label1 = new Label();
            ayarlarBtn = new Button();
            personellerBtn = new Button();
            stokBtn = new Button();
            urunlerBtn = new Button();
            ikinciformBtn = new Button();
            siparislerBtn = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            panelLogo2 = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(lblSayac);
            panelMenu.Controls.Add(dbcheck);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(ayarlarBtn);
            panelMenu.Controls.Add(personellerBtn);
            panelMenu.Controls.Add(stokBtn);
            panelMenu.Controls.Add(urunlerBtn);
            panelMenu.Controls.Add(ikinciformBtn);
            panelMenu.Controls.Add(siparislerBtn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 518);
            panelMenu.TabIndex = 0;
            // 
            // lblSayac
            // 
            lblSayac.AutoSize = true;
            lblSayac.Font = new Font("Montserrat", 9F);
            lblSayac.ForeColor = SystemColors.ButtonFace;
            lblSayac.Location = new Point(12, 470);
            lblSayac.Name = "lblSayac";
            lblSayac.Size = new Size(99, 15);
            lblSayac.TabIndex = 8;
            lblSayac.Text = "Oturum Süresi:";
            // 
            // dbcheck
            // 
            dbcheck.Anchor = AnchorStyles.None;
            dbcheck.AutoSize = true;
            dbcheck.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
            dbcheck.ForeColor = Color.White;
            dbcheck.Location = new Point(108, 486);
            dbcheck.Name = "dbcheck";
            dbcheck.Size = new Size(76, 20);
            dbcheck.TabIndex = 7;
            dbcheck.Text = "Offline";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 485);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "DBStatus: ";
            // 
            // ayarlarBtn
            // 
            ayarlarBtn.Dock = DockStyle.Top;
            ayarlarBtn.FlatAppearance.BorderSize = 0;
            ayarlarBtn.FlatStyle = FlatStyle.Flat;
            ayarlarBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            ayarlarBtn.ForeColor = Color.Gainsboro;
            ayarlarBtn.Image = Properties.Resources.gearsolid;
            ayarlarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ayarlarBtn.Location = new Point(0, 285);
            ayarlarBtn.Margin = new Padding(3, 2, 3, 2);
            ayarlarBtn.Name = "ayarlarBtn";
            ayarlarBtn.Padding = new Padding(10, 0, 0, 0);
            ayarlarBtn.Size = new Size(192, 45);
            ayarlarBtn.TabIndex = 6;
            ayarlarBtn.Text = "  Ayarlar";
            ayarlarBtn.TextAlign = ContentAlignment.MiddleLeft;
            ayarlarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ayarlarBtn.UseVisualStyleBackColor = true;
            ayarlarBtn.Click += ayarlarBtn_Click;
            // 
            // personellerBtn
            // 
            personellerBtn.Dock = DockStyle.Top;
            personellerBtn.FlatAppearance.BorderSize = 0;
            personellerBtn.FlatStyle = FlatStyle.Flat;
            personellerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            personellerBtn.ForeColor = Color.Gainsboro;
            personellerBtn.Image = Properties.Resources.userssolid;
            personellerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            personellerBtn.Location = new Point(0, 240);
            personellerBtn.Margin = new Padding(3, 2, 3, 2);
            personellerBtn.Name = "personellerBtn";
            personellerBtn.Padding = new Padding(10, 0, 0, 0);
            personellerBtn.Size = new Size(192, 45);
            personellerBtn.TabIndex = 5;
            personellerBtn.Text = "  Personeller";
            personellerBtn.TextAlign = ContentAlignment.MiddleLeft;
            personellerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            personellerBtn.UseVisualStyleBackColor = true;
            personellerBtn.Click += personellerBtn_Click;
            // 
            // stokBtn
            // 
            stokBtn.Dock = DockStyle.Top;
            stokBtn.FlatAppearance.BorderSize = 0;
            stokBtn.FlatStyle = FlatStyle.Flat;
            stokBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            stokBtn.ForeColor = Color.Gainsboro;
            stokBtn.Image = Properties.Resources.rightleft;
            stokBtn.ImageAlign = ContentAlignment.MiddleLeft;
            stokBtn.Location = new Point(0, 195);
            stokBtn.Margin = new Padding(3, 2, 3, 2);
            stokBtn.Name = "stokBtn";
            stokBtn.Padding = new Padding(10, 0, 0, 0);
            stokBtn.Size = new Size(192, 45);
            stokBtn.TabIndex = 4;
            stokBtn.Text = "  Stok";
            stokBtn.TextAlign = ContentAlignment.MiddleLeft;
            stokBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stokBtn.UseVisualStyleBackColor = true;
            stokBtn.Click += stokBtn_Click;
            // 
            // urunlerBtn
            // 
            urunlerBtn.Dock = DockStyle.Top;
            urunlerBtn.FlatAppearance.BorderSize = 0;
            urunlerBtn.FlatStyle = FlatStyle.Flat;
            urunlerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunlerBtn.ForeColor = Color.Gainsboro;
            urunlerBtn.Image = Properties.Resources.serach;
            urunlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.Location = new Point(0, 150);
            urunlerBtn.Margin = new Padding(3, 2, 3, 2);
            urunlerBtn.Name = "urunlerBtn";
            urunlerBtn.Padding = new Padding(10, 0, 0, 0);
            urunlerBtn.Size = new Size(192, 45);
            urunlerBtn.TabIndex = 3;
            urunlerBtn.Text = "  Ürünler";
            urunlerBtn.TextAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            urunlerBtn.UseVisualStyleBackColor = true;
            urunlerBtn.Click += urunlerBtn_Click;
            // 
            // ikinciformBtn
            // 
            ikinciformBtn.Dock = DockStyle.Top;
            ikinciformBtn.FlatAppearance.BorderSize = 0;
            ikinciformBtn.FlatStyle = FlatStyle.Flat;
            ikinciformBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ikinciformBtn.ForeColor = Color.Gainsboro;
            ikinciformBtn.Image = Properties.Resources.receiptsolid;
            ikinciformBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ikinciformBtn.Location = new Point(0, 105);
            ikinciformBtn.Margin = new Padding(3, 2, 3, 2);
            ikinciformBtn.Name = "ikinciformBtn";
            ikinciformBtn.Padding = new Padding(10, 0, 0, 0);
            ikinciformBtn.Size = new Size(192, 45);
            ikinciformBtn.TabIndex = 2;
            ikinciformBtn.Text = "  Adisyon";
            ikinciformBtn.TextAlign = ContentAlignment.MiddleLeft;
            ikinciformBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ikinciformBtn.UseVisualStyleBackColor = true;
            ikinciformBtn.Click += ikinciformBtn_Click;
            // 
            // siparislerBtn
            // 
            siparislerBtn.Dock = DockStyle.Top;
            siparislerBtn.FlatAppearance.BorderSize = 0;
            siparislerBtn.FlatStyle = FlatStyle.Flat;
            siparislerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            siparislerBtn.ForeColor = Color.Gainsboro;
            siparislerBtn.Image = Properties.Resources.table_solid;
            siparislerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            siparislerBtn.Location = new Point(0, 60);
            siparislerBtn.Margin = new Padding(3, 2, 3, 2);
            siparislerBtn.Name = "siparislerBtn";
            siparislerBtn.Padding = new Padding(10, 0, 0, 0);
            siparislerBtn.Size = new Size(192, 45);
            siparislerBtn.TabIndex = 1;
            siparislerBtn.Text = "  Siparişler";
            siparislerBtn.TextAlign = ContentAlignment.MiddleLeft;
            siparislerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            siparislerBtn.UseVisualStyleBackColor = true;
            siparislerBtn.Click += siparislerBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(192, 60);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(panelLogo2);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Font = new Font("Segoe UI", 30F);
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(843, 60);
            panelTitleBar.TabIndex = 1;
            // 
            // panelLogo2
            // 
            panelLogo2.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo2.Dock = DockStyle.Right;
            panelLogo2.Location = new Point(651, 0);
            panelLogo2.Margin = new Padding(3, 2, 3, 2);
            panelLogo2.Name = "panelLogo2";
            panelLogo2.Size = new Size(192, 60);
            panelLogo2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(289, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Anasayfa";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.BackColor = Color.Gainsboro;
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(192, 60);
            panelDesktopPanel.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(843, 458);
            panelDesktopPanel.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 518);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormAnaMenu_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button siparislerBtn;
        private Panel panelLogo;
        private Button ayarlarBtn;
        private Button stokBtn;
        private Button urunlerBtn;
        private Button ikinciformBtn;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Panel panelLogo2;
        private Button personellerBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label dbcheck;
        private Label lblSayac;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
