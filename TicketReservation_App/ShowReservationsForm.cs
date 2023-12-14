using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using CinemaTicketReservation.Model;
using System.Security.Cryptography.X509Certificates;

namespace CinemaTicketReservation
{
    public partial class ShowReservationsForm : Form
    {
        PrintDocument printDoc = new PrintDocument();
        Bitmap screenshot;
        Show show;
        public ShowReservationsForm(Show showinput)
        {
        
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(_printDoc_PrintPage);
            show = showinput;
        }

     

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Screenshot der Textbox machen
                screenshot = new Bitmap(textBoxShowReservations.Width, textBoxShowReservations.Height);

                Rectangle r = new Rectangle(textBoxShowReservations.Left, textBoxShowReservations.Top
                    , textBoxShowReservations.Width, textBoxShowReservations.Height);

                textBoxShowReservations.DrawToBitmap(screenshot, r);

                printDialog1.AllowSomePages = true;
                printDialog1.Document = printDoc;

                // Druck-Dialog öffnen 
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Screenshot drucken 
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Drucken", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(screenshot, 0, 0);
        }

        private void ShowReservationsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: die Reservationen für die im Hauptformular ausgewählte Show in diesem Formular anzeigen
            textBoxShow.Text = "«"+show.Movie.Title+"» am "+ show.StartTime+" Uhr";


            List<Reservation> reservations = show.GetReservations();
            string ausgabe="";
            foreach (Reservation reservation in reservations)
            {
                ausgabe = ausgabe + reservation.Customer.FirstName+" "+reservation.Customer.LastName+"\tReihe:" + reservation.Seat.Row.Number +"\tSitz:" +reservation.Seat.Number+"\r\n";
            }
            textBoxShowReservations.Text = ausgabe;

        }
    }
}
