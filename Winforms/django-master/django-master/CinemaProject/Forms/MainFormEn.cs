using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaProject.Forms;

namespace CinemaProject.Forms
{
    public partial class MainFormEn : Form
    {
        public MainFormEn()
        {
            InitializeComponent();
        }
        void Navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            AddMovie frm = new AddMovie();
            Navigation(frm, contentPanel);
        }


        private void btnDelMovie_Click(object sender, EventArgs e)
        {
            DeleteMovieForm frm = new DeleteMovieForm();
            Navigation(frm, contentPanel);
        }

        private void btnMainMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            Navigation(frm, contentPanel);
        }
    }
}
