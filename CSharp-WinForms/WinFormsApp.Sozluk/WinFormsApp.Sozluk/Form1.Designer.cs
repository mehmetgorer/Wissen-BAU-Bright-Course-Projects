namespace WinFormsApp.Sozluk
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
            txtTurkce = new TextBox();
            txtIngilizce = new TextBox();
            label2 = new Label();
            btnBul = new Button();
            rbTurkToIng = new RadioButton();
            rbIngToTurk = new RadioButton();
            lbKelimeler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 113);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Türkçe";
            // 
            // txtTurkce
            // 
            txtTurkce.Location = new Point(290, 113);
            txtTurkce.Name = "txtTurkce";
            txtTurkce.Size = new Size(138, 29);
            txtTurkce.TabIndex = 1;
            txtTurkce.TextChanged += txtTurkce_TextChanged;
            // 
            // txtIngilizce
            // 
            txtIngilizce.Location = new Point(290, 179);
            txtIngilizce.Name = "txtIngilizce";
            txtIngilizce.Size = new Size(138, 29);
            txtIngilizce.TabIndex = 3;
            txtIngilizce.TextChanged += txtIngilizce_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 179);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 2;
            label2.Text = "İngilizce";
            // 
            // btnBul
            // 
            btnBul.Location = new Point(439, 147);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(60, 32);
            btnBul.TabIndex = 4;
            btnBul.Text = "BUL";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // rbTurkToIng
            // 
            rbTurkToIng.AutoSize = true;
            rbTurkToIng.Checked = true;
            rbTurkToIng.Location = new Point(86, 43);
            rbTurkToIng.Name = "rbTurkToIng";
            rbTurkToIng.Size = new Size(176, 25);
            rbTurkToIng.TabIndex = 5;
            rbTurkToIng.TabStop = true;
            rbTurkToIng.Text = "Türkçeden İngilizceye";
            rbTurkToIng.UseVisualStyleBackColor = true;
            rbTurkToIng.CheckedChanged += rbTurkToIng_CheckedChanged;
            // 
            // rbIngToTurk
            // 
            rbIngToTurk.AutoSize = true;
            rbIngToTurk.Location = new Point(342, 43);
            rbIngToTurk.Name = "rbIngToTurk";
            rbIngToTurk.Size = new Size(176, 25);
            rbIngToTurk.TabIndex = 6;
            rbIngToTurk.Text = "İngilizceden Türkçeye";
            rbIngToTurk.UseVisualStyleBackColor = true;
            rbIngToTurk.CheckedChanged += rbIngToTurk_CheckedChanged;
            // 
            // lbKelimeler
            // 
            lbKelimeler.FormattingEnabled = true;
            lbKelimeler.ItemHeight = 21;
            lbKelimeler.Location = new Point(38, 87);
            lbKelimeler.Name = "lbKelimeler";
            lbKelimeler.Size = new Size(148, 214);
            lbKelimeler.TabIndex = 7;
            lbKelimeler.SelectedIndexChanged += lbKelimeler_SelectedIndexChanged;
            lbKelimeler.DoubleClick += lbKelimeler_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(594, 392);
            Controls.Add(lbKelimeler);
            Controls.Add(rbIngToTurk);
            Controls.Add(rbTurkToIng);
            Controls.Add(btnBul);
            Controls.Add(txtIngilizce);
            Controls.Add(label2);
            Controls.Add(txtTurkce);
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
        private TextBox txtTurkce;
        private TextBox txtIngilizce;
        private Label label2;
        private Button btnBul;
        private RadioButton rbTurkToIng;
        private RadioButton rbIngToTurk;
        private ListBox lbKelimeler;
    }
}