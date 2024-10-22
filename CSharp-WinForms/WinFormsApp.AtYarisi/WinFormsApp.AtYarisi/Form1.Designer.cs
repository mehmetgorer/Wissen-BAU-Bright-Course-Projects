namespace WinFormsApp.AtYarisi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            pb3 = new PictureBox();
            pb4 = new PictureBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(44, 25);
            pb1.Name = "pb1";
            pb1.Size = new Size(114, 66);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 0;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Image = (Image)resources.GetObject("pb2.Image");
            pb2.Location = new Point(44, 114);
            pb2.Name = "pb2";
            pb2.Size = new Size(114, 66);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 1;
            pb2.TabStop = false;
            // 
            // pb3
            // 
            pb3.Image = (Image)resources.GetObject("pb3.Image");
            pb3.Location = new Point(44, 203);
            pb3.Name = "pb3";
            pb3.Size = new Size(114, 66);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.TabIndex = 2;
            pb3.TabStop = false;
            // 
            // pb4
            // 
            pb4.Image = (Image)resources.GetObject("pb4.Image");
            pb4.Location = new Point(44, 292);
            pb4.Name = "pb4";
            pb4.Size = new Size(114, 66);
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.TabIndex = 3;
            pb4.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(44, 389);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 31);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(pb4);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Name = "Form1";
            Text = "At Yarışları";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb1;
        private PictureBox pb2;
        private PictureBox pb3;
        private PictureBox pb4;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}