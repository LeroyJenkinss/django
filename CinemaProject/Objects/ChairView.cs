using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
    public class ChairView
    {
        public int Id_Chair;
        public double Price;
        

        public ChairView( int id_Chair,double price){
            Id_Chair = id_Chair;
            Price = price;
        }
    }
}
