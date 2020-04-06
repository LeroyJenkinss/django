using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ReservationPopupView
    {
        public ShowTimeView ShowTimeView;
        public List<string> Seats;
        public string Name;
        public string Lastname;
        public string PaymentOption;
        public string PaymentInfo;

        public ReservationPopupView(
            ShowTimeView showTimeView,
            List<string> seats,
            string name,
            string lastName,
            string paymentOption,
            string paymentInfo)
        {
            ShowTimeView = showTimeView;
            Seats = seats;
            Name = name;
            Lastname = lastName;
            PaymentOption = paymentOption;
            PaymentInfo = paymentInfo;
        }
    }
}
