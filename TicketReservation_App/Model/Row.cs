using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Row
    {
        public Row(int number)
        {
            Number = number;
        }

        #region fields

        private List<Seat> seats = new List<Seat>();

        #endregion

        #region properties 

        public int CountOfSeats
        {
            get
            {
                return seats.Count();
            }
        }

        public int Number
        {
            get;
            private set;
        }

        #endregion 

        #region methods 

        public void AddSeat(Seat seat)
        {
            seats.Add(seat);
        }

        public Seat GetSeat(int number)
        {
            foreach (Seat seat in this.seats)
                if (seat.Number == number)
                    return seat;

            return null;
        }

        public List<Seat> GetSeats() { 
            return seats;
        }

        #endregion
    }
}
