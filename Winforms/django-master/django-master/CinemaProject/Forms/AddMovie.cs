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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) /// btn made an event (click event). by click becomes raised. 
        {
            MoviesRepository mr = new MoviesRepository();   /// here we have instantiated this in order to have access to Movierepository class
            DateTime dr = Convert.ToDateTime(dtpRelease.Value); /// here a  method and variable datettime is created. its value is from dtpicker
            string title = txtName.Text; /// a variable created and its value is form txtbox.
            string genre = txtGenre.Text; /// the same 
            mr.AddMovie(title, dr, genre); /// here those three variables are given and by clicking gets movies
            txtName.Clear();
            txtGenre.Clear();
            dtpRelease.Value = DateTime.Now;
        }
    }
}
