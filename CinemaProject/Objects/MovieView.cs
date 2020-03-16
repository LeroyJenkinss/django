using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class MovieView
    {
        public int Id_Movie;
        public string Name;
        public DateTime ReleaseDate;
        public string Genre;

        public MovieView(
            int id_Movie,
            string name,
            string genre,
            DateTime releaseDate)
        {
            Id_Movie = id_Movie;
            Name = name;
            Genre = genre;
            ReleaseDate = releaseDate;
        }
    }
}
