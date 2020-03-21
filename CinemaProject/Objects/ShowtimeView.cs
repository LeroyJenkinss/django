using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ShowTimeView
    {
        public int Id_MovieShowTime;
        public int Id_Movie;
        public int Id_TheaterRoom;
        public DateTime ShowTime;
        public List<string> TakenChairs; 

        public ShowTimeView(
            int id_movieShowTime,
            int id_movie,
            int id_theaterRoom,
            DateTime showTime,
            List<string> takenChairs)
        {
            Id_MovieShowTime = id_movieShowTime;
            Id_Movie = id_movie;
            Id_TheaterRoom = id_theaterRoom;
            ShowTime = showTime;
            TakenChairs = takenChairs;
        }
    }
}