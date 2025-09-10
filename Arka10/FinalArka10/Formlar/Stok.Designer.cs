namespace FinalArka10.Formlar
{
    partial class Stok
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            tatlilarBtn = new Button();
            yiyeceklerBtn = new Button();
            iceceklerBtn = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(104, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(525, 400);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 74);
            panel1.Controls.Add(tatlilarBtn);
            panel1.Controls.Add(yiyeceklerBtn);
            panel1.Controls.Add(iceceklerBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(749, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 462);
            panel1.TabIndex = 12;
            // 
            // tatlilarBtn
            // 
            tatlilarBtn.Dock = DockStyle.Top;
            tatlilarBtn.FlatAppearance.BorderSize = 0;
            tatlilarBtn.FlatStyle = FlatStyle.Flat;
            tatlilarBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            tatlilarBtn.ForeColor = Color.Gainsboro;
            tatlilarBtn.Image = Properties.Resources.shopping_list;
            tatlilarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            tatlilarBtn.Location = new Point(0, 90);
            tatlilarBtn.Margin = new Padding(3, 2, 3, 2);
            tatlilarBtn.Name = "tatlilarBtn";
            tatlilarBtn.Padding = new Padding(10, 0, 0, 0);
            tatlilarBtn.Size = new Size(192, 45);
            tatlilarBtn.TabIndex = 9;
            tatlilarBtn.Text = "  Tatlılar";
            tatlilarBtn.TextAlign = ContentAlignment.MiddleLeft;
            tatlilarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            tatlilarBtn.UseVisualStyleBackColor = true;
            tatlilarBtn.Click += tatlilarBtn_Click;
            // 
            // yiyeceklerBtn
            // 
            yiyeceklerBtn.Dock = DockStyle.Top;
            yiyeceklerBtn.FlatAppearance.BorderSize = 0;
            yiyeceklerBtn.FlatStyle = FlatStyle.Flat;
            yiyeceklerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            yiyeceklerBtn.ForeColor = Color.Gainsboro;
            yiyeceklerBtn.Image = Properties.Resources.shopping_list;
            yiyeceklerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            yiyeceklerBtn.Location = new Point(0, 45);
            yiyeceklerBtn.Margin = new Padding(3, 2, 3, 2);
            yiyeceklerBtn.Name = "yiyeceklerBtn";
            yiyeceklerBtn.Padding = new Padding(10, 0, 0, 0);
            yiyeceklerBtn.Size = new Size(192, 45);
            yiyeceklerBtn.TabIndex = 8;
            yiyeceklerBtn.Text = "  Yiyecekler";
            yiyeceklerBtn.TextAlign = ContentAlignment.MiddleLeft;
            yiyeceklerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            yiyeceklerBtn.UseVisualStyleBackColor = true;
            yiyeceklerBtn.Click += yiyeceklerBtn_Click;
            // 
            // iceceklerBtn
            // 
            iceceklerBtn.Dock = DockStyle.Top;
            iceceklerBtn.FlatAppearance.BorderSize = 0;
            iceceklerBtn.FlatStyle = FlatStyle.Flat;
            iceceklerBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            iceceklerBtn.ForeColor = Color.Gainsboro;
            iceceklerBtn.Image = Properties.Resources.shopping_list;
            iceceklerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            iceceklerBtn.Location = new Point(0, 0);
            iceceklerBtn.Margin = new Padding(3, 2, 3, 2);
            iceceklerBtn.Name = "iceceklerBtn";
            iceceklerBtn.Padding = new Padding(10, 0, 0, 0);
            iceceklerBtn.Size = new Size(192, 45);
            iceceklerBtn.TabIndex = 7;
            iceceklerBtn.Text = "  İçecekler";
            iceceklerBtn.TextAlign = ContentAlignment.MiddleLeft;
            iceceklerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            iceceklerBtn.UseVisualStyleBackColor = true;
            iceceklerBtn.Click += iceceklerBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(475, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Stok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(941, 462);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Stok";
            Text = "Stok";
            Load += Stok_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button tatlilarBtn;
        private Button yiyeceklerBtn;
        private Button iceceklerBtn;
        private TextBox textBox1;
    }
}