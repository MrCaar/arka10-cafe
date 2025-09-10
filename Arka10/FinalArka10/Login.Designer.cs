namespace FinalArka10
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button11 = new Button();
            button12 = new Button();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 75);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += TextBox1_KeyPress;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.Location = new Point(12, 104);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 4;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Location = new Point(114, 104);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 5;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(63, 104);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 6;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button5.Location = new Point(63, 155);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button6.Location = new Point(12, 155);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 8;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button7.Location = new Point(114, 155);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 9;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button8.Location = new Point(63, 207);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button9.Location = new Point(114, 206);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button10.Location = new Point(12, 206);
            button10.Name = "button10";
            button10.Size = new Size(45, 45);
            button10.TabIndex = 12;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 46);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(174, 60);
            panelLogo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arka10login;
            pictureBox2.Location = new Point(12, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(114, 255);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 14;
            button1.Text = "⌫";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button11.Location = new Point(63, 255);
            button11.Name = "button11";
            button11.Size = new Size(45, 45);
            button11.TabIndex = 15;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button12.Location = new Point(12, 255);
            button12.Name = "button12";
            button12.Size = new Size(45, 45);
            button12.TabIndex = 16;
            button12.Text = "SİL";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 46);
            ClientSize = new Size(174, 358);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panelLogo);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button11;
        private Button button12;
    }
}