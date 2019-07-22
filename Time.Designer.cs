namespace MyCinema
{
    partial class Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time));
            this.SelectTimePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BackToMovieSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ThirdTime = new System.Windows.Forms.Button();
            this.SecondTime = new System.Windows.Forms.Button();
            this.FirstTime = new System.Windows.Forms.Button();
            this.CheckPanel = new System.Windows.Forms.Panel();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSold = new System.Windows.Forms.Button();
            this.SelectedSeat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowTimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Voucher = new System.Windows.Forms.Label();
            this.btnBackDash = new System.Windows.Forms.Button();
            this.SelectTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CheckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectTimePanel
            // 
            this.SelectTimePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectTimePanel.Controls.Add(this.pictureBox1);
            this.SelectTimePanel.Controls.Add(this.pictureBox2);
            this.SelectTimePanel.Controls.Add(this.BackToMovieSelect);
            this.SelectTimePanel.Controls.Add(this.label6);
            this.SelectTimePanel.Controls.Add(this.dateTimePicker1);
            this.SelectTimePanel.Controls.Add(this.ThirdTime);
            this.SelectTimePanel.Controls.Add(this.SecondTime);
            this.SelectTimePanel.Controls.Add(this.FirstTime);
            this.SelectTimePanel.Location = new System.Drawing.Point(12, 38);
            this.SelectTimePanel.Name = "SelectTimePanel";
            this.SelectTimePanel.Size = new System.Drawing.Size(287, 400);
            this.SelectTimePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-29, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(254, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // BackToMovieSelect
            // 
            this.BackToMovieSelect.Location = new System.Drawing.Point(9, 7);
            this.BackToMovieSelect.Name = "BackToMovieSelect";
            this.BackToMovieSelect.Size = new System.Drawing.Size(75, 23);
            this.BackToMovieSelect.TabIndex = 10;
            this.BackToMovieSelect.Text = "Back";
            this.BackToMovieSelect.UseVisualStyleBackColor = true;
            this.BackToMovieSelect.Click += new System.EventHandler(this.BackToMovieSelect_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select Date and Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // ThirdTime
            // 
            this.ThirdTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ThirdTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdTime.Location = new System.Drawing.Point(49, 289);
            this.ThirdTime.Name = "ThirdTime";
            this.ThirdTime.Size = new System.Drawing.Size(183, 50);
            this.ThirdTime.TabIndex = 7;
            this.ThirdTime.Text = "6:30PM";
            this.ThirdTime.UseVisualStyleBackColor = true;
            this.ThirdTime.Click += new System.EventHandler(this.ThirdTime_Click);
            // 
            // SecondTime
            // 
            this.SecondTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SecondTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondTime.Location = new System.Drawing.Point(49, 213);
            this.SecondTime.Name = "SecondTime";
            this.SecondTime.Size = new System.Drawing.Size(183, 50);
            this.SecondTime.TabIndex = 6;
            this.SecondTime.Text = "12:30 PM";
            this.SecondTime.UseVisualStyleBackColor = true;
            this.SecondTime.Click += new System.EventHandler(this.SecondTime_Click);
            // 
            // FirstTime
            // 
            this.FirstTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTime.Location = new System.Drawing.Point(49, 133);
            this.FirstTime.Name = "FirstTime";
            this.FirstTime.Size = new System.Drawing.Size(183, 50);
            this.FirstTime.TabIndex = 5;
            this.FirstTime.Text = "9:30 AM";
            this.FirstTime.UseVisualStyleBackColor = true;
            this.FirstTime.Click += new System.EventHandler(this.FirstTime_Click);
            // 
            // CheckPanel
            // 
            this.CheckPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CheckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckPanel.Controls.Add(this.TotalPrice);
            this.CheckPanel.Controls.Add(this.label11);
            this.CheckPanel.Controls.Add(this.btnSold);
            this.CheckPanel.Controls.Add(this.SelectedSeat);
            this.CheckPanel.Controls.Add(this.label10);
            this.CheckPanel.Controls.Add(this.ShowTimeLabel);
            this.CheckPanel.Controls.Add(this.label9);
            this.CheckPanel.Controls.Add(this.MovieLabel);
            this.CheckPanel.Controls.Add(this.label7);
            this.CheckPanel.Controls.Add(this.ShowDateLabel);
            this.CheckPanel.Controls.Add(this.label5);
            this.CheckPanel.Controls.Add(this.Voucher);
            this.CheckPanel.Location = new System.Drawing.Point(305, 38);
            this.CheckPanel.Name = "CheckPanel";
            this.CheckPanel.Size = new System.Drawing.Size(463, 400);
            this.CheckPanel.TabIndex = 3;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(176, 248);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(49, 25);
            this.TotalPrice.TabIndex = 11;
            this.TotalPrice.Text = "0Ks";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total";
            // 
            // btnSold
            // 
            this.btnSold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSold.Location = new System.Drawing.Point(365, 355);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(89, 40);
            this.btnSold.TabIndex = 9;
            this.btnSold.Text = "Buy";
            this.btnSold.UseVisualStyleBackColor = true;
            // 
            // SelectedSeat
            // 
            this.SelectedSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectedSeat.AutoSize = true;
            this.SelectedSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedSeat.Location = new System.Drawing.Point(176, 203);
            this.SelectedSeat.Name = "SelectedSeat";
            this.SelectedSeat.Size = new System.Drawing.Size(135, 25);
            this.SelectedSeat.TabIndex = 8;
            this.SelectedSeat.Text = "Not Selected";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Seat";
            // 
            // ShowTimeLabel
            // 
            this.ShowTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowTimeLabel.AutoSize = true;
            this.ShowTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTimeLabel.Location = new System.Drawing.Point(176, 132);
            this.ShowTimeLabel.Name = "ShowTimeLabel";
            this.ShowTimeLabel.Size = new System.Drawing.Size(135, 25);
            this.ShowTimeLabel.TabIndex = 6;
            this.ShowTimeLabel.Text = "Not Selected";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Show Time";
            // 
            // MovieLabel
            // 
            this.MovieLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(176, 169);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(135, 25);
            this.MovieLabel.TabIndex = 4;
            this.MovieLabel.Text = "Not Selected";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Movie";
            // 
            // ShowDateLabel
            // 
            this.ShowDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowDateLabel.AutoSize = true;
            this.ShowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDateLabel.Location = new System.Drawing.Point(176, 92);
            this.ShowDateLabel.Name = "ShowDateLabel";
            this.ShowDateLabel.Size = new System.Drawing.Size(135, 25);
            this.ShowDateLabel.TabIndex = 2;
            this.ShowDateLabel.Text = "Not Selected";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Show Date";
            // 
            // Voucher
            // 
            this.Voucher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Voucher.AutoSize = true;
            this.Voucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher.Location = new System.Drawing.Point(195, 6);
            this.Voucher.Name = "Voucher";
            this.Voucher.Size = new System.Drawing.Size(70, 25);
            this.Voucher.TabIndex = 0;
            this.Voucher.Text = "Ticket";
            // 
            // btnBackDash
            // 
            this.btnBackDash.Location = new System.Drawing.Point(693, 9);
            this.btnBackDash.Name = "btnBackDash";
            this.btnBackDash.Size = new System.Drawing.Size(75, 23);
            this.btnBackDash.TabIndex = 89;
            this.btnBackDash.Text = "Dashboard";
            this.btnBackDash.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnBackDash);
            this.Controls.Add(this.CheckPanel);
            this.Controls.Add(this.SelectTimePanel);
            this.Name = "Time";
            this.Text = "Time";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Time_Load);
            this.SelectTimePanel.ResumeLayout(false);
            this.SelectTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CheckPanel.ResumeLayout(false);
            this.CheckPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectTimePanel;
        private System.Windows.Forms.Button BackToMovieSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ThirdTime;
        private System.Windows.Forms.Button SecondTime;
        private System.Windows.Forms.Button FirstTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CheckPanel;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Label SelectedSeat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ShowTimeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ShowDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Voucher;
        private System.Windows.Forms.Button btnBackDash;
    }
}