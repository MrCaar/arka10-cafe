namespace FinalArka10.Formlar
{
    partial class Ayarlar
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
            panel1 = new Panel();
            personellerBtn = new Button();
            urunlerBtn = new Button();
            siparislerBtn = new Button();
            ayarlarPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 74);
            panel1.Controls.Add(personellerBtn);
            panel1.Controls.Add(urunlerBtn);
            panel1.Controls.Add(siparislerBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(508, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 338);
            panel1.TabIndex = 2;
            // 
            // personellerBtn
            // 
            personellerBtn.Dock = DockStyle.Top;
            personellerBtn.FlatAppearance.BorderSize = 0;
            personellerBtn.FlatStyle = FlatStyle.Flat;
            personellerBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            personellerBtn.ForeColor = Color.Gainsboro;
            personellerBtn.Image = Properties.Resources.userssolid;
            personellerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            personellerBtn.Location = new Point(0, 90);
            personellerBtn.Margin = new Padding(3, 2, 3, 2);
            personellerBtn.Name = "personellerBtn";
            personellerBtn.Padding = new Padding(10, 0, 0, 0);
            personellerBtn.Size = new Size(192, 45);
            personellerBtn.TabIndex = 9;
            personellerBtn.Text = "  Personeller";
            personellerBtn.TextAlign = ContentAlignment.MiddleLeft;
            personellerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            personellerBtn.UseVisualStyleBackColor = true;
            personellerBtn.Click += personellerBtn_Click;
            // 
            // urunlerBtn
            // 
            urunlerBtn.Dock = DockStyle.Top;
            urunlerBtn.FlatAppearance.BorderSize = 0;
            urunlerBtn.FlatStyle = FlatStyle.Flat;
            urunlerBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            urunlerBtn.ForeColor = Color.Gainsboro;
            urunlerBtn.Image = Properties.Resources.serach;
            urunlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.Location = new Point(0, 45);
            urunlerBtn.Margin = new Padding(3, 2, 3, 2);
            urunlerBtn.Name = "urunlerBtn";
            urunlerBtn.Padding = new Padding(10, 0, 0, 0);
            urunlerBtn.Size = new Size(192, 45);
            urunlerBtn.TabIndex = 7;
            urunlerBtn.Text = "  Ürünler";
            urunlerBtn.TextAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            urunlerBtn.UseVisualStyleBackColor = true;
            urunlerBtn.Click += urunlerBtn_Click;
            // 
            // siparislerBtn
            // 
            siparislerBtn.Dock = DockStyle.Top;
            siparislerBtn.FlatAppearance.BorderSize = 0;
            siparislerBtn.FlatStyle = FlatStyle.Flat;
            siparislerBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            siparislerBtn.ForeColor = Color.Gainsboro;
            siparislerBtn.Image = Properties.Resources.receiptsolid;
            siparislerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            siparislerBtn.Location = new Point(0, 0);
            siparislerBtn.Margin = new Padding(3, 2, 3, 2);
            siparislerBtn.Name = "siparislerBtn";
            siparislerBtn.Padding = new Padding(10, 0, 0, 0);
            siparislerBtn.Size = new Size(192, 45);
            siparislerBtn.TabIndex = 6;
            siparislerBtn.Text = "  Siparişler";
            siparislerBtn.TextAlign = ContentAlignment.MiddleLeft;
            siparislerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            siparislerBtn.UseVisualStyleBackColor = true;
            siparislerBtn.Click += siparislerBtn_Click;
            // 
            // ayarlarPanel
            // 
            ayarlarPanel.BackColor = Color.Gainsboro;
            ayarlarPanel.Dock = DockStyle.Fill;
            ayarlarPanel.Location = new Point(0, 0);
            ayarlarPanel.Margin = new Padding(3, 2, 3, 2);
            ayarlarPanel.Name = "ayarlarPanel";
            ayarlarPanel.Size = new Size(508, 338);
            ayarlarPanel.TabIndex = 3;
            // 
            // Ayarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ayarlarPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ayarlar";
            Text = "Ayarlar";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button personellerBtn;
        private Button urunlerBtn;
        private Button siparislerBtn;
        private FlowLayoutPanel ayarlarPanel;
    }
}