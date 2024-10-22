namespace WinFormsApp.EnBuyukEnKucuk
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
            txtEnBuyuk = new TextBox();
            txtEBOgrenci = new TextBox();
            label2 = new Label();
            txtEKOgrenci = new TextBox();
            label3 = new Label();
            txtEnKucuk = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "En Büyük Not";
            // 
            // txtEnBuyuk
            // 
            txtEnBuyuk.Location = new Point(145, 96);
            txtEnBuyuk.Name = "txtEnBuyuk";
            txtEnBuyuk.ReadOnly = true;
            txtEnBuyuk.Size = new Size(100, 29);
            txtEnBuyuk.TabIndex = 1;
            txtEnBuyuk.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEBOgrenci
            // 
            txtEBOgrenci.Location = new Point(330, 96);
            txtEBOgrenci.Name = "txtEBOgrenci";
            txtEBOgrenci.ReadOnly = true;
            txtEBOgrenci.Size = new Size(142, 29);
            txtEBOgrenci.TabIndex = 3;
            txtEBOgrenci.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 61);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Alan Öğrenci";
            // 
            // txtEKOgrenci
            // 
            txtEKOgrenci.Location = new Point(330, 210);
            txtEKOgrenci.Name = "txtEKOgrenci";
            txtEKOgrenci.ReadOnly = true;
            txtEKOgrenci.Size = new Size(142, 29);
            txtEKOgrenci.TabIndex = 7;
            txtEKOgrenci.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 175);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "Alan Öğrenci";
            // 
            // txtEnKucuk
            // 
            txtEnKucuk.Location = new Point(145, 210);
            txtEnKucuk.Name = "txtEnKucuk";
            txtEnKucuk.ReadOnly = true;
            txtEnKucuk.Size = new Size(100, 29);
            txtEnKucuk.TabIndex = 5;
            txtEnKucuk.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 175);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 4;
            label4.Text = "En Küçük Not";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 409);
            Controls.Add(txtEKOgrenci);
            Controls.Add(label3);
            Controls.Add(txtEnKucuk);
            Controls.Add(label4);
            Controls.Add(txtEBOgrenci);
            Controls.Add(label2);
            Controls.Add(txtEnBuyuk);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnBuyuk;
        private TextBox txtEBOgrenci;
        private Label label2;
        private TextBox txtEKOgrenci;
        private Label label3;
        private TextBox txtEnKucuk;
        private Label label4;
    }
}