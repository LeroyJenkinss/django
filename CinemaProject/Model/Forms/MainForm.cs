﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaProject.Model.Repository;
using CinemaProject.View;
using CinemaProject.Model.Forms;

namespace CinemaProject
{
    public partial class MainForm : Form
    {
        private readonly MoviesRepository _moviesRepository;
        private bool movieGridViewIsLoaded = false;

        public MainForm()
        {

            InitializeComponent();
          //  {

           //     this.pictureBox1 = new System.Windows.Forms.PictureBox();
           //     this.label1 = new System.Windows.Forms.Label();
                //this.OmschrijvingMovie = new System.Windows.Forms.RichTextBox();;
              _moviesRepository = new MoviesRepository();
//}
        }

        private void MainView_Load(object sender, PaintEventArgs e)
        {
            if (!movieGridViewIsLoaded)
            {
                movieGridView.Columns.Add("ID", "");
                movieGridView.Columns.Add("MovieName", "Name");
                var ImageResizeCell = new DataGridViewImageColumn(false);
               

                movieGridView.Columns.Add(ImageResizeCell);
                movieGridView.Columns.Add("Omschrijving","Omschrijving");

                var allMovies = _moviesRepository.GetAll();
                foreach (MovieView i in allMovies)
                {
                    System.Net.WebRequest request =
                    System.Net.WebRequest.Create(i.Picture);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream = response.GetResponseStream();
                    Bitmap picture = new Bitmap(responseStream);
                    Image imageResize = picture;
                    Bitmap picture2Size = new Bitmap(imageResize, new Size(175, 250));

                    movieGridView.Rows.Add(new object[] { i.Id_Movie, i.Name, picture2Size, i.Description});
                   

                }
                movieGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                movieGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                movieGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders) ;
                movieGridViewIsLoaded = true;
            }
            
        }
      

        

        

        private void MovieGridView_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = movieGridView.CurrentRow.AccessibilityObject.Value;
            var GetMovieId = selectedItem.Split(';')[0];
            var movieForm = new MovieForm(int.Parse(GetMovieId));
            movieForm.Location = this.Location;
            movieForm.FormClosing += delegate { this.Show();  };
            movieForm.Show();
            this.Hide();
        }
    }
}
