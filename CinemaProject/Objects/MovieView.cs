using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class MovieView
    {
        public int Id;
        public string Name;
        public DateTime ReleaseDate;

        public MovieView(
            int id,
            string name,
            DateTime releaseDate)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
        }
    }
}
