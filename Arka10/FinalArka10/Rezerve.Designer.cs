namespace FinalArka10.Formlar
{
    partial class Rezerve
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
            dateTimePicker1 = new DateTimePicker();
            rezerveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.999999F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(394, 30);
            label1.TabIndex = 0;
            label1.Text = "Rezerve Etmek İstediğiniz Saati Seçiniz";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd  |  HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(128, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2025, 1, 5, 5, 21, 29, 0);
            // 
            // rezerveBtn
            // 
            rezerveBtn.Location = new Point(184, 111);
            rezerveBtn.Name = "rezerveBtn";
            rezerveBtn.Size = new Size(75, 23);
            rezerveBtn.TabIndex = 2;
            rezerveBtn.Text = "Rezerve Et";
            rezerveBtn.UseVisualStyleBackColor = true;
            rezerveBtn.Click += rezerveBtn_Click;
            // 
            // Rezerve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 74);
            ClientSize = new Size(452, 146);
            Controls.Add(rezerveBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Rezerve";
            Text = "Rezerve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button rezerveBtn;
    }
}