namespace WinFormsApp.OOP
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
            label1 = new Label();
            txtTelno = new TextBox();
            txtMesaj = new TextBox();
            label2 = new Label();
            btnAramaYap = new Button();
            btnSms = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 98);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Telefon";
            // 
            // txtTelno
            // 
            txtTelno.Location = new Point(204, 98);
            txtTelno.Name = "txtTelno";
            txtTelno.Size = new Size(183, 29);
            txtTelno.TabIndex = 1;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(204, 145);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(183, 100);
            txtMesaj.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 145);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 2;
            label2.Text = "Mesaj";
            // 
            // btnAramaYap
            // 
            btnAramaYap.Location = new Point(204, 278);
            btnAramaYap.Name = "btnAramaYap";
            btnAramaYap.Size = new Size(74, 62);
            btnAramaYap.TabIndex = 4;
            btnAramaYap.Text = "Arama Yap";
            btnAramaYap.UseVisualStyleBackColor = true;
            btnAramaYap.Click += btnAramaYap_Click;
            // 
            // btnSms
            // 
            btnSms.Location = new Point(313, 278);
            btnSms.Name = "btnSms";
            btnSms.Size = new Size(74, 62);
            btnSms.TabIndex = 5;
            btnSms.Text = "SMS Gönder";
            btnSms.UseVisualStyleBackColor = true;
            btnSms.Click += btnSms_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 504);
            Controls.Add(btnSms);
            Controls.Add(btnAramaYap);
            Controls.Add(txtMesaj);
            Controls.Add(label2);
            Controls.Add(txtTelno);
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

        private Label label1;
        private TextBox txtTelno;
        private TextBox txtMesaj;
        private Label label2;
        private Button btnAramaYap;
        private Button btnSms;
    }
}