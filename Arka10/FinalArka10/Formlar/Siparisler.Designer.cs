namespace FinalArka10.Formlar
{
    partial class Siparisler
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
            terasBtn = new Button();
            bahceBtn = new Button();
            salonBtn = new Button();
            siparislerPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 74);
            panel1.Controls.Add(terasBtn);
            panel1.Controls.Add(bahceBtn);
            panel1.Controls.Add(salonBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(926, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 691);
            panel1.TabIndex = 2;
            // 
            // terasBtn
            // 
            terasBtn.Dock = DockStyle.Top;
            terasBtn.FlatAppearance.BorderSize = 0;
            terasBtn.FlatStyle = FlatStyle.Flat;
            terasBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            terasBtn.ForeColor = Color.Gainsboro;
            terasBtn.Image = Properties.Resources.terrace;
            terasBtn.ImageAlign = ContentAlignment.MiddleLeft;
            terasBtn.Location = new Point(0, 120);
            terasBtn.Name = "terasBtn";
            terasBtn.Padding = new Padding(11, 0, 0, 0);
            terasBtn.Size = new Size(219, 60);
            terasBtn.TabIndex = 9;
            terasBtn.Text = "  Teras";
            terasBtn.TextAlign = ContentAlignment.MiddleLeft;
            terasBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            terasBtn.UseVisualStyleBackColor = true;
            terasBtn.Click += terasBtn_Click;
            // 
            // bahceBtn
            // 
            bahceBtn.BackColor = Color.FromArgb(51, 51, 74);
            bahceBtn.Dock = DockStyle.Top;
            bahceBtn.FlatAppearance.BorderSize = 0;
            bahceBtn.FlatStyle = FlatStyle.Flat;
            bahceBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            bahceBtn.ForeColor = Color.Gainsboro;
            bahceBtn.Image = Properties.Resources.tree;
            bahceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bahceBtn.Location = new Point(0, 60);
            bahceBtn.Name = "bahceBtn";
            bahceBtn.Padding = new Padding(11, 0, 0, 0);
            bahceBtn.Size = new Size(219, 60);
            bahceBtn.TabIndex = 8;
            bahceBtn.Text = "  Bahçe";
            bahceBtn.TextAlign = ContentAlignment.MiddleLeft;
            bahceBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            bahceBtn.UseVisualStyleBackColor = false;
            bahceBtn.Click += bahceBtn_Click;
            // 
            // salonBtn
            // 
            salonBtn.Dock = DockStyle.Top;
            salonBtn.FlatAppearance.BorderSize = 0;
            salonBtn.FlatStyle = FlatStyle.Flat;
            salonBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            salonBtn.ForeColor = Color.Gainsboro;
            salonBtn.Image = Properties.Resources.table_solid;
            salonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            salonBtn.Location = new Point(0, 0);
            salonBtn.Name = "salonBtn";
            salonBtn.Padding = new Padding(11, 0, 0, 0);
            salonBtn.Size = new Size(219, 60);
            salonBtn.TabIndex = 7;
            salonBtn.Text = "  Salon";
            salonBtn.TextAlign = ContentAlignment.MiddleLeft;
            salonBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            salonBtn.UseVisualStyleBackColor = true;
            salonBtn.Click += salonBtn_Click;
            // 
            // siparislerPanel
            // 
            siparislerPanel.BackColor = Color.Gainsboro;
            siparislerPanel.Dock = DockStyle.Fill;
            siparislerPanel.Location = new Point(0, 0);
            siparislerPanel.Name = "siparislerPanel";
            siparislerPanel.Size = new Size(926, 691);
            siparislerPanel.TabIndex = 3;
            // 
            // Siparisler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 691);
            Controls.Add(siparislerPanel);
            Controls.Add(panel1);
            Name = "Siparisler";
            Text = "Masalar";
            Load += Siparisler_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button terasBtn;
        private Button bahceBtn;
        private Button salonBtn;
        private Panel siparislerPanel;
    }
}