namespace WinFormsApp.HataKontrolu
{
    partial class Form1
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
            label1 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            label2 = new Label();
            btnHesapla = new Button();
            txtSonuc = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 0;
            label1.Text = "1.sayı";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(246, 90);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 29);
            txtSayi1.TabIndex = 1;
            txtSayi1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(246, 134);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 29);
            txtSayi2.TabIndex = 3;
            txtSayi2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 135);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 2;
            label2.Text = "2.sayı";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(258, 210);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 37);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(246, 284);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(100, 29);
            txtSonuc.TabIndex = 6;
            txtSonuc.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 285);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 415);
            Controls.Add(txtSonuc);
            Controls.Add(label3);
            Controls.Add(btnHesapla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label label2;
        private Button btnHesapla;
        private TextBox txtSonuc;
        private Label label3;
    }
}