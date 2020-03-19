using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ChairView
    {
        public int Id_TheaterRoom;
        public double Price;
        public string[] Chairs;
        
        

        public ChairView( int id_TheaterRoom, double price, string[]chairs){
            Id_TheaterRoom = id_TheaterRoom;
            Price = price;
            Chairs = chairs;

        }
    }
}
