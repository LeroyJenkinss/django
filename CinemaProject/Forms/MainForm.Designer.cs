namespace CinemaProject
{
    partial class MainForm
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
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.movieList = new System.Windows.Forms.ListBox();
            this.chairList = new System.Windows.Forms.ListBox();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 852F));
            this.grid.Controls.Add(this.movieList, 1, 1);
            this.grid.Controls.Add(this.chairList, 0, 1);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.RowCount = 2;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88889F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.11111F));
            this.grid.Size = new System.Drawing.Size(1081, 601);
            this.grid.TabIndex = 0;
            this.grid.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Load);
            // 
            // movieList
            // 
            this.movieList.FormattingEnabled = true;
            this.movieList.ItemHeight = 16;
            this.movieList.Location = new System.Drawing.Point(233, 69);
            this.movieList.Margin = new System.Windows.Forms.Padding(4);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(159, 116);
            this.movieList.TabIndex = 1;
            this.movieList.SelectedIndexChanged += new System.EventHandler(this.ListMovies);
            this.movieList.DoubleClick += new System.EventHandler(this.movieList_DoubleClick);
            // 
            // listBox1
            // 
            this.chairList.FormattingEnabled = true;
            this.chairList.ItemHeight = 16;
            this.chairList.Location = new System.Drawing.Point(3, 68);
            this.chairList.Name = "listBox1";
            this.chairList.Size = new System.Drawing.Size(120, 84);
            this.chairList.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 601);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.ListBox movieList;
        private System.Windows.Forms.ListBox chairList;
    }
}

