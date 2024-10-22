namespace WinFormsApp.BankaHesaplari
{
    partial class frmMusteri
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
            lbMusteriler = new ListBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtTCKNo = new TextBox();
            label3 = new Label();
            txtSoyadi = new TextBox();
            label2 = new Label();
            txtAdi = new TextBox();
            label1 = new Label();
            txtTelefon = new TextBox();
            label4 = new Label();
            txtAdres = new TextBox();
            label5 = new Label();
            btnHesabaAktar = new Button();
            SuspendLayout();
            // 
            // lbMusteriler
            // 
            lbMusteriler.FormattingEnabled = true;
            lbMusteriler.ItemHeight = 20;
            lbMusteriler.Location = new Point(159, 18);
            lbMusteriler.Margin = new Padding(5, 6, 5, 6);
            lbMusteriler.Name = "lbMusteriler";
            lbMusteriler.Size = new Size(207, 224);
            lbMusteriler.TabIndex = 1;
            lbMusteriler.SelectedIndexChanged += lbMusteriler_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 469);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 38);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(217, 469);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 38);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(153, 469);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(60, 38);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(89, 469);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(60, 38);
            btnNew.TabIndex = 22;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtTCKNo
            // 
            txtTCKNo.Location = new Point(159, 324);
            txtTCKNo.Margin = new Padding(3, 4, 3, 4);
            txtTCKNo.MaxLength = 11;
            txtTCKNo.Name = "txtTCKNo";
            txtTCKNo.Size = new Size(207, 27);
            txtTCKNo.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 324);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 20;
            label3.Text = "TCKNo";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(159, 290);
            txtSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(207, 27);
            txtSoyadi.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 290);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 18;
            label2.Text = "Soyadı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(159, 256);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(207, 27);
            txtAdi.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 256);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 16;
            label1.Text = "Adı";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(159, 358);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(207, 27);
            txtTelefon.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 358);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 26;
            label4.Text = "Telefon";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(159, 392);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(207, 57);
            txtAdres.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 392);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 28;
            label5.Text = "Adres";
            // 
            // btnHesabaAktar
            // 
            btnHesabaAktar.Location = new Point(384, 104);
            btnHesabaAktar.Margin = new Padding(3, 4, 3, 4);
            btnHesabaAktar.Name = "btnHesabaAktar";
            btnHesabaAktar.Size = new Size(118, 61);
            btnHesabaAktar.TabIndex = 30;
            btnHesabaAktar.Text = "Hesaba Aktar  ----->";
            btnHesabaAktar.UseVisualStyleBackColor = true;
            btnHesabaAktar.Click += btnHesabaAktar_Click;
            // 
            // frmMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 520);
            Controls.Add(btnHesabaAktar);
            Controls.Add(txtAdres);
            Controls.Add(label5);
            Controls.Add(txtTelefon);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtTCKNo);
            Controls.Add(label3);
            Controls.Add(txtSoyadi);
            Controls.Add(label2);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Controls.Add(lbMusteriler);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMusteri";
            Text = "frmMusteri";
            Load += frmMusteri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbMusteriler;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnNew;
        private TextBox txtTCKNo;
        private Label label3;
        private TextBox txtSoyadi;
        private Label label2;
        private TextBox txtAdi;
        private Label label1;
        private TextBox txtTelefon;
        private Label label4;
        private TextBox txtAdres;
        private Label label5;
        private Button btnHesabaAktar;
    }
}