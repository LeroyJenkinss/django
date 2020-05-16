using CinemaProject.Model.Repository;
using CinemaProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject.Model.Forms
{
    public partial class MovieForm : Form
    {
        private readonly ShowTimeRepository _showTimeRepository;
        private readonly MoviesRepository _moviesRepository;
        private readonly List <ShowTimeView> MovieShowTimesList;
        private readonly MovieView MovieDetails;
        public MovieForm(int id_movie)
        {
            InitializeComponent();
            _showTimeRepository = new ShowTimeRepository();
            _moviesRepository = new MoviesRepository();
            MovieShowTimesList = _showTimeRepository.GetAllShowTimesForMovie(id_movie);
            MovieDetails = _moviesRepository.GetMovie(id_movie);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

            label1.Text = MovieDetails.Name;
            OmschrijvingMovie.Text = MovieDetails.Description;
            pictureBox1.Load(MovieDetails.Picture);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (ShowTimeView i in MovieShowTimesList)
            {
                ShowtimeList.Items.Add(i.Id_MovieShowTime+ ": " + i.ShowTime);
            }
        }

        private void ShowtimeList_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = ShowtimeList.Items[ShowtimeList.SelectedIndex].ToString();
            var GetMovieShowtimeId = selectedItem.Split(':')[0];
            var ReservationForm = new ReservationForm(int.Parse(GetMovieShowtimeId));
            ReservationForm.Show();
        }
    }
}
