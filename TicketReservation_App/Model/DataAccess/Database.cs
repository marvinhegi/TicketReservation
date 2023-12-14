using System;
using System.Collections.Generic;

namespace CinemaTicketReservation.Model.DataAccess
{
    public class Database
    {
        public Database()
        { 
        }

        #region constants 

        // TODO: Werte dynamisch von der Datenbank gelesen (für den Prototyp noch nicht nötig)
        public const int CountOfRows = 10;
        public const int CountOfSeatsPerRow = 10;

        #endregion 

        #region methods 

        public User Authenticate(string userName, string password)
        {
            // TODO: für den Prototypen reicht das, die Implementation des Authentifizierungsmechanismus machen wir später 
            User user = new User("Hans", "Tester");
            user.UserName = userName;
            user.IsLoggedIn = true;

            return user;
        }

        public List<Show> GetShows()
        {
            // TODO: die Vorführungen von der Datenbank holen (noch nicht nötig für Prototyp) 
            List<Show> showList = new List<Show>();

            Movie movie1 = new Movie();
            movie1.Title = "James Bond 007";
            movie1.Genre = "Action";

            Movie movie2 = new Movie();
            movie2.Title = "American Pie";
            movie2.Genre = "Fun";

            Show show1 = new Show(movie1, new DateTime(2023, 12, 01, 20, 15,0));
            FillRows(ref show1, CountOfRows, CountOfSeatsPerRow);
            showList.Add(show1);

            Show show2 = new Show(movie2, new DateTime(2023, 12, 02, 20, 15,0));
            FillRows(ref show2, CountOfRows, CountOfSeatsPerRow);
            showList.Add(show2);

            Show show3 = new Show(movie1, new DateTime(2023, 12, 03, 18, 0, 0));
            FillRows(ref show3, CountOfRows, CountOfSeatsPerRow);
            showList.Add(show3);

            Show show4 = new Show(movie1, new DateTime(2023, 12, 03, 20, 30, 0));
            FillRows(ref show4, CountOfRows, CountOfSeatsPerRow);
            showList.Add(show4);

            return showList;
        }
        
        public void SaveReservations(Show show)
        { 
            // TODO: Reservationen in der Datenbank ablegen (für Prototyp noch nicht nötig) 
        }
        
        private void FillRows(ref Show show, int countOfRows, int countOfSeatsPerRow)
        {
            for (int i = 1; i <= countOfRows; i++)
            {   
                Row r = new Row(i);
                for (int j = 1; j <= countOfSeatsPerRow; j++)
                {
                    r.AddSeat(new Seat(j, r));
                }
                
                show.Rows.Add(r);
            }
        }

        #endregion 
    }
}
