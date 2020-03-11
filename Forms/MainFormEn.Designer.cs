namespace CinemaProject.Forms
{
    partial class MainFormEn
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.addMovie = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuPanel.Controls.Add(this.btnMainForm);
            this.menuPanel.Controls.Add(this.btnDelMovie);
            this.menuPanel.Controls.Add(this.addMovie);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.ForeColor = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1184, 80);
            this.menuPanel.TabIndex = 0;
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.ForeColor = System.Drawing.Color.Black;
            this.btnDelMovie.Location = new System.Drawing.Point(248, 12);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(129, 54);
            this.btnDelMovie.TabIndex = 0;
            this.btnDelMovie.Text = " Delete Movie";
            this.btnDelMovie.UseVisualStyleBackColor = true;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // addMovie
            // 
            this.addMovie.ForeColor = System.Drawing.Color.Black;
            this.addMovie.Location = new System.Drawing.Point(77, 12);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(129, 54);
            this.addMovie.TabIndex = 0;
            this.addMovie.Text = " Add Movie";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentPanel.ForeColor = System.Drawing.Color.Black;
            this.contentPanel.Location = new System.Drawing.Point(0, 86);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1184, 575);
            this.contentPanel.TabIndex = 1;
            // 
            // btnMainForm
            // 
            this.btnMainForm.AccessibleDescription = " ";
            this.btnMainForm.ForeColor = System.Drawing.Color.Black;
            this.btnMainForm.Location = new System.Drawing.Point(422, 12);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(129, 54);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = " Main Form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // MainFormEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainFormEn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Management";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.Button btnMainForm;
    }
}