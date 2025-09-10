namespace FinalArka10.SiparislerAltFormlar
{
    partial class Bahce
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
            panel2 = new Panel();
            TerasBtn2 = new Button();
            BahceBtn2 = new Button();
            SalonBtn2 = new Button();
            terasBtn = new Button();
            bahceBtn = new Button();
            salonBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 74);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(terasBtn);
            panel1.Controls.Add(bahceBtn);
            panel1.Controls.Add(salonBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(692, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 539);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 74);
            panel2.Controls.Add(TerasBtn2);
            panel2.Controls.Add(BahceBtn2);
            panel2.Controls.Add(SalonBtn2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 539);
            panel2.TabIndex = 10;
            // 
            // TerasBtn2
            // 
            TerasBtn2.BackColor = Color.FromArgb(51, 51, 74);
            TerasBtn2.Dock = DockStyle.Top;
            TerasBtn2.FlatAppearance.BorderSize = 0;
            TerasBtn2.FlatStyle = FlatStyle.Flat;
            TerasBtn2.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            TerasBtn2.ForeColor = Color.Gainsboro;
            TerasBtn2.Image = Properties.Resources.terrace;
            TerasBtn2.ImageAlign = ContentAlignment.MiddleLeft;
            TerasBtn2.Location = new Point(0, 90);
            TerasBtn2.Margin = new Padding(3, 2, 3, 2);
            TerasBtn2.Name = "TerasBtn2";
            TerasBtn2.Padding = new Padding(10, 0, 0, 0);
            TerasBtn2.Size = new Size(192, 45);
            TerasBtn2.TabIndex = 10;
            TerasBtn2.Text = "  Teras";
            TerasBtn2.TextAlign = ContentAlignment.MiddleLeft;
            TerasBtn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            TerasBtn2.UseVisualStyleBackColor = false;
            TerasBtn2.Click += TerasBtn2_Click_1;
            // 
            // BahceBtn2
            // 
            BahceBtn2.BackColor = Color.Gainsboro;
            BahceBtn2.Dock = DockStyle.Top;
            BahceBtn2.FlatAppearance.BorderSize = 0;
            BahceBtn2.FlatStyle = FlatStyle.Flat;
            BahceBtn2.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            BahceBtn2.ForeColor = Color.Black;
            BahceBtn2.Image = Properties.Resources.tree;
            BahceBtn2.ImageAlign = ContentAlignment.MiddleLeft;
            BahceBtn2.Location = new Point(0, 45);
            BahceBtn2.Margin = new Padding(3, 2, 3, 2);
            BahceBtn2.Name = "BahceBtn2";
            BahceBtn2.Padding = new Padding(10, 0, 0, 0);
            BahceBtn2.Size = new Size(192, 45);
            BahceBtn2.TabIndex = 9;
            BahceBtn2.Text = "  Bahçe";
            BahceBtn2.TextAlign = ContentAlignment.MiddleLeft;
            BahceBtn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            BahceBtn2.UseVisualStyleBackColor = false;
            BahceBtn2.Click += BahceBtn2_Click;
            // 
            // SalonBtn2
            // 
            SalonBtn2.BackColor = Color.FromArgb(51, 51, 74);
            SalonBtn2.Dock = DockStyle.Top;
            SalonBtn2.FlatAppearance.BorderSize = 0;
            SalonBtn2.FlatStyle = FlatStyle.Flat;
            SalonBtn2.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            SalonBtn2.ForeColor = Color.Gainsboro;
            SalonBtn2.Image = Properties.Resources.table_solid;
            SalonBtn2.ImageAlign = ContentAlignment.MiddleLeft;
            SalonBtn2.Location = new Point(0, 0);
            SalonBtn2.Margin = new Padding(3, 2, 3, 2);
            SalonBtn2.Name = "SalonBtn2";
            SalonBtn2.Padding = new Padding(10, 0, 0, 0);
            SalonBtn2.Size = new Size(192, 45);
            SalonBtn2.TabIndex = 8;
            SalonBtn2.Text = "  Salon";
            SalonBtn2.TextAlign = ContentAlignment.MiddleLeft;
            SalonBtn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            SalonBtn2.UseVisualStyleBackColor = false;
            SalonBtn2.Click += ayarlarSalonBtn_Click;
            // 
            // terasBtn
            // 
            terasBtn.Location = new Point(0, 0);
            terasBtn.Name = "terasBtn";
            terasBtn.Size = new Size(75, 23);
            terasBtn.TabIndex = 11;
            // 
            // bahceBtn
            // 
            bahceBtn.Location = new Point(0, 0);
            bahceBtn.Name = "bahceBtn";
            bahceBtn.Size = new Size(75, 23);
            bahceBtn.TabIndex = 12;
            // 
            // salonBtn
            // 
            salonBtn.Location = new Point(0, 0);
            salonBtn.Name = "salonBtn";
            salonBtn.Size = new Size(75, 23);
            salonBtn.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(639, 494);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // Bahce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(884, 539);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bahce";
            Text = "Bahce";
            Load += Bahce_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button terasBtn;
        private Button bahceBtn;
        private Button salonBtn;
        private Panel panel2;
        private Button TerasBtn2;
        private Button BahceBtn2;
        private Button SalonBtn2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
