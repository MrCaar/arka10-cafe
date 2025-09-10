namespace FinalArka10.Formlar
{
    partial class UrunDuzenle
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
            confirm = new Button();
            urunIdLabel = new Label();
            stokLabel = new Label();
            urunAdText = new Label();
            fiyatBox = new TextBox();
            label2 = new Label();
            adBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 0;
            label1.Text = "Düzenlenen Ürün Id:";
            // 
            // confirm
            // 
            confirm.Location = new Point(355, 104);
            confirm.Name = "confirm";
            confirm.Size = new Size(102, 41);
            confirm.TabIndex = 4;
            confirm.Text = "Değişklikleri Kaydet";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // urunIdLabel
            // 
            urunIdLabel.AutoSize = true;
            urunIdLabel.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            urunIdLabel.ForeColor = SystemColors.ButtonHighlight;
            urunIdLabel.Location = new Point(221, 9);
            urunIdLabel.Name = "urunIdLabel";
            urunIdLabel.Size = new Size(16, 24);
            urunIdLabel.TabIndex = 5;
            urunIdLabel.Text = ".";
            urunIdLabel.Visible = false;
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            stokLabel.ForeColor = SystemColors.ButtonHighlight;
            stokLabel.Location = new Point(12, 155);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new Size(60, 24);
            stokLabel.TabIndex = 6;
            stokLabel.Text = "Fiyat:";
            // 
            // urunAdText
            // 
            urunAdText.AutoSize = true;
            urunAdText.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            urunAdText.ForeColor = SystemColors.ButtonHighlight;
            urunAdText.Location = new Point(130, 137);
            urunAdText.Name = "urunAdText";
            urunAdText.Size = new Size(0, 24);
            urunAdText.TabIndex = 7;
            // 
            // fiyatBox
            // 
            fiyatBox.Location = new Point(130, 159);
            fiyatBox.Name = "fiyatBox";
            fiyatBox.Size = new Size(138, 23);
            fiyatBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 9;
            label2.Text = "Ürün Adı:";
            // 
            // adBox
            // 
            adBox.Location = new Point(130, 122);
            adBox.Name = "adBox";
            adBox.Size = new Size(138, 23);
            adBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(355, 149);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 11;
            button1.Text = "Değişklikleri Yoksay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UrunDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 74);
            ClientSize = new Size(469, 194);
            Controls.Add(button1);
            Controls.Add(adBox);
            Controls.Add(label2);
            Controls.Add(fiyatBox);
            Controls.Add(urunAdText);
            Controls.Add(stokLabel);
            Controls.Add(urunIdLabel);
            Controls.Add(confirm);
            Controls.Add(label1);
            Name = "UrunDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürün Düzenleniyor...";
            Load += UrunDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IndirimText;
        private Button confirm;
        private Label urunIdLabel;
        private Label stokLabel;
        private Label urunAdText;
        private TextBox fiyatBox;
        private Label label2;
        private TextBox adBox;
        private Button button1;
    }
}