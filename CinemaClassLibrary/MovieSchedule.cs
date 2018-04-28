using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class MovieSchedule
    {
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public DateTime DateTime { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Boolean[,] ReservedSeats { get; set; }
        public MovieSchedule(Movie movie, Room room, DateTime dateTime)
        {
            Movie = movie;
            Room = room;
            DateTime = dateTime;
            Reservations = new List<Reservation>();
            ReservedSeats = new Boolean[Room.SeatRows, Room.SeatColumns];
        }
        public void ReserveSeat(Reservation reservation)
        {
            Reservations.Add(reservation);
            ReservedSeats[reservation.Seat.Row, reservation.Seat.Column] = true;
        }
        public void CancelSeat(Reservation reservation)
        {
            Reservations.Remove(reservation);
            ReservedSeats[reservation.Seat.Row, reservation.Seat.Column] = false;
        }

    }
}
