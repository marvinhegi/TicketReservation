using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Customer : Person
    {
        string phoneNumber;
        public string Phonenumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }    

        }
        // TODO: Klasse implementieren gemäss Klassendiagramm 
        public Customer(string firstName, string lastName)
          : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
