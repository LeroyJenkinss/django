using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class TheaterView
    {
        public int Id_Chair;
        public string[] AllChairs;
        

        public TheaterView(int id_theaterroom, string[] allchairs){
            Id_TheaterRoom = id_theaterroom;
            AllChairs = allchairs;
        }
    }
}
