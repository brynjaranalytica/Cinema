using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    class Room
    {
        public int SeatRows { get; set; }
        public int SeatColumns { get; set; }
        public Room(int rows, int columns)
        {
            SeatRows = rows;
            SeatColumns = columns;
        }
    }
}
