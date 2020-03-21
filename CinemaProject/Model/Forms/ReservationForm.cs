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
        private readonly TheaterRoomsRepository _theaterRoomsRepository;
        private readonly int id_MovieShowtime;

        public ReservationForm(int id_movieShowTime)
        {
            InitializeComponent();
            id_MovieShowtime = id_movieShowTime;
            _showTimeRepository = new ShowTimeRepository();
            _theaterRoomsRepository = new TheaterRoomsRepository();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            var showtime = _showTimeRepository.GetShowTime(id_MovieShowtime);
            var theaterRoom = _theaterRoomsRepository.GetTheaterRoom(1);


            selectRow.Visible = false;
            SelectSeatNr.Visible = false;
            rowForPerson1.Visible = false;
            person2.Visible = false;
            person3.Visible = false;
            person4.Visible = false;
            person5.Visible = false;
            seatForPerson1.Visible = false;
            person22.Visible = false;
            person33.Visible = false;
            person44.Visible = false;
            person55.Visible = false;
            seat1.Visible = false;
            seat2.Visible = false;
            seat3.Visible = false;
            seat4.Visible = false;
            seat5.Visible = false;

            var chairsNotTaken = theaterRoom.AllChairs.Where(x => !showtime.TakenChairs.Contains(x));

            foreach (var chair in chairsNotTaken)
            {
                //rowForPerson1.Items.Add(chair[0]);
                //seatForPerson1.Items.Add(chair[1]);
                rowForPerson1.Items.Add(chair);

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
            rowForPerson1.Visible = false;
            person2.Visible = false;
            person3.Visible = false;
            person4.Visible = false;
            person5.Visible = false;
            seatForPerson1.Visible = false;
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
                        rowForPerson1.Visible = true;
                        seatForPerson1.Visible = true;
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

        private void submitReservation_Click(object sender, EventArgs e)
        {
            var seatnumber = rowForPerson1.SelectedItem;
            //var newTakenChairs = rowForPerson1.Items.Cast<Object>()
            //                                        .Select(item => item.ToString()).ToList();

            var newTakenChairs = new List<string>();

            newTakenChairs.Add(seatnumber.ToString());

            _showTimeRepository.AddNewTakenChairs(newTakenChairs, id_MovieShowtime);
        }
    }
}
