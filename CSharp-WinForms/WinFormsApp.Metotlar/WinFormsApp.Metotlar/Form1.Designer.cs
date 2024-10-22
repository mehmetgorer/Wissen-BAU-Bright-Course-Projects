namespace WinFormsApp.Metotlar
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
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            label2 = new Label();
            txtTelefonu = new TextBox();
            label3 = new Label();
            txtAdresi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnKaydet = new Button();
            btnDegistir = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 76);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(252, 76);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(147, 29);
            txtAdi.TabIndex = 1;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(252, 111);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(147, 29);
            txtSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 111);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyadı";
            // 
            // txtTelefonu
            // 
            txtTelefonu.Location = new Point(252, 146);
            txtTelefonu.Name = "txtTelefonu";
            txtTelefonu.Size = new Size(147, 29);
            txtTelefonu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 146);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 4;
            label3.Text = "Telefonu";
            // 
            // txtAdresi
            // 
            txtAdresi.Location = new Point(252, 181);
            txtAdresi.Multiline = true;
            txtAdresi.Name = "txtAdresi";
            txtAdresi.Size = new Size(147, 83);
            txtAdresi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 181);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 6;
            label4.Text = "Adresi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 28);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 8;
            label5.Text = "Öğrenci Kayıt";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(168, 284);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(73, 33);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(247, 284);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(73, 33);
            btnDegistir.TabIndex = 10;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(326, 284);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(73, 33);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 414);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnKaydet);
            Controls.Add(label5);
            Controls.Add(txtAdresi);
            Controls.Add(label4);
            Controls.Add(txtTelefonu);
            Controls.Add(label3);
            Controls.Add(txtSoyadi);
            Controls.Add(label2);
            Controls.Add(txtAdi);
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
        private TextBox txtSoyadi;
        private Label label2;
        private TextBox txtTelefonu;
        private Label label3;
        private TextBox txtAdresi;
        private Label label4;
        private Label label5;
        private Button btnKaydet;
        private Button btnDegistir;
        private Button btnSil;
        public TextBox txtAdi;
    }
}