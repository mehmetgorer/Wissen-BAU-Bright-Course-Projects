namespace WinFormsApp.Banka.HesapYonetimi
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
            txtHesapId = new TextBox();
            txtHesapNo = new TextBox();
            label2 = new Label();
            txtTarih = new TextBox();
            label3 = new Label();
            txtAdi = new TextBox();
            label4 = new Label();
            txtSoyadi = new TextBox();
            label5 = new Label();
            txtTCKNo = new TextBox();
            label6 = new Label();
            txtBakiye = new TextBox();
            label7 = new Label();
            cbHesapTuru = new ComboBox();
            label8 = new Label();
            btnHesapAc = new Button();
            lvHesaplar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            lvHareketler = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            txtToplamBakiye = new TextBox();
            label9 = new Label();
            txtToplamCekilen = new TextBox();
            label10 = new Label();
            txtToplamYatan = new TextBox();
            label11 = new Label();
            btnParaYatirCek = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Hesap ID";
            // 
            // txtHesapId
            // 
            txtHesapId.Location = new Point(117, 39);
            txtHesapId.Name = "txtHesapId";
            txtHesapId.ReadOnly = true;
            txtHesapId.Size = new Size(141, 29);
            txtHesapId.TabIndex = 1;
            txtHesapId.TabStop = false;
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(117, 74);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.ReadOnly = true;
            txtHesapNo.Size = new Size(141, 29);
            txtHesapNo.TabIndex = 3;
            txtHesapNo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 2;
            label2.Text = "Hesap No";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(117, 109);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(141, 29);
            txtTarih.TabIndex = 5;
            txtTarih.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 112);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 4;
            label3.Text = "Açılış Tarihi";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(117, 164);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(141, 29);
            txtAdi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 165);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 6;
            label4.Text = "Müşteri Adı";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(117, 199);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(141, 29);
            txtSoyadi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 200);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 8;
            label5.Text = "Soyadı";
            // 
            // txtTCKNo
            // 
            txtTCKNo.Location = new Point(117, 234);
            txtTCKNo.MaxLength = 11;
            txtTCKNo.Name = "txtTCKNo";
            txtTCKNo.Size = new Size(141, 29);
            txtTCKNo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 235);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 10;
            label6.Text = "TCKimlikNo";
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(117, 287);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(141, 29);
            txtBakiye.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 288);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 12;
            label7.Text = "Bakiye";
            // 
            // cbHesapTuru
            // 
            cbHesapTuru.FormattingEnabled = true;
            cbHesapTuru.Items.AddRange(new object[] { "Vadesiz Hesap", "Vadeli Hesap" });
            cbHesapTuru.Location = new Point(115, 340);
            cbHesapTuru.Name = "cbHesapTuru";
            cbHesapTuru.Size = new Size(143, 29);
            cbHesapTuru.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 343);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 15;
            label8.Text = "Hesap Türü";
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(115, 399);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(143, 39);
            btnHesapAc.TabIndex = 16;
            btnHesapAc.Text = "Hesap Aç";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // lvHesaplar
            // 
            lvHesaplar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvHesaplar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lvHesaplar.FullRowSelect = true;
            lvHesaplar.Location = new Point(274, 39);
            lvHesaplar.Name = "lvHesaplar";
            lvHesaplar.Size = new Size(670, 189);
            lvHesaplar.TabIndex = 17;
            lvHesaplar.UseCompatibleStateImageBehavior = false;
            lvHesaplar.View = View.Details;
            lvHesaplar.SelectedIndexChanged += lvHesaplar_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "HesapNo";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tarih";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hesap Sahibi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Soyadı";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TCKNo";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Bakiye";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Hesap Türü";
            columnHeader8.Width = 90;
            // 
            // lvHareketler
            // 
            lvHareketler.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            lvHareketler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lvHareketler.FullRowSelect = true;
            lvHareketler.Location = new Point(274, 235);
            lvHareketler.Name = "lvHareketler";
            lvHareketler.Size = new Size(670, 134);
            lvHareketler.TabIndex = 18;
            lvHareketler.UseCompatibleStateImageBehavior = false;
            lvHareketler.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            columnHeader9.Width = 30;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "HesapNo";
            columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "İşlem Tarihi";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Tutar";
            columnHeader12.TextAlign = HorizontalAlignment.Right;
            columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "İşlem Türü";
            columnHeader13.Width = 120;
            // 
            // txtToplamBakiye
            // 
            txtToplamBakiye.Location = new Point(395, 453);
            txtToplamBakiye.Name = "txtToplamBakiye";
            txtToplamBakiye.Size = new Size(141, 29);
            txtToplamBakiye.TabIndex = 24;
            txtToplamBakiye.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(278, 454);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 23;
            label9.Text = "Bakiye";
            // 
            // txtToplamCekilen
            // 
            txtToplamCekilen.Location = new Point(395, 418);
            txtToplamCekilen.Name = "txtToplamCekilen";
            txtToplamCekilen.Size = new Size(141, 29);
            txtToplamCekilen.TabIndex = 22;
            txtToplamCekilen.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(278, 419);
            label10.Name = "label10";
            label10.Size = new Size(115, 21);
            label10.TabIndex = 21;
            label10.Text = "Toplam Çekilen";
            // 
            // txtToplamYatan
            // 
            txtToplamYatan.Location = new Point(395, 383);
            txtToplamYatan.Name = "txtToplamYatan";
            txtToplamYatan.Size = new Size(141, 29);
            txtToplamYatan.TabIndex = 20;
            txtToplamYatan.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(278, 384);
            label11.Name = "label11";
            label11.Size = new Size(102, 21);
            label11.TabIndex = 19;
            label11.Text = "Toplam Yatan";
            // 
            // btnParaYatirCek
            // 
            btnParaYatirCek.Location = new Point(628, 399);
            btnParaYatirCek.Name = "btnParaYatirCek";
            btnParaYatirCek.Size = new Size(143, 39);
            btnParaYatirCek.TabIndex = 25;
            btnParaYatirCek.Text = "Para Yatır / Çek";
            btnParaYatirCek.UseVisualStyleBackColor = true;
            btnParaYatirCek.Click += btnParaYatirCek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 495);
            Controls.Add(btnParaYatirCek);
            Controls.Add(txtToplamBakiye);
            Controls.Add(label9);
            Controls.Add(txtToplamCekilen);
            Controls.Add(label10);
            Controls.Add(txtToplamYatan);
            Controls.Add(label11);
            Controls.Add(lvHareketler);
            Controls.Add(lvHesaplar);
            Controls.Add(btnHesapAc);
            Controls.Add(label8);
            Controls.Add(cbHesapTuru);
            Controls.Add(txtBakiye);
            Controls.Add(label7);
            Controls.Add(txtTCKNo);
            Controls.Add(label6);
            Controls.Add(txtSoyadi);
            Controls.Add(label5);
            Controls.Add(txtAdi);
            Controls.Add(label4);
            Controls.Add(txtTarih);
            Controls.Add(label3);
            Controls.Add(txtHesapNo);
            Controls.Add(label2);
            Controls.Add(txtHesapId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Hesap İşlemleri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTarih;
        private Label label3;
        private TextBox txtAdi;
        private Label label4;
        private TextBox txtSoyadi;
        private Label label5;
        private TextBox txtTCKNo;
        private Label label6;
        private TextBox txtBakiye;
        private Label label7;
        private ComboBox cbHesapTuru;
        private Label label8;
        private Button btnHesapAc;
        private ListView lvHesaplar;
        private ListView lvHareketler;
        private TextBox txtToplamBakiye;
        private Label label9;
        private TextBox txtToplamCekilen;
        private Label label10;
        private TextBox txtToplamYatan;
        private Label label11;
        private Button btnParaYatirCek;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        public TextBox txtHesapId;
        public TextBox txtHesapNo;
    }
}