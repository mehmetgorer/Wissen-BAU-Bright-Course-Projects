namespace WinFormsApp.Diziler
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
            lbTakimlar = new ListBox();
            SuspendLayout();
            // 
            // lbTakimlar
            // 
            lbTakimlar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbTakimlar.FormattingEnabled = true;
            lbTakimlar.ItemHeight = 25;
            lbTakimlar.Items.AddRange(new object[] { "Konyaspor", "Ankaragücü" });
            lbTakimlar.Location = new Point(220, 100);
            lbTakimlar.Name = "lbTakimlar";
            lbTakimlar.Size = new Size(145, 179);
            lbTakimlar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTakimlar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTakimlar;
    }
}