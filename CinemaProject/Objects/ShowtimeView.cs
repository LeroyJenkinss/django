using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ShowTimeView
    {
        public int Id_Showtime;
        public int Id_Movie;
        public DateTime DateTime;
        public Array TakenChairs;

        public ShowTimeView(
            int id_showtime,
            int id_movie,
            DateTime dateTime,
            Array takenChairs)
        {
            Id_Showtime = id_showtime;
            Id_Movie = id_movie;
            DateTime = dateTime;
            TakenChairs = takenChairs;
        }
    }
}
