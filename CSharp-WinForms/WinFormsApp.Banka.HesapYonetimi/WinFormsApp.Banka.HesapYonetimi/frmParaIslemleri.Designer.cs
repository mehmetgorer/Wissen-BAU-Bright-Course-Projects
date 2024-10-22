namespace WinFormsApp.Banka.HesapYonetimi
{
    partial class frmParaIslemleri
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
            txtTarih = new TextBox();
            label3 = new Label();
            txtHesapNo = new TextBox();
            label2 = new Label();
            txtHesapId = new TextBox();
            label1 = new Label();
            btnTamam = new Button();
            label8 = new Label();
            cbIslemTuru = new ComboBox();
            txtTutar = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(126, 116);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(143, 29);
            txtTarih.TabIndex = 11;
            txtTarih.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 119);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 10;
            label3.Text = "Açılış Tarihi";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(126, 81);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.ReadOnly = true;
            txtHesapNo.Size = new Size(143, 29);
            txtHesapNo.TabIndex = 9;
            txtHesapNo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 8;
            label2.Text = "Hesap No";
            // 
            // txtHesapId
            // 
            txtHesapId.Location = new Point(126, 46);
            txtHesapId.Name = "txtHesapId";
            txtHesapId.ReadOnly = true;
            txtHesapId.Size = new Size(143, 29);
            txtHesapId.TabIndex = 7;
            txtHesapId.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 49);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 6;
            label1.Text = "Hesap ID";
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(126, 275);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(143, 35);
            btnTamam.TabIndex = 21;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 219);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 20;
            label8.Text = "İşlem Türü";
            // 
            // cbIslemTuru
            // 
            cbIslemTuru.FormattingEnabled = true;
            cbIslemTuru.Items.AddRange(new object[] { "Yatan", "Cekilen" });
            cbIslemTuru.Location = new Point(126, 216);
            cbIslemTuru.Name = "cbIslemTuru";
            cbIslemTuru.Size = new Size(143, 29);
            cbIslemTuru.TabIndex = 19;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(126, 167);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(143, 29);
            txtTutar.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 168);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 17;
            label7.Text = "Tutar";
            // 
            // frmParaIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 361);
            Controls.Add(btnTamam);
            Controls.Add(label8);
            Controls.Add(cbIslemTuru);
            Controls.Add(txtTutar);
            Controls.Add(label7);
            Controls.Add(txtTarih);
            Controls.Add(label3);
            Controls.Add(txtHesapNo);
            Controls.Add(label2);
            Controls.Add(txtHesapId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmParaIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmParaIslemleri";
            Load += frmParaIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarih;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTamam;
        private Label label8;
        private ComboBox cbIslemTuru;
        private TextBox txtTutar;
        private Label label7;
        public TextBox txtHesapNo;
        public TextBox txtHesapId;
    }
}