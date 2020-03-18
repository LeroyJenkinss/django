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
        public DateTime DateTime;
        public int Chair;

        public ShowTimeView(
            int id_showtime,
            DateTime dateTime,
            int chair)
        {
            Id_Showtime = id_showtime;
            DateTime = dateTime;
            Chair = chair;
        }
    }
}
