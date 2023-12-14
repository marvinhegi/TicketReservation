using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Reservation
    {
        // TODO: Klasse implementieren gemäss Klassendiagramm  
        Customer customer;
        string reservationCode;
        Seat seat;
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }

        }

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }

        }

        public string ReservationCode
        { 
            get { return reservationCode; }
            set { reservationCode = value; }
        }

        public void generateReservationCode(Show show)
        {
            reservationCode = show.Movie.Title+"-"+show.StartTime.ToString()+"-"+seat.Row.Number.ToString()+seat.Number.ToString()+"-"+customer.FirstName+customer.LastName;
        }

    }
}
