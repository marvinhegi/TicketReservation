using CinemaTicketReservation.Model;
using CinemaTicketReservation.Model.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaTicketReservation
{
    public partial class ReservationForm : Form
    {
        #region fields 

        private User user;
        private Seat selectedSeat;

        #endregion

        #region constructor

        public ReservationForm(User registeredUser)
        {
            user = registeredUser;
            InitializeComponent();
        }

        #endregion 

        #region event handler 

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            if (user.IsLoggedIn)
            {
                textBoxFirstLastName.Text = user.FirstName + " " + user.LastName;
               
                List<Show> shows = (new Database()).GetShows();
                comboBoxShows.DataSource = shows;
            }
            else
            {
                MessageBox.Show("Kein Zugang. Benutzer nicht authentifiziert.", "Fehler"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void comboBoxShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show selectedShow = (Show)comboBoxShows.SelectedItem;
            CreateSeatPlan(selectedShow);
        }
       
        void buttonSeat_Click(object sender, EventArgs e)
        {
            Show show = (Show)comboBoxShows.SelectedItem;
            selectedSeat = (Seat)((Button)sender).Tag;

            if (show.IsSeatReserved(selectedSeat))
            {
                SetEnablements(false);

                MessageBox.Show("Dieser Sitz ist bereits reserviert!", "Keine Reservation möglich"
                   , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                selectedSeat = null;
                return;
            }

            SetEnablements(true);

            textBoxShow.Text = show.ToString();
            textBoxRow.Text = selectedSeat.Row.Number.ToString();
            textBoxSeat.Text = selectedSeat.Number.ToString();

            textBoxCustomerFirstName.Select();
        }

        private void buttonMakeReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxShows.SelectedIndex != -1 && textBoxCustomerFirstName.Text != "" && textBoxCustomerLastName.Text != "" && textBoxCustomerPhoneNr.Text != "" && selectedSeat != null)
            {
                Show show = comboBoxShows.SelectedItem as Show;
                bool SeatReserved = show.IsSeatReserved(selectedSeat);
                if (SeatReserved == false)
                {
                    // TODO: Reservation ausführen 

                    string firstname = textBoxCustomerFirstName.Text;
                    string lastname = textBoxCustomerLastName.Text;
                    Customer customer = new Customer(firstname, lastname);
                    customer.Phonenumber = textBoxCustomerPhoneNr.Text;

                    Reservation reservation = new Reservation();
                    reservation.Customer = customer;
                    reservation.Seat = selectedSeat;

                    show.AddReservation(reservation);

                  

                    CreateSeatPlan(show);

                    // TODO: Reservationscode anzeigen (anstelle der Fragezeichen) 
                    reservation.generateReservationCode(show);
                    string reservationscode = reservation.ReservationCode;
                    MessageBox.Show("Die Reservierung wurde registriert. " + Environment.NewLine
                        + "Der Reservationscode lautet: " + reservationscode, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxCustomerFirstName.Text = "";
                    textBoxCustomerLastName.Text = "";
                    textBoxCustomerPhoneNr.Text = "";




                }
                else
                {
                    MessageBox.Show("Seat allready selected");
                }
            }
            else
            {
                MessageBox.Show("Es fehlen Eingaben.");
            }
        }

        private void buttonShowReservations_Click(object sender, EventArgs e)
        {
            // TODO: alle bestehenden Reservationen für die ausgewählte Vorführung im "ShowReservationsForm" anzeigen

            ShowReservationsForm f = new ShowReservationsForm();
            f.ShowDialog();
        }

        private void ReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region methods 

        private void CreateSeatPlan(Show show)
        {
            const int ButtonHeight = 25;
            const int ButtonWidth = 58;

            panelSeatsPlan.Controls.Clear();
            SetEnablements(false);

            if (show != null)
            {
                // Bestuhlungsplan erstellen s
                int y = -1;
                foreach (Row row in show.Rows)
                {
                    y++;
                    Label l = new Label();
                    l.Text = "Reihe " + row.Number.ToString();
                    l.Width = ButtonWidth;
                    l.Location = new Point(0, (y * ButtonHeight) + 5);
                    panelSeatsPlan.Controls.Add(l);

                    int i = 1; 
                    foreach (Seat seat in row.GetSeats())
                    {
                       
                        Button b = new Button();
                        b.Text = "Sitz " + seat.Number.ToString();

                        // TODO: Sitz rot einfärben, falls er bereits reserviert ist! 

                        bool SeatReserved = show.IsSeatReserved(seat);
                        if (SeatReserved == true)
                        {
                            b.BackColor = Color.FromKnownColor(KnownColor.Red);
                        }
                        else
                        {

                            b.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                        }
                        b.Height = ButtonHeight;
                        b.Width = ButtonWidth;
                        b.Location = new Point(i++ * ButtonWidth, y * ButtonHeight);
                        panelSeatsPlan.Controls.Add(b);

                        // Click-event registrieren 
                        b.Click += new EventHandler(buttonSeat_Click);

                        // eine Referenz auf die Seat Instanz ablegen 
                        b.Tag = seat;
                    }
                }
            }
        }

        private void SetEnablements(bool isEnabled)
        {
            textBoxCustomerFirstName.Enabled
                = textBoxCustomerLastName.Enabled
                = textBoxCustomerPhoneNr.Enabled
                = buttonMakeReservation.Enabled = isEnabled;

            if (!isEnabled)
            {
                textBoxShow.Clear();
                textBoxSeat.Clear();
                textBoxRow.Clear();
            }
        }

        #endregion 
    }
}
