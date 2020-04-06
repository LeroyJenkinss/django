using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaProject.View;

namespace CinemaProject.Model.Forms
{
    public partial class popUpMakeReservation : Form
    {
        private ReservationPopupView ReservationDetails;

        public popUpMakeReservation(ReservationPopupView reservationDetails)
        {
            InitializeComponent();
            ReservationDetails = reservationDetails;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
