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
using CinemaProject.View;

namespace CinemaProject.Model.Forms
{
    public partial class PopUpMakeReservation : Form
    {
        readonly ReservationPopupView ReservationDetails;
        readonly MoviesRepository _moviesRepository;

        public PopUpMakeReservation(ReservationPopupView reservationDetails)
        {
            InitializeComponent();
            _moviesRepository = new MoviesRepository();
            ReservationDetails = reservationDetails;
        }

        private void PopUpMakeReservation_Load(object sender, EventArgs e)
        {
            var movie = _moviesRepository.GetMovie(ReservationDetails.ShowTimeView.Id_Movie);

            firstName.Text = ReservationDetails.Name;
            lastName.Text = ReservationDetails.Lastname;

            foreach (var seat in ReservationDetails.Seats)
            {
                movieSeats.Text += seat + ", ";
            }

            paymentInfo.Text = ReservationDetails.PaymentInfo;
            paymentOption.Text = ReservationDetails.PaymentOption;
            filmTitle.Text = movie.Name;
            date.Text = ReservationDetails.ShowTimeView.ShowTime.ToString();
        }
    }
}
