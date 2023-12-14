using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Seat
    {
        public Seat(int number, Row row)
        {
            Number = number;
            Row = row;
        }

        public int Number
        {
            get;
            private set;
        }

        public Row Row
        {
            get;
            private set;
        }
    }
}
