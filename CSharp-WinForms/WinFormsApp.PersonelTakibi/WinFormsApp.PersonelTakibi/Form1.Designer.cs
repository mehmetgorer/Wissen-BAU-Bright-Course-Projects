namespace WinFormsApp.PersonelTakibi
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
            btnListe = new Button();
            lbListe = new ListBox();
            label1 = new Label();
            txtId = new TextBox();
            txtAdi = new TextBox();
            label2 = new Label();
            txtSoyadi = new TextBox();
            label3 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnYeni = new Button();
            btnDegistir = new Button();
            btnBul = new Button();
            SuspendLayout();
            // 
            // btnListe
            // 
            btnListe.Location = new Point(228, 18);
            btnListe.Name = "btnListe";
            btnListe.Size = new Size(164, 41);
            btnListe.TabIndex = 0;
            btnListe.Text = "Personel Listesi";
            btnListe.UseVisualStyleBackColor = true;
            btnListe.Visible = false;
            btnListe.Click += btnListe_Click;
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 21;
            lbListe.Location = new Point(207, 77);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(204, 193);
            lbListe.TabIndex = 1;
            lbListe.SelectedIndexChanged += lbListe_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 288);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(259, 288);
            txtId.Name = "txtId";
            txtId.Size = new Size(133, 29);
            txtId.TabIndex = 3;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(259, 323);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(133, 29);
            txtAdi.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 323);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 4;
            label2.Text = "Adı";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(259, 358);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(133, 29);
            txtSoyadi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 358);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 6;
            label3.Text = "Soyadı";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(225, 402);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(57, 30);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(366, 402);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(57, 30);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(167, 402);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(57, 30);
            btnYeni.TabIndex = 10;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(283, 402);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(82, 30);
            btnDegistir.TabIndex = 11;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(398, 288);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(57, 30);
            btnBul.TabIndex = 12;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 488);
            Controls.Add(btnBul);
            Controls.Add(btnDegistir);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyadi);
            Controls.Add(label3);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(lbListe);
            Controls.Add(btnListe);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Personel Takibi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListe;
        private ListBox lbListe;
        private Label label1;
        private TextBox txtId;
        private TextBox txtAdi;
        private Label label2;
        private TextBox txtSoyadi;
        private Label label3;
        private Button btnEkle;
        private Button btnSil;
        private Button btnYeni;
        private Button btnDegistir;
        private Button btnBul;
    }
}