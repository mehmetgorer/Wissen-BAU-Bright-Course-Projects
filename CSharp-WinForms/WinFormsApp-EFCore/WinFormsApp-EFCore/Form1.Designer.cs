namespace WinFormsApp_EFCore
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
            lbOgrenciler = new ListBox();
            cbSiniflar = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            label2 = new Label();
            txtTCKNo = new TextBox();
            label3 = new Label();
            txtSinifId = new TextBox();
            txtOgrenciId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 21;
            lbOgrenciler.Location = new Point(144, 76);
            lbOgrenciler.Margin = new Padding(4);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(208, 277);
            lbOgrenciler.TabIndex = 0;
            lbOgrenciler.SelectedIndexChanged += lbOgrenciler_SelectedIndexChanged;
            // 
            // cbSiniflar
            // 
            cbSiniflar.FormattingEnabled = true;
            cbSiniflar.Location = new Point(144, 40);
            cbSiniflar.Name = "cbSiniflar";
            cbSiniflar.Size = new Size(208, 29);
            cbSiniflar.TabIndex = 1;
            cbSiniflar.SelectedIndexChanged += cbSiniflar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 121);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(499, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 29);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(499, 156);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(157, 29);
            txtAge.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 156);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // txtTCKNo
            // 
            txtTCKNo.Location = new Point(499, 191);
            txtTCKNo.Name = "txtTCKNo";
            txtTCKNo.Size = new Size(157, 29);
            txtTCKNo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 191);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 6;
            label3.Text = "TCKNo";
            // 
            // txtSinifId
            // 
            txtSinifId.Location = new Point(499, 40);
            txtSinifId.Name = "txtSinifId";
            txtSinifId.Size = new Size(60, 29);
            txtSinifId.TabIndex = 8;
            txtSinifId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOgrenciId
            // 
            txtOgrenciId.Location = new Point(596, 40);
            txtOgrenciId.Name = "txtOgrenciId";
            txtOgrenciId.Size = new Size(60, 29);
            txtOgrenciId.TabIndex = 9;
            txtOgrenciId.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 9);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 10;
            label4.Text = "Sınıf Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 9);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 11;
            label5.Text = "Öğrenci Id";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(412, 264);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(55, 33);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(473, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(55, 33);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(534, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(74, 33);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(614, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 33);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 466);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtOgrenciId);
            Controls.Add(txtSinifId);
            Controls.Add(txtTCKNo);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(cbSiniflar);
            Controls.Add(lbOgrenciler);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbOgrenciler;
        private ComboBox cbSiniflar;
        private Label label1;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label2;
        private TextBox txtTCKNo;
        private Label label3;
        private TextBox txtSinifId;
        private TextBox txtOgrenciId;
        private Label label4;
        private Label label5;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
    }
}