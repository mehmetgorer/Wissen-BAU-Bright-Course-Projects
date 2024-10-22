namespace WinFormsApp_LinqToObject
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
            lbSonuc = new ListBox();
            lbListe = new ListBox();
            SuspendLayout();
            // 
            // lbSonuc
            // 
            lbSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSonuc.FormattingEnabled = true;
            lbSonuc.ItemHeight = 21;
            lbSonuc.Location = new Point(380, 41);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(278, 361);
            lbSonuc.TabIndex = 3;
            // 
            // lbListe
            // 
            lbListe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 21;
            lbListe.Location = new Point(91, 41);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(256, 361);
            lbListe.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 456);
            Controls.Add(lbSonuc);
            Controls.Add(lbListe);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbSonuc;
        private ListBox lbListe;
    }
}