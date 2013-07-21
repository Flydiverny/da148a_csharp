﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Markus Maga">
//   AC7525 Markus Maga 21-07-13
// </copyright>
// <summary>
//   Handles user interactions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment3
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The total amount of seats.
        /// </summary>
        private const int TotalAmountOfSeats = 240;

        /// <summary>
        /// String format to use when inserting items in reservations list.
        /// </summary>
        private const string ListFormat = "{0,5} {1} {2} {3,6}";

        /// <summary>
        /// Counter for the amount of reserved seats.
        /// </summary>
        private int reservedSeats = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // This call is required by the designer.
            this.InitializeComponent();

            // Intialize all input/output controls.
            this.InitializeGUI();
        }

        /// <summary>
        /// Initializes the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            this.lblSeatsTotalNum.Text = TotalAmountOfSeats.ToString();

            var columns = new List<string>() { "Seat", "Status", "Name", "Price" };
            columns.ForEach(name => this.lstReservations.Columns.Add(name));

            for (var i = 1; i <= TotalAmountOfSeats; i++)
            {
                var lstItem = this.lstReservations.Items.Add(i.ToString());
                lstItem.SubItems.Add("Vacant");
                lstItem.SubItems.Add(string.Empty);
                lstItem.SubItems.Add(0d.ToString());
            }

            this.UpdateGUI();
        }

        /// <summary>
        /// Updates the GUI
        /// </summary>
        private void UpdateGUI()
        {
            this.lblSeatsReservedNum.Text = this.reservedSeats.ToString();
            this.lblSeatsVacantNum.Text = (TotalAmountOfSeats - this.reservedSeats).ToString();
        }

        /// <summary>
        /// Triggered when the user selects radio button for reservation.
        /// </summary>
        /// <param name="sender">
        /// Object that triggered event.
        /// </param>
        /// <param name="e">
        /// Event taking place.
        /// </param>
        private void RdoReserveCheckedChanged(object sender, EventArgs e)
        {
            this.ToggleInputFields(true);   
        }

        /// <summary>
        /// Triggered when the user selects radio button for canceling a reservation.
        /// </summary>
        /// <param name="sender">
        /// Object that triggered event.
        /// </param>
        /// <param name="e">
        /// Event taking place.
        /// </param>
        private void RdoCancelCheckedChanged(object sender, EventArgs e)
        {
            this.ToggleInputFields(false);   
        }

        /// <summary>
        /// Used to toggle state of input fields.
        /// </summary>
        /// <param name="enabled">
        /// Enable or disable input fields.
        /// </param>
        private void ToggleInputFields(bool enabled)
        {
            this.txtName.Enabled = enabled;
            this.txtPrice.Enabled = enabled;
        }

        /// <summary>
        /// Adds an item to the list at specified index, will remove the specified index before adding.
        /// </summary>
        /// <param name="reserved">
        /// Whether the item is reserved or vacant.
        /// </param>
        /// <param name="name">
        /// Name of person reserving, should be specified if reserved.
        /// </param>
        /// <param name="price">
        /// Price of reservation, should be specified if reserved.
        /// </param>
        private void AddToList(bool reserved, string name = "", double price = 0d)
        {
            string status;
            var index = this.lstReservations.SelectedItems[0].Index;

            if (reserved)
            {
                this.reservedSeats++;
                status = "Reserved";
            }
            else
            {
                this.reservedSeats--;
                status = "Vacant";
            }

            this.lstReservations.Items.RemoveAt(index);
            
            var lstItem = this.lstReservations.Items.Insert(index, (index+1).ToString());
            lstItem.SubItems.Add(status);
            lstItem.SubItems.Add(name);
            lstItem.SubItems.Add(price.ToString());
        }

        /// <summary>
        /// Cancels selected reservation.
        /// </summary>
        private void CancelReservation()
        {
            if (this.ValidSeatSelected())
            {
                this.AddToList(false);
            }
        }

        /// <summary>
        /// Adds a reservation at selected index, if all input and selection validates.
        /// </summary>
        private void AddReservation()
        {
            string name;
            double price;

            if (!this.ReadAndValidateInput(out name, out price))
            {
                return; // error messages shown by individual validations.
            }

            this.AddToList(true, name, price);
        }

        /// <summary>
        /// Triggered when the user clicks the Ok button to reserve or cancel reservation.
        /// </summary>
        /// <param name="sender">
        /// Object that triggered event.
        /// </param>
        /// <param name="e">
        /// Event taking place.
        /// </param>
        private void BtnConfirmClick(object sender, EventArgs e)
        {
            // Perform action depending on what radio button is selected.
            if (this.rdoCancel.Checked)
            {
                this.CancelReservation();
            }
            else if (this.rdoReserve.Checked)
            {
                this.AddReservation();
            }

            this.UpdateGUI();
        }

        /// <summary>
        /// Uses <see cref="ReadAndValidateName"/> and <see cref="ReadAndValidatePrice"/> to validate input.
        /// </summary>
        /// <param name="name">
        /// Name entered by user.
        /// </param>
        /// <param name="price">
        /// Price entered by user.
        /// </param>
        /// <returns>
        /// True if both price and name is valid <see cref="bool"/>.
        /// </returns>
        private bool ReadAndValidateInput(out string name, out double price)
        {
            var validName = this.ReadAndValidateName(out name);
            var validPrice = this.ReadAndValidatePrice(out price);

            var validSeat = this.ValidSeatSelected();
            
            return validName && validPrice && validSeat;
        }

        /// <summary>
        /// Confirms whether the user has selected an item in the reservation list.
        /// </summary>
        /// <returns>
        /// False if no item is selected <see cref="bool"/>.
        /// </returns>
        private bool ValidSeatSelected()
        {
            if (this.lstReservations.SelectedItems.Count < 0)
            {
                this.ShowErrorMessage("No seat was selected.", "Invalid Seat");
                return false;
            }


            return true;
        }

        /// <summary>
        /// Gets the name from the input field and checks if its empty.
        /// </summary>
        /// <param name="name">
        /// Name entered.
        /// </param>
        /// <returns>
        /// True if name is non-empty <see cref="bool"/>.
        /// </returns>
        private bool ReadAndValidateName(out string name)
        {
            name = this.txtName.Text;
            
            if (InputUtility.IsEmpty(name))
            {
                this.ShowErrorMessage("Invalid input in name! Please check your input!", "Invalid Name");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the price from input field and parses it to a double.
        /// </summary>
        /// <param name="price">
        /// Price entered as double
        /// </param>
        /// <returns>
        /// True if the price was parse able and a positive number <see cref="bool"/>.
        /// </returns>
        private bool ReadAndValidatePrice(out double price)
        {
            if (!InputUtility.GetPositiveDouble(this.txtPrice.Text, out price))
            {
                this.ShowErrorMessage("Invalid input in price! Please check your price and make sure its positive and correctly formatted.", "Invalid Price");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Shows an error message with an error icon and a standard Ok button.
        /// </summary>
        /// <param name="msg">
        /// Message to show in dialog.
        /// </param>
        /// <param name="caption">
        /// Title on dialog.
        /// </param>
        private void ShowErrorMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
