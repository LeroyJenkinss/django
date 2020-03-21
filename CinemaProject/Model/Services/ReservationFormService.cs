using CinemaProject.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject.Model.Services
{
    class ReservationFormService
    {
        private readonly ShowTimeRepository _showTimeRepository;
        private readonly TheaterRoomsRepository _theaterRoomsRepository;
        
        public ReservationFormService()
        {
            _showTimeRepository = new ShowTimeRepository();
            _theaterRoomsRepository = new TheaterRoomsRepository();
        }

        public Dictionary<char, List<char>> GetDistinctListOfAvaiableChairRowsAndChairNumber(int id_MovieShowtime, List<string> filledInFormSeats)
        {
            // Get all avaiable chairs, remove the chairs which are already selected in the reservationform
            var avaiableChairs = GetAvaiableChairs(id_MovieShowtime).Where( x => !filledInFormSeats.Contains(x));

            var dictionary = new Dictionary<char, List<char>>();

            foreach (var chair in avaiableChairs)
            {
                var chairRow = chair[0];
                var chairNumber = chair[1];
                if (dictionary.ContainsKey(chairRow))
                {
                    dictionary[chairRow].Add(chairNumber);
                }
                else
                {
                    dictionary.Add(chairRow, new List<char> { chairNumber });
                }
            }

            return dictionary;
        }

        private List<string> GetAvaiableChairs(int id_MovieShowtime)
        {
            var showTime = _showTimeRepository.GetShowTime(id_MovieShowtime);
            var theaterRoom = _theaterRoomsRepository.GetTheaterRoom(showTime.Id_TheaterRoom);

            var chairsNotTaken = theaterRoom.AllChairs.Where(x => !showTime.TakenChairs.Contains(x)).ToList();

            return chairsNotTaken;
        }
    }

    public static class ReservationFormExtension
    {
        // These are extension methods, handy if you don't want reuse code on the same objects
        public static void UpdateDropDown(this ComboBox seatDropdown, int id_MovieShowtime, List<char> dropdownValues)
        {
            seatDropdown.ResetText();
            seatDropdown.Items.Clear();

            foreach (var value in dropdownValues)
            {
                seatDropdown.Items.Add(value);
            }
        }
    }
}
