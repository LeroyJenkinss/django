using CinemaProject.Model.Repository;
using CinemaProject.Model.Services;
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
using System.Net;

namespace CinemaProject.Model.Forms
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationFormService _reservationFormService;
        private readonly ShowTimeRepository _showTimeRepository;
        private readonly ShowTimeView MovieShowTime;

        public ReservationForm(int id_movieShowTime)
        {
            InitializeComponent();
            _reservationFormService = new ReservationFormService();
            _showTimeRepository = new ShowTimeRepository();
            MovieShowTime = _showTimeRepository.GetShowTime(id_movieShowTime);
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            InitializeGroupedFunctions();

            
            // zo hoef je alleen de methode aan te roepen in plaats van dezelfde code her te gebruiken. (opdezelfde manier als hoe ik InitializeGroupedFunctions() heb gemaakt)
            // Oh ja en maak nog even een veld voor name en lastname. Plus een dropdown met betaal mogelijkheden (iDeal, CreditCard en Betalen bij bioscoop), deze moet terug komen bij de reserveringbevestiging

            selectRow.Visible = false;
            SelectSeatNr.Visible = false;
            VisibleFalse();

            var maxPeople = new string[] { "1", "2", "3", "4", "5" }; 
            foreach (var item in maxPeople) 
            {
                numberOfPeople.Text = "Number of people ...";
                numberOfPeople.Items.Add(item);  
            }
            cardNumber.Visible = false;

            const string V = "Ideal";
            const string V1 = "Creditcard";
            const string V2 = "At counter";
            var methodPayment = new string[] { V, V1, V2 };
            foreach (var item in methodPayment)
            {
                paymentMethod.Text = "...";
                paymentMethod.Items.Add(item);
            }

        }     
         
        private void numberOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            VisibleFalse();

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
                        labelSeat1.Visible = true;
                        break;
                    case 2:
                        rowForPerson2.Visible = true;
                        seatForPerson2.Visible = true;
                        labelSeat2.Visible = true;
                        break;
                    case 3:
                        rowForPerson3.Visible = true;
                        seatForPerson3.Visible = true;
                        labelSeat3.Visible = true;
                        break;
                    case 4:
                        rowForPerson4.Visible = true;
                        seatForPerson4.Visible = true;
                        labelSeat4.Visible = true;
                        break;
                    case 5:
                        rowForPerson5.Visible = true;
                        seatForPerson5.Visible = true;
                        labelSeat5.Visible = true;
                        break;
                    default:
                        break;
                }
                counter += 1;
            }
        }

        private void submitReservation_Click(object sender, EventArgs e)
        {
            var newTakenChairs = GetFilledInFormSeats();
            _showTimeRepository.AddNewTakenChairs(newTakenChairs, MovieShowTime.Id_MovieShowTime);

            var popUpView = new ReservationPopupView(MovieShowTime, 
                                                    GetFilledInFormSeats(), 
                                                    firstNameFill.Text, lastNameFill.Text, 
                                                    paymentMethod.Text, cardNumber.Text);
            ShowReservationPopUp(popUpView);
        }

        private void ShowReservationPopUp(ReservationPopupView popUpView)
        {
            // the pop up for the reservation with data in popUpView
            var newForm = new PopUpMakeReservation(popUpView);
            newForm.Show();
        }

        private List<string> GetFilledInFormSeats()
        {
            var filledInFormSeats = new List<string> 
            {
                 rowForPerson1.Text + seatForPerson1.Text,
                 rowForPerson2.Text + seatForPerson2.Text,
                 rowForPerson3.Text + seatForPerson3.Text,
                 rowForPerson4.Text + seatForPerson4.Text,
                 rowForPerson5.Text + seatForPerson5.Text,
            };

            // Remove values where value == "", null or doesn't have a length of 2 (row + chairnumber)
            filledInFormSeats = filledInFormSeats.Where(s => !string.IsNullOrWhiteSpace(s) && s.Length == 2).Distinct().ToList();

            return filledInFormSeats;
        }

        // When an person clicks on one of the seat dropdowns or row dropdowns, update the lists of avaiable seats or rows
        private void seatForPersonGrouped_Click(object sender, EventArgs e, ComboBox rowDropdown, ComboBox seatDropdown)
        {
            if (rowDropdown.Text.Length == 1)
            {
                var chairRow = char.Parse(rowDropdown.Text);
                var availableRowsAndSeats = _reservationFormService.GetDistinctListOfAvaiableChairRowsAndChairNumber(MovieShowTime.Id_MovieShowTime, GetFilledInFormSeats());
                if (availableRowsAndSeats.ContainsKey(chairRow))
                {
                    var availableSeatsForRow = availableRowsAndSeats[chairRow];

                    seatDropdown.UpdateDropDown(MovieShowTime.Id_MovieShowTime, availableSeatsForRow);

                }
            }
        }

        private void rowForPersonGrouped_Click(object sender, EventArgs e, ComboBox rowDropdown, ComboBox seatDropdown)
        {
            var availableRowsAndSeats = _reservationFormService.GetDistinctListOfAvaiableChairRowsAndChairNumber(MovieShowTime.Id_MovieShowTime, GetFilledInFormSeats());
            var availableRows = availableRowsAndSeats.Keys.ToList();
            rowDropdown.UpdateDropDown(MovieShowTime.Id_MovieShowTime, availableRows);
        }

        private void rowForPersonGrouped_ValueChanged(object sender, EventArgs e, ComboBox seatDropdown)
        {
            seatDropdown.ResetText();
        }


        // To set visible to false
        public void VisibleFalse()
        {
            rowForPerson1.Visible = false;
            rowForPerson2.Visible = false;
            rowForPerson3.Visible = false;
            rowForPerson4.Visible = false;
            rowForPerson5.Visible = false;
            seatForPerson1.Visible = false;
            seatForPerson2.Visible = false;
            seatForPerson3.Visible = false;
            seatForPerson4.Visible = false;
            seatForPerson5.Visible = false;
            labelSeat1.Visible = false;
            labelSeat2.Visible = false;
            labelSeat3.Visible = false;
            labelSeat4.Visible = false;
            labelSeat5.Visible = false;
        }
        // To map all elements to the corresponding methods
        public void InitializeGroupedFunctions()
        {
            rowForPerson1.Click += (sender, e) => rowForPersonGrouped_Click(sender, e, rowForPerson1, seatForPerson1);
            rowForPerson2.Click += (sender, e) => rowForPersonGrouped_Click(sender, e, rowForPerson2, seatForPerson2);
            rowForPerson3.Click += (sender, e) => rowForPersonGrouped_Click(sender, e, rowForPerson3, seatForPerson3);
            rowForPerson4.Click += (sender, e) => rowForPersonGrouped_Click(sender, e, rowForPerson4, seatForPerson4);
            rowForPerson5.Click += (sender, e) => rowForPersonGrouped_Click(sender, e, rowForPerson5, seatForPerson5);

            seatForPerson1.Click += (sender, e) => seatForPersonGrouped_Click(sender, e, rowForPerson1, seatForPerson1);
            seatForPerson2.Click += (sender, e) => seatForPersonGrouped_Click(sender, e, rowForPerson2, seatForPerson2);
            seatForPerson3.Click += (sender, e) => seatForPersonGrouped_Click(sender, e, rowForPerson3, seatForPerson3);
            seatForPerson4.Click += (sender, e) => seatForPersonGrouped_Click(sender, e, rowForPerson4, seatForPerson4);
            seatForPerson5.Click += (sender, e) => seatForPersonGrouped_Click(sender, e, rowForPerson5, seatForPerson5);

            rowForPerson1.DropDownClosed += (sender, e) => rowForPersonGrouped_ValueChanged(sender, e, seatForPerson1);
            rowForPerson2.DropDownClosed += (sender, e) => rowForPersonGrouped_ValueChanged(sender, e, seatForPerson2);
            rowForPerson3.DropDownClosed += (sender, e) => rowForPersonGrouped_ValueChanged(sender, e, seatForPerson3);
            rowForPerson4.DropDownClosed += (sender, e) => rowForPersonGrouped_ValueChanged(sender, e, seatForPerson4);
            rowForPerson5.DropDownClosed += (sender, e) => rowForPersonGrouped_ValueChanged(sender, e, seatForPerson5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameFill_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (paymentMethod.Text == "Ideal")
            {
                cardNumber.Visible = true;
            }
            else if (paymentMethod.Text == "Creditcard")
            {
                cardNumber.Visible = true;
            }
            else 
            {
                cardNumber.Visible = false;
            }
        }

    
}
    }

