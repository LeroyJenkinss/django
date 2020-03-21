using System;
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

        public MainForm()
        {
            InitializeComponent();
            _moviesRepository = new MoviesRepository();
        }

        private void MainView_Load(object sender, PaintEventArgs e)
        {
            var allMovies = _moviesRepository.GetAll();
            foreach (MovieView i in allMovies)
            {
                movieList.Items.Add(i.Name);
                movieList.Items.Add(i.Genre);
                
            }


        }
        private void ListMovies(object sender, EventArgs e)
        {
        }

        private void movieList_DoubleClick(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm(1);
            reservationForm.Show();
        }
    }
}
