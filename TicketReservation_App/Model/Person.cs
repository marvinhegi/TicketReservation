using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public abstract class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
    }
}
