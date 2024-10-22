namespace WinFormsApp.LuckySeven
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Plum;
            lbl1.BorderStyle = BorderStyle.FixedSingle;
            lbl1.Font = new Font("Comic Sans MS", 54F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(168, 88);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(89, 103);
            lbl1.TabIndex = 0;
            lbl1.Text = "7";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Plum;
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Font = new Font("Comic Sans MS", 54F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(343, 88);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(89, 103);
            lbl2.TabIndex = 1;
            lbl2.Text = "7";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Plum;
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Font = new Font("Comic Sans MS", 54F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(518, 88);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(89, 103);
            lbl3.TabIndex = 2;
            lbl3.Text = "7";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.DarkRed;
            btnStart.Location = new Point(343, 243);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(89, 43);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(758, 302);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Lucky Seven";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button btnStart;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}