// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Markus Maga">
//   AC7525 Markus Maga 29-07-13
// </copyright>
// <summary>
//   Handles user interactions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CinemaGui
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using SeatManager;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The seat presenter.
        /// </summary>
        private readonly SeatPresenter seatPresenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        /// <param name="seatPresenter">
        /// The seat presenter.
        /// </param>
        public MainForm(SeatPresenter seatPresenter)
        {
            this.seatPresenter = seatPresenter;

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
            // Set the label with amount of seats.
            this.lblSeatsTotalNum.Text = this.seatPresenter.TotalSeatCount.ToString();

            // Add columns to list.
            this.lstReservations.Columns.AddRange(this.seatPresenter.ColumnHeaders);

            // Populate drop down.
            this.cmbSort.DataSource = Enum.GetNames(typeof(Seats));

            this.UpdateGUI();
        }

        /// <summary>
        /// Updates the GUI
        /// </summary>
        private void UpdateGUI()
        {
            this.lblSeatsReservedNum.Text = this.seatPresenter.ReservedSeatCount.ToString();
            this.lblSeatsVacantNum.Text = this.seatPresenter.FreeSeatCount.ToString();
        }
        
        /// <summary>
        /// Replaces a reservation in the list at given index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="seat">
        /// The seat.
        /// </param>
        private void UpdateReservation(int index, Seat seat)
        {
            this.lstReservations.Items.RemoveAt(index);
            this.lstReservations.Items.Insert(index, this.seatPresenter.CreateListItem(seat));
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
        /// Cancels selected reservation.
        /// </summary>
        /// <param name="seat">
        /// The seat.
        /// </param>
        private void CancelReservation(Seat seat)
        {
            if (!seat.Reserved)
            {
                return;
            }

            if (this.ShowQuestionMessage("Are you sure you want to cancel this reservation?", "Cancel Reservation") == DialogResult.Yes)
            {
                this.seatPresenter.CancelReservation(seat);
            }
        }

        /// <summary>
        /// Adds a reservation at selected index, if all input and selection validates.
        /// </summary>
        /// <param name="seat">
        /// The seat.
        /// </param>
        private void AddReservation(Seat seat)
        {
            string name;
            double price;

            if (!this.ReadAndValidateInput(out name, out price))
            {
                return; // error messages shown by individual validations.
            }

            // if theres a reservation ask user for confirmation.
            if (seat.Reserved)
            {
                if (this.ShowQuestionMessage("This seat already has a reservation, are you sure you want to replace it?", "Reservation exists!") != DialogResult.Yes)
                {
                    return; // user doesn't want to replace it.
                }
            }

            this.seatPresenter.NewReservation(seat, name, price);
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
            if (!this.ValidSeatSelected())
            {
                this.ShowErrorMessage("Invalid seat selection, please select one seat.", "Invalid Seat");
                return;
            }

            int selectedIndex;
            var seat = this.GetSelectedSeat(out selectedIndex);

            // Perform action depending on what radio button is selected.
            if (this.rdoCancel.Checked)
            {
                this.CancelReservation(seat);
            }
            else if (this.rdoReserve.Checked)
            {
                this.AddReservation(seat);
            }

            // Update the reservation.
            this.UpdateReservation(selectedIndex, seat);

            // Update gui.
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
            
            return validName && validPrice;
        }

        /// <summary>
        /// Returns the seat for the selected seat.
        /// </summary>
        /// <param name="selectedIndex">
        /// The selected Index.
        /// </param>
        /// <returns>
        /// Selected Seat <see cref="bool"/>.
        /// </returns>
        private Seat GetSelectedSeat(out int selectedIndex)
        {
            var item = this.lstReservations.SelectedItems[0]; // other code prevents us from selecting more or less.
            selectedIndex = item.Index;
            
            return item.Tag as Seat;
        }

        /// <summary>
        /// Confirms whether the user has selected an item in the reservation list.
        /// </summary>
        /// <returns>
        /// True if ONLY one item is selected <see cref="bool"/>.
        /// </returns>
        private bool ValidSeatSelected()
        {
            return this.lstReservations.SelectedItems.Count == 1;
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

        /// <summary>
        /// Shows an error message with an error icon and a standard Ok button.
        /// </summary>
        /// <param name="msg">
        /// Message to show in dialog.
        /// </param>
        /// <param name="caption">
        /// Title on dialog.
        /// </param>
        /// <returns>
        /// The <see cref="DialogResult"/>.
        /// </returns>
        private DialogResult ShowQuestionMessage(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Triggered when the combo box selected index changes.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxSortSelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSelection();
        }

        /// <summary>
        /// Updates the filtering selection.
        /// </summary>
        private void UpdateSelection()
        {
            var selection = (Seats)this.cmbSort.SelectedIndex;
            this.ShowSeats(selection);
        }

        /// <summary>
        /// Populates the list box with the seats from specified collection.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        private void ShowSeats(Seats filter)
        {
            this.lstReservations.Items.Clear();
            this.lstReservations.Items.AddRange(this.seatPresenter.GetSeats(filter));
        }

        /// <summary>
        /// Click on refresh button.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnRefreshClick(object sender, EventArgs e)
        {
            this.UpdateSelection();
        }

        /// <summary>
        /// Triggered when reset button is clicked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnResetClick(object sender, EventArgs e)
        {
            if (this.ShowQuestionMessage("Are you sure you want to reset all bookings?", "Confirm Reset") == DialogResult.Yes)
            {
                this.seatPresenter.ResetReservations();
                this.UpdateSelection(); // so the reset is shown.
                this.UpdateGUI();
            }
        }
    }
}
