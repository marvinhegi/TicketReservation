namespace CinemaTicketReservation
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxFirstLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelSeatsPlan = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhoneNr = new System.Windows.Forms.TextBox();
            this.textBoxCustomerLastName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.comboBoxShows = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonShowReservations = new System.Windows.Forms.Button();
            this.panelUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.SystemColors.Window;
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.textBoxFirstLastName);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Location = new System.Drawing.Point(6, 15);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(680, 44);
            this.panelUser.TabIndex = 0;
            // 
            // textBoxFirstLastName
            // 
            this.textBoxFirstLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFirstLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstLastName.Location = new System.Drawing.Point(189, 10);
            this.textBoxFirstLastName.Name = "textBoxFirstLastName";
            this.textBoxFirstLastName.ReadOnly = true;
            this.textBoxFirstLastName.Size = new System.Drawing.Size(465, 23);
            this.textBoxFirstLastName.TabIndex = 1;
            this.textBoxFirstLastName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angemeldeter Benutzer: ";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(558, 675);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 38);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panelSeatsPlan);
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bestuhlungsplan";
            // 
            // panelSeatsPlan
            // 
            this.panelSeatsPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeatsPlan.BackColor = System.Drawing.Color.LightYellow;
            this.panelSeatsPlan.Location = new System.Drawing.Point(19, 29);
            this.panelSeatsPlan.Name = "panelSeatsPlan";
            this.panelSeatsPlan.Size = new System.Drawing.Size(646, 288);
            this.panelSeatsPlan.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCustomerPhoneNr);
            this.groupBox4.Controls.Add(this.textBoxCustomerLastName);
            this.groupBox4.Controls.Add(this.textBoxCustomerFirstName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(351, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 143);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kunde";
            // 
            // textBoxCustomerPhoneNr
            // 
            this.textBoxCustomerPhoneNr.Enabled = false;
            this.textBoxCustomerPhoneNr.Location = new System.Drawing.Point(90, 103);
            this.textBoxCustomerPhoneNr.Name = "textBoxCustomerPhoneNr";
            this.textBoxCustomerPhoneNr.Size = new System.Drawing.Size(215, 24);
            this.textBoxCustomerPhoneNr.TabIndex = 11;
            // 
            // textBoxCustomerLastName
            // 
            this.textBoxCustomerLastName.Enabled = false;
            this.textBoxCustomerLastName.Location = new System.Drawing.Point(90, 70);
            this.textBoxCustomerLastName.Name = "textBoxCustomerLastName";
            this.textBoxCustomerLastName.Size = new System.Drawing.Size(216, 24);
            this.textBoxCustomerLastName.TabIndex = 10;
            // 
            // textBoxCustomerFirstName
            // 
            this.textBoxCustomerFirstName.Enabled = false;
            this.textBoxCustomerFirstName.Location = new System.Drawing.Point(90, 38);
            this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            this.textBoxCustomerFirstName.Size = new System.Drawing.Size(216, 24);
            this.textBoxCustomerFirstName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon-Nr: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nachname: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vorname: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxShow);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxRow);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxSeat);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 141);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sitzreihe und Sitz";
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(92, 33);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.ReadOnly = true;
            this.textBoxShow.Size = new System.Drawing.Size(226, 24);
            this.textBoxShow.TabIndex = 16;
            this.textBoxShow.TabStop = false;
            this.textBoxShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vorführung:";
            // 
            // textBoxRow
            // 
            this.textBoxRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRow.Location = new System.Drawing.Point(92, 66);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.ReadOnly = true;
            this.textBoxRow.Size = new System.Drawing.Size(90, 26);
            this.textBoxRow.TabIndex = 13;
            this.textBoxRow.TabStop = false;
            this.textBoxRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Reihe:";
            // 
            // textBoxSeat
            // 
            this.textBoxSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeat.Location = new System.Drawing.Point(92, 98);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.ReadOnly = true;
            this.textBoxSeat.Size = new System.Drawing.Size(90, 26);
            this.textBoxSeat.TabIndex = 14;
            this.textBoxSeat.TabStop = false;
            this.textBoxSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Platz: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonMakeReservation);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(6, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation ausführen";
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeReservation.Enabled = false;
            this.buttonMakeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeReservation.Image = ((System.Drawing.Image)(resources.GetObject("buttonMakeReservation.Image")));
            this.buttonMakeReservation.Location = new System.Drawing.Point(527, 171);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(131, 35);
            this.buttonMakeReservation.TabIndex = 21;
            this.buttonMakeReservation.Text = "&Reservieren";
            this.buttonMakeReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMakeReservation.UseVisualStyleBackColor = true;
            this.buttonMakeReservation.Click += new System.EventHandler(this.buttonMakeReservation_Click);
            // 
            // comboBoxShows
            // 
            this.comboBoxShows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxShows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShows.FormattingEnabled = true;
            this.comboBoxShows.Location = new System.Drawing.Point(105, 74);
            this.comboBoxShows.Name = "comboBoxShows";
            this.comboBoxShows.Size = new System.Drawing.Size(557, 25);
            this.comboBoxShows.TabIndex = 21;
            this.comboBoxShows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShows_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Vorführung: ";
            // 
            // buttonShowReservations
            // 
            this.buttonShowReservations.Location = new System.Drawing.Point(37, 675);
            this.buttonShowReservations.Name = "buttonShowReservations";
            this.buttonShowReservations.Size = new System.Drawing.Size(260, 38);
            this.buttonShowReservations.TabIndex = 24;
            this.buttonShowReservations.Text = "Alle Reservationen anzeigen...";
            this.buttonShowReservations.UseVisualStyleBackColor = true;
            this.buttonShowReservations.Click += new System.EventHandler(this.buttonShowReservations_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 734);
            this.Controls.Add(this.buttonShowReservations);
            this.Controls.Add(this.comboBoxShows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(674, 548);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Ticket Reservation System - Version 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationForm_FormClosed);
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox textBoxFirstLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCustomerPhoneNr;
        private System.Windows.Forms.TextBox textBoxCustomerLastName;
        private System.Windows.Forms.TextBox textBoxCustomerFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSeatsPlan;
        private System.Windows.Forms.ComboBox comboBoxShows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShowReservations;
    }
}