namespace WinFormsApp.Toplama
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
            btnTopla = new Button();
            label3 = new Label();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 62);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "1. Sayı";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(373, 64);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(130, 23);
            txtSayi1.TabIndex = 1;
            txtSayi1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(373, 105);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(130, 23);
            txtSayi2.TabIndex = 3;
            txtSayi2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(296, 103);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "2. Sayı";
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(373, 169);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(130, 33);
            btnTopla.TabIndex = 4;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(296, 230);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Sonuç";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSonuc.Location = new Point(373, 230);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 21);
            lblSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            AcceptButton = btnTopla;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(label3);
            Controls.Add(btnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
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
        private Button btnTopla;
        private Label label3;
        private Label lblSonuc;
    }
}