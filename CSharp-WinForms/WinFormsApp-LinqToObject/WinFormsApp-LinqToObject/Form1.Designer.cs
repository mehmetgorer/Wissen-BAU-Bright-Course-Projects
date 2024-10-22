namespace WinFormsApp_LinqToObject
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
            lbListe = new ListBox();
            lbSonuc = new ListBox();
            SuspendLayout();
            // 
            // lbListe
            // 
            lbListe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 21;
            lbListe.Location = new Point(149, 88);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(130, 172);
            lbListe.TabIndex = 0;
            // 
            // lbSonuc
            // 
            lbSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSonuc.FormattingEnabled = true;
            lbSonuc.ItemHeight = 21;
            lbSonuc.Location = new Point(353, 88);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(130, 172);
            lbSonuc.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbSonuc);
            Controls.Add(lbListe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbListe;
        private ListBox lbSonuc;
    }
}