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

namespace CinemaTicketReservation
{
    public partial class ShowReservationsForm : Form
    {
        PrintDocument printDoc = new PrintDocument();
        Bitmap screenshot;

        public ShowReservationsForm()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(_printDoc_PrintPage);
        }

        private void ShowReservationsForm_Load(object sender, EventArgs e)
        {
            // TODO: die Reservationen für die im Hauptformular ausgewählte Show in diesem Formular anzeigen
            textBoxShow.Text = ReservationForm.comboBoxShows.SelectedItem.ToString();
            textBoxShowReservations.Text = "TODO: In dieser Textbox alle bestehenden Reservationen für die entsprechende Show auflisten";
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
    }
}
