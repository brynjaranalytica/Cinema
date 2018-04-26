using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    class Reservation
    {
        public String Number { get; set; }
        public Customer Customer { get; set; }
        public Seat Seat { get; set; }
        public Reservation(String number, Customer customer, Seat seat)
        {
            Number = number;
            Customer = customer;
            Seat = seat;
        }
    }
}
