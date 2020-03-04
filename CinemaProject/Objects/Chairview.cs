using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.View
{
   public class ChairView
    {
        public int Id;
        public float Price;

        public ChairView(
            int id,
            float price)
        {
            Id = id;
            Price = price;
        }
    }
}
