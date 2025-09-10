namespace FinalArka10.Formlar
{
    partial class StokDuzenle
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
            label1 = new Label();
            increase = new Button();
            decrease = new Button();
            confirm = new Button();
            urunAdLabel = new Label();
            stokLabel = new Label();
            urunAdText = new Label();
            stokBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 24);
            label1.TabIndex = 0;
            label1.Text = "Stok Miktarı Düzenleniyor";
            // 
            // increase
            // 
            increase.Location = new Point(382, 84);
            increase.Name = "increase";
            increase.Size = new Size(75, 23);
            increase.TabIndex = 2;
            increase.Text = "Arttır";
            increase.UseVisualStyleBackColor = true;
            increase.Click += increase_Click;
            // 
            // decrease
            // 
            decrease.Location = new Point(382, 113);
            decrease.Name = "decrease";
            decrease.Size = new Size(75, 23);
            decrease.TabIndex = 3;
            decrease.Text = "Azalt";
            decrease.UseVisualStyleBackColor = true;
            decrease.Click += decrease_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(382, 142);
            confirm.Name = "confirm";
            confirm.Size = new Size(75, 23);
            confirm.TabIndex = 4;
            confirm.Text = "Onayla";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // urunAdLabel
            // 
            urunAdLabel.AutoSize = true;
            urunAdLabel.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            urunAdLabel.ForeColor = SystemColors.ButtonHighlight;
            urunAdLabel.Location = new Point(12, 137);
            urunAdLabel.Name = "urunAdLabel";
            urunAdLabel.Size = new Size(98, 24);
            urunAdLabel.TabIndex = 5;
            urunAdLabel.Text = "Ürün Adı:";
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            stokLabel.ForeColor = SystemColors.ButtonHighlight;
            stokLabel.Location = new Point(12, 161);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new Size(56, 24);
            stokLabel.TabIndex = 6;
            stokLabel.Text = "Stok:";
            // 
            // urunAdText
            // 
            urunAdText.AutoSize = true;
            urunAdText.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            urunAdText.ForeColor = SystemColors.ButtonHighlight;
            urunAdText.Location = new Point(130, 137);
            urunAdText.Name = "urunAdText";
            urunAdText.Size = new Size(21, 24);
            urunAdText.TabIndex = 7;
            // 
            // stokBox
            // 
            stokBox.Location = new Point(130, 159);
            stokBox.Name = "stokBox";
            stokBox.Size = new Size(56, 23);
            stokBox.TabIndex = 8;
            stokBox.TextChanged += stokBox_TextChanged;
            stokBox.KeyPress += stokBox_KeyPress;
            // 
            // StokDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 74);
            ClientSize = new Size(469, 194);
            Controls.Add(stokBox);
            Controls.Add(urunAdText);
            Controls.Add(stokLabel);
            Controls.Add(urunAdLabel);
            Controls.Add(confirm);
            Controls.Add(decrease);
            Controls.Add(increase);
            Controls.Add(label1);
            Name = "StokDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stok Düzenleniyor...";
            Load += StokDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IndirimText;
        private Button increase;
        private Button decrease;
        private Button confirm;
        private Label urunAdLabel;
        private Label stokLabel;
        private Label urunAdText;
        private TextBox stokBox;
    }
}