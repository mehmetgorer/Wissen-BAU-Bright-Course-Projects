namespace WinFormsApp.BankaHesaplari
{
    partial class frmParaYatirCek
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
            btnTamam = new Button();
            label8 = new Label();
            cbIslemTuru = new ComboBox();
            txtTutar = new TextBox();
            label7 = new Label();
            txtTarih = new TextBox();
            label3 = new Label();
            txtHesapNo = new TextBox();
            label2 = new Label();
            txtTCKNo = new TextBox();
            label1 = new Label();
            txtSoyadi = new TextBox();
            label4 = new Label();
            txtAdi = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(138, 354);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(143, 35);
            btnTamam.TabIndex = 30;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 298);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 29;
            label8.Text = "İşlem Türü";
            // 
            // cbIslemTuru
            // 
            cbIslemTuru.FormattingEnabled = true;
            cbIslemTuru.Items.AddRange(new object[] { "Yatan", "Cekilen" });
            cbIslemTuru.Location = new Point(138, 295);
            cbIslemTuru.Name = "cbIslemTuru";
            cbIslemTuru.Size = new Size(143, 23);
            cbIslemTuru.TabIndex = 28;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(138, 252);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(143, 23);
            txtTutar.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 253);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 27;
            label7.Text = "Tutar";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(138, 93);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(143, 23);
            txtTarih.TabIndex = 26;
            txtTarih.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 96);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 25;
            label3.Text = "Açılış Tarihi";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(138, 64);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.ReadOnly = true;
            txtHesapNo.Size = new Size(143, 23);
            txtHesapNo.TabIndex = 24;
            txtHesapNo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 23;
            label2.Text = "Hesap No";
            // 
            // txtTCKNo
            // 
            txtTCKNo.Location = new Point(138, 204);
            txtTCKNo.Margin = new Padding(3, 4, 3, 4);
            txtTCKNo.MaxLength = 11;
            txtTCKNo.Name = "txtTCKNo";
            txtTCKNo.ReadOnly = true;
            txtTCKNo.Size = new Size(143, 23);
            txtTCKNo.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 207);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 35;
            label1.Text = "TCKNo";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(138, 170);
            txtSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.ReadOnly = true;
            txtSoyadi.Size = new Size(143, 23);
            txtSoyadi.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 33;
            label4.Text = "Soyadı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(138, 136);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.ReadOnly = true;
            txtAdi.Size = new Size(143, 23);
            txtAdi.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 139);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 31;
            label5.Text = "Adı";
            // 
            // frmParaYatirCek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 479);
            Controls.Add(txtTCKNo);
            Controls.Add(label1);
            Controls.Add(txtSoyadi);
            Controls.Add(label4);
            Controls.Add(txtAdi);
            Controls.Add(label5);
            Controls.Add(btnTamam);
            Controls.Add(label8);
            Controls.Add(cbIslemTuru);
            Controls.Add(txtTutar);
            Controls.Add(label7);
            Controls.Add(txtTarih);
            Controls.Add(label3);
            Controls.Add(txtHesapNo);
            Controls.Add(label2);
            Name = "frmParaYatirCek";
            Text = "frmParaYatirCek";
            Load += frmParaYatirCek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTamam;
        private Label label8;
        private ComboBox cbIslemTuru;
        private TextBox txtTutar;
        private Label label7;
        private TextBox txtTarih;
        private Label label3;
        public TextBox txtHesapNo;
        private Label label2;
        private TextBox txtTCKNo;
        private Label label1;
        private TextBox txtSoyadi;
        private Label label4;
        private TextBox txtAdi;
        private Label label5;
    }
}