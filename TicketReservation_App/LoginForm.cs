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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxFirstname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = null; 
            try
            {
                Database dataAccess = new Database();
                user = dataAccess.Authenticate(textBoxUsername.Text, textBoxPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie konnten nicht angemeldet werden: " + ex.Message
                    , "Authentifizierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ReservationForm f = new ReservationForm(user);
            f.Show();
            this.Hide();
        }
    }
}
