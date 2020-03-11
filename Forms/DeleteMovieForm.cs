using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaProject.Model.Repository;

namespace CinemaProject.Forms
{
    public partial class DeleteMovieForm : Form
    {
        public DeleteMovieForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mr = new MoviesRepository();
            int movieId = Convert.ToInt32(txtMovieId.Text);
            mr.DeleteMovie(movieId);
            MessageBox.Show("Movie deleted successfully!", "Movie deleted");
            txtMovieId.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMovieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
