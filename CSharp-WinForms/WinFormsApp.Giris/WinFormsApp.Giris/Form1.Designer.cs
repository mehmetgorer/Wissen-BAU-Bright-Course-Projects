namespace WinFormsApp.Giris
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
            lblAdi = new Label();
            btnGiris = new Button();
            txtAdi = new TextBox();
            SuspendLayout();
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdi.ForeColor = Color.Maroon;
            lblAdi.Location = new Point(108, 49);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(104, 21);
            lblAdi.TabIndex = 1;
            lblAdi.Text = "Adınızı giriniz";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.Maroon;
            btnGiris.Location = new Point(229, 147);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(153, 40);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(229, 51);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(153, 23);
            txtAdi.TabIndex = 0;
            txtAdi.TextChanged += txtAdi_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAdi);
            Controls.Add(btnGiris);
            Controls.Add(lblAdi);
            Name = "Form1";
            Text = "Windows Form Penceresi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdi;
        private Button btnGiris;
        private TextBox txtAdi;
    }
}