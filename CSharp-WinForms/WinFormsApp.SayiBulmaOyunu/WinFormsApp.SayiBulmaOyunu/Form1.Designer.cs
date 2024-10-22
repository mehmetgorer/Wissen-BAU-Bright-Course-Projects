namespace WinFormsApp.SayiBulmaOyunu
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
            label2 = new Label();
            txtTahmin = new TextBox();
            btnDene = new Button();
            rbBaslangic = new RadioButton();
            rbOrta = new RadioButton();
            rbIleri = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 21);
            label1.TabIndex = 0;
            label1.Text = "1-50 arası rastgele sayı tuttum.  Bakalım kaç defada bulabileceksiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 158);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Tahmininiz";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(305, 158);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(80, 29);
            txtTahmin.TabIndex = 2;
            txtTahmin.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDene
            // 
            btnDene.Location = new Point(389, 155);
            btnDene.Name = "btnDene";
            btnDene.Size = new Size(63, 35);
            btnDene.TabIndex = 3;
            btnDene.Text = "Dene";
            btnDene.UseVisualStyleBackColor = true;
            btnDene.Click += btnDene_Click;
            // 
            // rbBaslangic
            // 
            rbBaslangic.AutoSize = true;
            rbBaslangic.Checked = true;
            rbBaslangic.Location = new Point(72, 90);
            rbBaslangic.Name = "rbBaslangic";
            rbBaslangic.Size = new Size(140, 25);
            rbBaslangic.TabIndex = 4;
            rbBaslangic.TabStop = true;
            rbBaslangic.Text = "Başlangıç seviye";
            rbBaslangic.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(318, 90);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(108, 25);
            rbOrta.TabIndex = 5;
            rbOrta.Text = "Orta Seviye";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbIleri
            // 
            rbIleri.AutoSize = true;
            rbIleri.Location = new Point(518, 90);
            rbIleri.Name = "rbIleri";
            rbIleri.Size = new Size(103, 25);
            rbIleri.TabIndex = 6;
            rbIleri.Text = "İleri Seviye";
            rbIleri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnDene;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(732, 330);
            Controls.Add(rbIleri);
            Controls.Add(rbOrta);
            Controls.Add(rbBaslangic);
            Controls.Add(btnDene);
            Controls.Add(txtTahmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Blue;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sayı Bulma Oyunu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTahmin;
        private Button btnDene;
        private RadioButton rbBaslangic;
        private RadioButton rbOrta;
        private RadioButton rbIleri;
    }
}