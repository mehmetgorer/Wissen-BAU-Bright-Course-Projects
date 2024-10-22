namespace WinFormsApp.Metotlar
{
    partial class Form2
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
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            label2 = new Label();
            btnTopla = new Button();
            label1 = new Label();
            label3 = new Label();
            txtSonuc = new TextBox();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(173, 92);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(65, 29);
            txtSayi1.TabIndex = 1;
            txtSayi1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(292, 92);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(65, 29);
            txtSayi2.TabIndex = 3;
            txtSayi2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "2. sayı";
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(216, 158);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(98, 30);
            btnTopla.TabIndex = 4;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 62);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "1. sayı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 216);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Sonuç";
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(292, 216);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.ReadOnly = true;
            txtSonuc.Size = new Size(65, 29);
            txtSonuc.TabIndex = 6;
            txtSonuc.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 428);
            Controls.Add(txtSonuc);
            Controls.Add(label3);
            Controls.Add(btnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label label2;
        private Button btnTopla;
        private Label label1;
        private Label label3;
        private TextBox txtSonuc;
    }
}