using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ShowTimeView
    {
        public int Id_Movietime;
        public string Name;
        public int Showtime;

        public ShowTimeView(
            int id_showtime,
            string name,
            int showtime)
        {
            Id_Movietime = id_showtime;
            Name = name;
            Showtime = showtime;
        }
    }
}