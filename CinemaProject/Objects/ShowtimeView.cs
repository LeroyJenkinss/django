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
        public DateTime Showtime;

        public ShowTimeView(
            int id_movieshowtime,
            int id_movie,
            int showtime)
        {
            Id_MovieShowTime = id_movieshowtime;
            Id_Movie = id_movie;
            Showtime = showtime;
        }
    }
}