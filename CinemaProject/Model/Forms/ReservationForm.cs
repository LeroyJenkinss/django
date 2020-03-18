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
            selectRow.Visible = false;
            SelectSeatNr.Visible = false;
            person1.Visible = false;
            person2.Visible = false;
            person3.Visible = false;
            person4.Visible = false;
            person5.Visible = false;
            person11.Visible = false;
            person22.Visible = false;
            person33.Visible = false;
            person44.Visible = false;
            person55.Visible = false;
            seat1.Visible = false;
            seat2.Visible = false;
            seat3.Visible = false;
            seat4.Visible = false;
            seat5.Visible = false;


            foreach (ShowTimeView i in allShowtimes)
            {
                
                

            }
            var maxPeople = new string[] { "1", "2", "3", "4", "5" }; 
            foreach (var item in maxPeople) 
            {
                numberOfPeople.Text = "Number of people ...";
                numberOfPeople.Items.Add(item);  
                    }
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
            person1.Visible = false;
            person2.Visible = false;
            person3.Visible = false;
            person4.Visible = false;
            person5.Visible = false;
            person11.Visible = false;
            person22.Visible = false;
            person33.Visible = false;
            person44.Visible = false;
            person55.Visible = false;
            seat1.Visible = false;
            seat2.Visible = false;
            seat3.Visible = false;
            seat4.Visible = false;
            seat5.Visible = false;

            var reservationQuantity = int.Parse(numberOfPeople.Text);
            var counter = 0;
            while (counter <= reservationQuantity)
            {
                switch (counter)
                {
                    case 1:
                        selectRow.Visible = true;
                        SelectSeatNr.Visible = true;
                        person1.Visible = true;
                        person11.Visible = true;
                        seat1.Visible = true;
                        break;
                    case 2:
                        person2.Visible = true;
                        person22.Visible = true;
                        seat2.Visible = true;
                        break;
                    case 3:
                        person3.Visible = true;
                        person33.Visible = true;
                        seat3.Visible = true;
                        break;
                    case 4:
                        person4.Visible = true;
                        person44.Visible = true;
                        seat4.Visible = true;
                        break;
                    case 5:
                        person5.Visible = true;
                        person55.Visible = true;
                        seat5.Visible = true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
