namespace WinFormsApp.PiSabiti
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
            txtYaricap = new TextBox();
            btnCevre = new Button();
            btnAlan = new Button();
            btnHesapla = new Button();
            rbCevre = new RadioButton();
            rbAlan = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 131);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Yarıçap";
            // 
            // txtYaricap
            // 
            txtYaricap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtYaricap.Location = new Point(362, 128);
            txtYaricap.Name = "txtYaricap";
            txtYaricap.Size = new Size(100, 29);
            txtYaricap.TabIndex = 1;
            txtYaricap.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCevre
            // 
            btnCevre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCevre.Location = new Point(54, 307);
            btnCevre.Name = "btnCevre";
            btnCevre.Size = new Size(81, 63);
            btnCevre.TabIndex = 2;
            btnCevre.Text = "Dairenin Çevresi";
            btnCevre.UseVisualStyleBackColor = true;
            btnCevre.Visible = false;
            btnCevre.Click += btnCevre_Click;
            // 
            // btnAlan
            // 
            btnAlan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlan.Location = new Point(658, 316);
            btnAlan.Name = "btnAlan";
            btnAlan.Size = new Size(81, 63);
            btnAlan.TabIndex = 3;
            btnAlan.Text = "Dairenin Alanı";
            btnAlan.UseVisualStyleBackColor = true;
            btnAlan.Visible = false;
            btnAlan.Click += btnAlan_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(362, 199);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(100, 31);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // rbCevre
            // 
            rbCevre.AutoSize = true;
            rbCevre.Checked = true;
            rbCevre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbCevre.Location = new Point(135, 41);
            rbCevre.Name = "rbCevre";
            rbCevre.Size = new Size(142, 25);
            rbCevre.TabIndex = 5;
            rbCevre.TabStop = true;
            rbCevre.Text = "Dairenin Çevresi";
            rbCevre.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            rbAlan.AutoSize = true;
            rbAlan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbAlan.Location = new Point(528, 41);
            rbAlan.Name = "rbAlan";
            rbAlan.Size = new Size(126, 25);
            rbAlan.TabIndex = 6;
            rbAlan.Text = "Dairenin Alanı";
            rbAlan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbAlan);
            Controls.Add(rbCevre);
            Controls.Add(btnHesapla);
            Controls.Add(btnAlan);
            Controls.Add(btnCevre);
            Controls.Add(txtYaricap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtYaricap;
        private Button btnCevre;
        private Button btnAlan;
        private Button btnHesapla;
        private RadioButton rbCevre;
        private RadioButton rbAlan;
    }
}