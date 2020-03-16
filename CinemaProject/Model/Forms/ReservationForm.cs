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
    public partial class ReservationForm : Form
    {
        private readonly ShowTimeRepository _showTimeRepository;

        public ReservationForm()
        {
            InitializeComponent();
            _showTimeRepository = new ShowTimeRepository();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            var allShowtimes = _showTimeRepository.GetAll();
            person1.Visible = false;
            person2.Visible = false;

            foreach (ShowTimeView i in allShowtimes)
            {
                
                

            }
            var maxPeople = new string[] { "1", "2", "3", "4", "5" }; 
            foreach (var item in maxPeople) 
            {
                numberOfPeople.Items.Add(item);  
                    }
            //numberOfPeople.Items.Add("2");
            //numberOfPeople.Items.Add("3");
            //numberOfPeople.Items.Add("4");
            //numberOfPeople.Items.Add("5");
            //numberOfPeople.Text = "Number of people ...";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
         
        private void numberOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var reservationQuantity = int.Parse(numberOfPeople.Text);
            var counter = 0;
            while (counter <= reservationQuantity)
            {
                switch (counter)
                {
                    case 1:
                        person1.Visible = true;
                        break;
                    case 2:
                        person2.Visible = true;
                        break;
                    case 3:
                        person2.Visible = true;
                        break;
                    case 4:
                        person2.Visible = true;
                        break;
                    case 5:
                        person2.Visible = true;
                        break;
                    default:
                        break;
                }
                counter += 1;
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
