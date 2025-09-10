namespace FinalArka10.Formlar
{
    partial class Indirim
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
            IndirimText = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.999999F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(386, 26);
            label1.TabIndex = 0;
            label1.Text = "Yüzde Kaç İndirim Yapmak İstiyorsun?";
            label1.Click += label1_Click;
            // 
            // IndirimText
            // 
            IndirimText.Location = new Point(150, 70);
            IndirimText.Name = "IndirimText";
            IndirimText.Size = new Size(138, 23);
            IndirimText.TabIndex = 1;
            IndirimText.TextChanged += IndirimText_TextChanged;
            // 
            // okButton
            // 
            okButton.Location = new Point(183, 111);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "İndirim Yap";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // Indirim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 74);
            ClientSize = new Size(452, 146);
            Controls.Add(okButton);
            Controls.Add(IndirimText);
            Controls.Add(label1);
            Name = "Indirim";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Indirim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IndirimText;
        private Button okButton;
    }
}