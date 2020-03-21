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

namespace CinemaProject.Model.Forms
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationFormService _reservationFormService;
        private readonly ShowTimeRepository _showTimeRepository;
        private readonly int id_MovieShowtime;

        public ReservationForm(int id_movieShowTime)
        {
            InitializeComponent();
            id_MovieShowtime = id_movieShowTime;
            _reservationFormService = new ReservationFormService();
            _showTimeRepository = new ShowTimeRepository();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            InitializeGroupedFunctions();

            // Note for Leon: probeer duplicate code in een apparte methode te stoppen,
            // zo hoef je alleen de methode aan te roepen in plaats van dezelfde code her te gebruiken. (opdezelfde manier als hoe ik InitializeGroupedFunctions() heb gemaakt)
            // Oh ja en maak nog even een veld voor name en lastname. Plus een dropdown met betaal mogelijkheden (iDeal, CreditCard en Betalen bij bioscoop), deze moet terug komen bij de reserveringbevestiging

            selectRow.Visible = false;
            SelectSeatNr.Visible = false;
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

            var maxPeople = new string[] { "1", "2", "3", "4", "5" }; 
            foreach (var item in maxPeople) 
            {
                numberOfPeople.Text = "Number of people ...";
                numberOfPeople.Items.Add(item);  
            }
        }     
         
        private void numberOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Not for Leon: Zie regel 34)
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
            _showTimeRepository.AddNewTakenChairs(newTakenChairs, id_MovieShowtime);

            ShowReservationPopUp();
        }

        private void ShowReservationPopUp()
        {
            // Note for Leon: Maak hier een pop up met de reserveringsbevestiging. Ik heb al een methode voor je gebouwd waarin je je code kan plaatsen, deze wordt aangeroepen bij het klikken van submit button
            // Gewoon iets stoms als "Betaling gelukt! Bedankt voor je reservatie dit zijn je reserveringsgegevens" en dan naam, achternaam, aantal gasten en de stoelen die gereserveerd zijn laten zien
            // the de reservatieform moet ook sluiten na het weg klikken van de popup
            // Verwijder onderstaande lijn en plaats je nieuwe code
            throw new NotImplementedException();
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
                var availableRowsAndSeats = _reservationFormService.GetDistinctListOfAvaiableChairRowsAndChairNumber(id_MovieShowtime, GetFilledInFormSeats());
                if (availableRowsAndSeats.ContainsKey(chairRow))
                {
                    var availableSeatsForRow = availableRowsAndSeats[chairRow];

                    seatDropdown.UpdateDropDown(id_MovieShowtime, availableSeatsForRow);

                }
            }
        }

        private void rowForPersonGrouped_Click(object sender, EventArgs e, ComboBox rowDropdown, ComboBox seatDropdown)
        {
            var availableRowsAndSeats = _reservationFormService.GetDistinctListOfAvaiableChairRowsAndChairNumber(id_MovieShowtime, GetFilledInFormSeats());
            var availableRows = availableRowsAndSeats.Keys.ToList();
            rowDropdown.UpdateDropDown(id_MovieShowtime, availableRows);
        }

        private void rowForPersonGrouped_ValueChanged(object sender, EventArgs e, ComboBox seatDropdown)
        {
            seatDropdown.ResetText();
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
    }
}
