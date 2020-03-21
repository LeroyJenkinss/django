using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class TheaterRoomView
    {
        public int Id_TheaterRoom;
        public List<string> AllChairs;



        public TheaterRoomView(int id_theaterRoom, List<string> allChairs)
        {
            Id_TheaterRoom = id_theaterRoom;
            AllChairs = allChairs;

        }
    }
}
