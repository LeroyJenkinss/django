namespace CinemaProject.Model.Forms
{
    partial class MovieForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OmschrijvingMovie = new System.Windows.Forms.RichTextBox();
            this.ShowtimeList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(323, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // OmschrijvingMovie
            // 
            this.OmschrijvingMovie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OmschrijvingMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OmschrijvingMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OmschrijvingMovie.Location = new System.Drawing.Point(503, 207);
            this.OmschrijvingMovie.Name = "OmschrijvingMovie";
            this.OmschrijvingMovie.Size = new System.Drawing.Size(268, 105);
            this.OmschrijvingMovie.TabIndex = 2;
            this.OmschrijvingMovie.Text = "";
            // 
            // ShowtimeList
            // 
            this.ShowtimeList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowtimeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowtimeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowtimeList.FormattingEnabled = true;
            this.ShowtimeList.Location = new System.Drawing.Point(323, 207);
            this.ShowtimeList.Name = "ShowtimeList";
            this.ShowtimeList.Size = new System.Drawing.Size(163, 221);
            this.ShowtimeList.TabIndex = 3;
            this.ShowtimeList.SelectedIndexChanged += new System.EventHandler(this.ShowtimeList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(500, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Informatie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(323, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show times";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowtimeList);
            this.Controls.Add(this.OmschrijvingMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OmschrijvingMovie;
        private System.Windows.Forms.ListBox ShowtimeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}