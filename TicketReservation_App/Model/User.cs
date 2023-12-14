using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class User : Person
    {
        public User(string firstName, string lastName)
            : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        #region properties 

        public string UserName
        {
            get;
            set;
        }

        public bool IsLoggedIn
        {
            get;
            set;
        }

        #endregion 
    }
}
