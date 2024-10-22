namespace WinFormsApp.Koleksiyonlar
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
            lbListe1 = new ListBox();
            lbListe2 = new ListBox();
            lbListe3 = new ListBox();
            SuspendLayout();
            // 
            // lbListe1
            // 
            lbListe1.FormattingEnabled = true;
            lbListe1.ItemHeight = 21;
            lbListe1.Location = new Point(37, 131);
            lbListe1.Name = "lbListe1";
            lbListe1.Size = new Size(120, 193);
            lbListe1.TabIndex = 0;
            // 
            // lbListe2
            // 
            lbListe2.FormattingEnabled = true;
            lbListe2.ItemHeight = 21;
            lbListe2.Location = new Point(191, 131);
            lbListe2.Name = "lbListe2";
            lbListe2.Size = new Size(120, 193);
            lbListe2.TabIndex = 1;
            // 
            // lbListe3
            // 
            lbListe3.FormattingEnabled = true;
            lbListe3.ItemHeight = 21;
            lbListe3.Location = new Point(345, 131);
            lbListe3.Name = "lbListe3";
            lbListe3.Size = new Size(120, 193);
            lbListe3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 500);
            Controls.Add(lbListe3);
            Controls.Add(lbListe2);
            Controls.Add(lbListe1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbListe1;
        private ListBox lbListe2;
        private ListBox lbListe3;
    }
}