namespace MyCinema
{
    partial class Home
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
            this.lblShowingNow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMovOne = new System.Windows.Forms.PictureBox();
            this.picMovTwo = new System.Windows.Forms.PictureBox();
            this.picMovThree = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovThree)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowingNow
            // 
            this.lblShowingNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowingNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowingNow.Location = new System.Drawing.Point(-1, 18);
            this.lblShowingNow.Name = "lblShowingNow";
            this.lblShowingNow.Size = new System.Drawing.Size(776, 55);
            this.lblShowingNow.TabIndex = 0;
            this.lblShowingNow.Text = "Now Showing";
            this.lblShowingNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picMovThree);
            this.panel1.Controls.Add(this.picMovTwo);
            this.panel1.Controls.Add(this.picMovOne);
            this.panel1.Controls.Add(this.lblShowingNow);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 426);
            this.panel1.TabIndex = 1;
            // 
            // picMovOne
            // 
            this.picMovOne.Location = new System.Drawing.Point(25, 128);
            this.picMovOne.Name = "picMovOne";
            this.picMovOne.Size = new System.Drawing.Size(198, 283);
            this.picMovOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovOne.TabIndex = 2;
            this.picMovOne.TabStop = false;
            this.picMovOne.Click += new System.EventHandler(this.PicMovOne_Click);
            // 
            // picMovTwo
            // 
            this.picMovTwo.Location = new System.Drawing.Point(288, 128);
            this.picMovTwo.Name = "picMovTwo";
            this.picMovTwo.Size = new System.Drawing.Size(198, 283);
            this.picMovTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovTwo.TabIndex = 3;
            this.picMovTwo.TabStop = false;
            // 
            // picMovThree
            // 
            this.picMovThree.Location = new System.Drawing.Point(549, 128);
            this.picMovThree.Name = "picMovThree";
            this.picMovThree.Size = new System.Drawing.Size(198, 283);
            this.picMovThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovThree.TabIndex = 4;
            this.picMovThree.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "MyCinema";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMovOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMovThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowingNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMovOne;
        private System.Windows.Forms.PictureBox picMovThree;
        private System.Windows.Forms.PictureBox picMovTwo;
    }
}

