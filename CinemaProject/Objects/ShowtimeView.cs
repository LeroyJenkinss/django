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
        public string Name;
        public DateTime ReleaseDate;
        public string Genre;

        public MovieView(
            int id,
            string name,
            string genre,
            DateTime releaseDate)
        {
            Id = id;
            Name = name;
            Genre = genre;
            ReleaseDate = releaseDate;
        }
    }
}
