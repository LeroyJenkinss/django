using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class TheaterView
    {
        public int Id_TheaterRoom;
        public string[] AllChairs;



        public TheaterView(int id_TheaterRoom, string[] allChairs)
        {
            Id_TheaterRoom = id_TheaterRoom;
            AllChairs = allChairs;

        }
    }
}
