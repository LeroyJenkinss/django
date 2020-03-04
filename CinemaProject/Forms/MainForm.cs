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

namespace CinemaProject
{
    public partial class MainForm : Form
    {
        private readonly MoviesRepository _moviesRepository;
        private ChairsRepository _chairsRepository;

        public MainForm()
        {
            InitializeComponent();
            _moviesRepository = new MoviesRepository();
            _chairsRepository = new ChairsRepository();
        }
         private void MainView_Load1(object sender, PaintEventArgs e)
        {
            var allChairs = _chairsRepository.GetAll();
            foreach (ChairView i in allChairs)
            {
                chairList.Items.Add(i.Id);
                chairList.Items.Add(i.Price);
                
            }
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
            MessageBox.Show("Faka drerrie");
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            Process.Start(sInfo);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
