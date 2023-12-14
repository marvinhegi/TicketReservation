using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Movie
    {
        public Movie()
        { 
        }

        #region properties 


        public string Title
        {
            get;
            set;
        }


        public string Genre
        {
            get;
            set;
        }


        public int DurationInMinutes
        {
            get;
            set;
        }

        #endregion 

        #region methods

        public override string ToString()
        {
            return Title;
        }
        #endregion 
    }
}
