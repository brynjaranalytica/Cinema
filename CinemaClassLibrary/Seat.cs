using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
