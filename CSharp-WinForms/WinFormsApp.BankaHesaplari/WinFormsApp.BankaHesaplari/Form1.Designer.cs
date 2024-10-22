namespace WinFormsApp.BankaHesaplari
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mitmHesapBilgileri = new ToolStripMenuItem();
            mitmHesapHareketleri = new ToolStripMenuItem();
            mitmMusteriler = new ToolStripMenuItem();
            mitmCikis = new ToolStripMenuItem();
            lvHesaplar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmitmYeniHesap = new ToolStripMenuItem();
            tsmitmParaYatirCek = new ToolStripMenuItem();
            txtAdaGore = new TextBox();
            rbTumHesaplar = new RadioButton();
            rbVadesiz = new RadioButton();
            rbVadeli = new RadioButton();
            lvHareketler = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            txtToplamBakiye = new TextBox();
            label9 = new Label();
            txtToplamCekilen = new TextBox();
            label10 = new Label();
            txtToplamYatan = new TextBox();
            label11 = new Label();
            btnHesapAc = new Button();
            label8 = new Label();
            cbHesapTuru = new ComboBox();
            txtBakiye = new TextBox();
            label7 = new Label();
            txtTCKNo = new TextBox();
            label6 = new Label();
            txtSoyadi = new TextBox();
            label5 = new Label();
            txtAdi = new TextBox();
            label4 = new Label();
            txtTarih = new TextBox();
            label3 = new Label();
            txtHesapNo = new TextBox();
            label2 = new Label();
            btnYeniHesap = new Button();
            btnYeniMusteri = new Button();
            txtMusteriId = new TextBox();
            btnParaYatirCek = new Button();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mitmHesapBilgileri, mitmHesapHareketleri, mitmMusteriler, mitmCikis });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1101, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mitmHesapBilgileri
            // 
            mitmHesapBilgileri.Name = "mitmHesapBilgileri";
            mitmHesapBilgileri.Size = new Size(121, 25);
            mitmHesapBilgileri.Text = "&Hesap Bilgileri";
            // 
            // mitmHesapHareketleri
            // 
            mitmHesapHareketleri.Name = "mitmHesapHareketleri";
            mitmHesapHareketleri.Size = new Size(145, 25);
            mitmHesapHareketleri.Text = "H&esap Hareketleri";
            // 
            // mitmMusteriler
            // 
            mitmMusteriler.Name = "mitmMusteriler";
            mitmMusteriler.Size = new Size(118, 25);
            mitmMusteriler.Text = "&Müşteri Takibi";
            // 
            // mitmCikis
            // 
            mitmCikis.Name = "mitmCikis";
            mitmCikis.Size = new Size(55, 25);
            mitmCikis.Text = "&Çıkış";
            mitmCikis.Click += mitmCikis_Click;
            // 
            // lvHesaplar
            // 
            lvHesaplar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader9, columnHeader7, columnHeader8 });
            lvHesaplar.ContextMenuStrip = contextMenuStrip1;
            lvHesaplar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lvHesaplar.FullRowSelect = true;
            lvHesaplar.Location = new Point(12, 73);
            lvHesaplar.Name = "lvHesaplar";
            lvHesaplar.Size = new Size(775, 175);
            lvHesaplar.TabIndex = 18;
            lvHesaplar.UseCompatibleStateImageBehavior = false;
            lvHesaplar.View = View.Details;
            lvHesaplar.SelectedIndexChanged += lvHesaplar_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 1;
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
            columnHeader4.Text = "Hesap Sahibi Adı";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Soyadı";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TCKimlikNo";
            columnHeader6.Width = 110;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Telefon";
            columnHeader9.Width = 110;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Bakiye";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Hesap Türü";
            columnHeader8.Width = 120;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmitmYeniHesap, tsmitmParaYatirCek });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 48);
            contextMenuStrip1.Text = "Hesap Kısayol Menüsü";
            // 
            // tsmitmYeniHesap
            // 
            tsmitmYeniHesap.Name = "tsmitmYeniHesap";
            tsmitmYeniHesap.Size = new Size(148, 22);
            tsmitmYeniHesap.Text = "Yeni Hesap";
            tsmitmYeniHesap.Click += tsmitmYeniHesap_Click;
            // 
            // tsmitmParaYatirCek
            // 
            tsmitmParaYatirCek.Name = "tsmitmParaYatirCek";
            tsmitmParaYatirCek.Size = new Size(148, 22);
            tsmitmParaYatirCek.Text = "Para Yatır/Çek";
            tsmitmParaYatirCek.Click += tsmitmParaYatirCek_Click;
            // 
            // txtAdaGore
            // 
            txtAdaGore.Location = new Point(204, 46);
            txtAdaGore.Name = "txtAdaGore";
            txtAdaGore.Size = new Size(239, 23);
            txtAdaGore.TabIndex = 19;
            txtAdaGore.TextChanged += txtAdaGore_TextChanged;
            // 
            // rbTumHesaplar
            // 
            rbTumHesaplar.AutoSize = true;
            rbTumHesaplar.Checked = true;
            rbTumHesaplar.Location = new Point(473, 47);
            rbTumHesaplar.Name = "rbTumHesaplar";
            rbTumHesaplar.Size = new Size(98, 19);
            rbTumHesaplar.TabIndex = 20;
            rbTumHesaplar.TabStop = true;
            rbTumHesaplar.Text = "Tüm Hesaplar";
            rbTumHesaplar.UseVisualStyleBackColor = true;
            rbTumHesaplar.CheckedChanged += rbTumHesaplar_CheckedChanged;
            // 
            // rbVadesiz
            // 
            rbVadesiz.AutoSize = true;
            rbVadesiz.Location = new Point(572, 47);
            rbVadesiz.Name = "rbVadesiz";
            rbVadesiz.Size = new Size(112, 19);
            rbVadesiz.TabIndex = 21;
            rbVadesiz.Text = "Vadesiz Hesaplar";
            rbVadesiz.UseVisualStyleBackColor = true;
            rbVadesiz.CheckedChanged += rbVadesiz_CheckedChanged;
            // 
            // rbVadeli
            // 
            rbVadeli.AutoSize = true;
            rbVadeli.Location = new Point(686, 47);
            rbVadeli.Name = "rbVadeli";
            rbVadeli.Size = new Size(105, 19);
            rbVadeli.TabIndex = 22;
            rbVadeli.Text = "Vadeli Hesaplar";
            rbVadeli.UseVisualStyleBackColor = true;
            rbVadeli.CheckedChanged += rbVadeli_CheckedChanged;
            // 
            // lvHareketler
            // 
            lvHareketler.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader17, columnHeader18 });
            lvHareketler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lvHareketler.FullRowSelect = true;
            lvHareketler.Location = new Point(12, 254);
            lvHareketler.Name = "lvHareketler";
            lvHareketler.Size = new Size(775, 132);
            lvHareketler.TabIndex = 23;
            lvHareketler.UseCompatibleStateImageBehavior = false;
            lvHareketler.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "ID";
            columnHeader10.Width = 1;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "HesapNo";
            columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Tarih";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Hesap Sahibi Adı";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Soyadı";
            columnHeader14.Width = 120;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Tutar";
            columnHeader17.TextAlign = HorizontalAlignment.Right;
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "İşlem Türü";
            columnHeader18.Width = 120;
            // 
            // txtToplamBakiye
            // 
            txtToplamBakiye.Location = new Point(130, 456);
            txtToplamBakiye.Name = "txtToplamBakiye";
            txtToplamBakiye.Size = new Size(141, 23);
            txtToplamBakiye.TabIndex = 30;
            txtToplamBakiye.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 457);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 29;
            label9.Text = "Bakiye";
            // 
            // txtToplamCekilen
            // 
            txtToplamCekilen.Location = new Point(130, 424);
            txtToplamCekilen.Name = "txtToplamCekilen";
            txtToplamCekilen.Size = new Size(141, 23);
            txtToplamCekilen.TabIndex = 28;
            txtToplamCekilen.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 425);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 27;
            label10.Text = "Toplam Çekilen";
            // 
            // txtToplamYatan
            // 
            txtToplamYatan.Location = new Point(130, 392);
            txtToplamYatan.Name = "txtToplamYatan";
            txtToplamYatan.Size = new Size(141, 23);
            txtToplamYatan.TabIndex = 26;
            txtToplamYatan.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 393);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 25;
            label11.Text = "Toplam Yatan";
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(889, 377);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(143, 39);
            btnHesapAc.TabIndex = 45;
            btnHesapAc.Text = "Hesap Aç";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(799, 338);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 44;
            label8.Text = "Hesap Türü";
            // 
            // cbHesapTuru
            // 
            cbHesapTuru.FormattingEnabled = true;
            cbHesapTuru.Items.AddRange(new object[] { "Vadesiz Hesap", "Vadeli Hesap" });
            cbHesapTuru.Location = new Point(889, 335);
            cbHesapTuru.Name = "cbHesapTuru";
            cbHesapTuru.Size = new Size(143, 23);
            cbHesapTuru.TabIndex = 43;
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(891, 284);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(141, 23);
            txtBakiye.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(799, 285);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 41;
            label7.Text = "Bakiye";
            // 
            // txtTCKNo
            // 
            txtTCKNo.Location = new Point(891, 229);
            txtTCKNo.MaxLength = 11;
            txtTCKNo.Name = "txtTCKNo";
            txtTCKNo.ReadOnly = true;
            txtTCKNo.Size = new Size(141, 23);
            txtTCKNo.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(799, 230);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 39;
            label6.Text = "TCKimlikNo";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(891, 202);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.ReadOnly = true;
            txtSoyadi.Size = new Size(141, 23);
            txtSoyadi.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(799, 203);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 37;
            label5.Text = "Soyadı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(891, 175);
            txtAdi.Name = "txtAdi";
            txtAdi.ReadOnly = true;
            txtAdi.Size = new Size(141, 23);
            txtAdi.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(799, 176);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 35;
            label4.Text = "Müşteri Adı";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(891, 120);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(141, 23);
            txtTarih.TabIndex = 34;
            txtTarih.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(799, 123);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 33;
            label3.Text = "Açılış Tarihi";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(891, 94);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.ReadOnly = true;
            txtHesapNo.Size = new Size(141, 23);
            txtHesapNo.TabIndex = 32;
            txtHesapNo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(799, 97);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 31;
            label2.Text = "Hesap No";
            // 
            // btnYeniHesap
            // 
            btnYeniHesap.Location = new Point(889, 37);
            btnYeniHesap.Name = "btnYeniHesap";
            btnYeniHesap.Size = new Size(143, 39);
            btnYeniHesap.TabIndex = 46;
            btnYeniHesap.Text = "Yeni Hesap";
            btnYeniHesap.UseVisualStyleBackColor = true;
            btnYeniHesap.Click += btnYeniHesap_Click;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniMusteri.Location = new Point(1037, 173);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(60, 52);
            btnYeniMusteri.TabIndex = 47;
            btnYeniMusteri.Text = "Yeni Müşteri";
            btnYeniMusteri.UseVisualStyleBackColor = true;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // txtMusteriId
            // 
            txtMusteriId.Location = new Point(799, 150);
            txtMusteriId.Name = "txtMusteriId";
            txtMusteriId.ReadOnly = true;
            txtMusteriId.Size = new Size(38, 23);
            txtMusteriId.TabIndex = 48;
            // 
            // btnParaYatirCek
            // 
            btnParaYatirCek.Location = new Point(515, 424);
            btnParaYatirCek.Name = "btnParaYatirCek";
            btnParaYatirCek.Size = new Size(143, 39);
            btnParaYatirCek.TabIndex = 49;
            btnParaYatirCek.Text = "Para Yatır/Çek";
            btnParaYatirCek.UseVisualStyleBackColor = true;
            btnParaYatirCek.Click += btnParaYatirCek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1101, 513);
            Controls.Add(btnParaYatirCek);
            Controls.Add(txtMusteriId);
            Controls.Add(btnYeniMusteri);
            Controls.Add(btnYeniHesap);
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
            Controls.Add(txtToplamBakiye);
            Controls.Add(label9);
            Controls.Add(txtToplamCekilen);
            Controls.Add(label10);
            Controls.Add(txtToplamYatan);
            Controls.Add(label11);
            Controls.Add(lvHareketler);
            Controls.Add(rbVadeli);
            Controls.Add(rbVadesiz);
            Controls.Add(rbTumHesaplar);
            Controls.Add(txtAdaGore);
            Controls.Add(lvHesaplar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mitmHesapBilgileri;
        private ToolStripMenuItem mitmHesapHareketleri;
        private ToolStripMenuItem mitmMusteriler;
        private ToolStripMenuItem mitmCikis;
        private ListView lvHesaplar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox txtAdaGore;
        private RadioButton rbTumHesaplar;
        private RadioButton rbVadesiz;
        private RadioButton rbVadeli;
        private ListView lvHareketler;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private TextBox txtToplamBakiye;
        private Label label9;
        private TextBox txtToplamCekilen;
        private Label label10;
        private TextBox txtToplamYatan;
        private Label label11;
        private Button btnHesapAc;
        private Label label8;
        private ComboBox cbHesapTuru;
        private TextBox txtBakiye;
        private Label label7;
        private TextBox txtTCKNo;
        private Label label6;
        private TextBox txtSoyadi;
        private Label label5;
        private TextBox txtAdi;
        private Label label4;
        private TextBox txtTarih;
        private Label label3;
        public TextBox txtHesapNo;
        private Label label2;
        private Button btnYeniHesap;
        private Button btnYeniMusteri;
        private TextBox txtMusteriId;
        private Button btnParaYatirCek;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmitmYeniHesap;
        private ToolStripMenuItem tsmitmParaYatirCek;
    }
}