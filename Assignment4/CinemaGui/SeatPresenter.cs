// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SeatPresenter.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Defines the SeatPresenter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CinemaGui
{
    using System.Windows.Forms;

    using SeatManager;

    /// <summary>
    /// The seat presenter.
    /// </summary>
    public class SeatPresenter
    {
        /// <summary>
        /// Columns used by the list view.
        /// </summary>
        public static readonly string[] Columns = new[] { "Row", "Seat", "Status", "Name", "Price" };

        /// <summary>
        /// The total amount of seats.
        /// </summary>
        private const int AmountOfRows = 12;

        /// <summary>
        /// The amount of seats per row.
        /// </summary>
        private const int AmountOfSeatsPerRow = 6;

        /// <summary>
        /// Words used for Reserved and Vacant in the list.
        /// </summary>
        private const string Reserved = "Reserved", Vacant = "Vacant";
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatPresenter"/> class. 
        /// Wraps a seat manager and can be used to create list view items and other presentational data.
        /// </summary>
        public SeatPresenter()
        {
            this.SeatManager = new SeatManager(AmountOfRows, AmountOfSeatsPerRow);

            this.SetupColumnHeaders();
        }

        /// <summary>
        /// Gets the seat manager.
        /// </summary>
        public SeatManager SeatManager { get; private set; }

        /// <summary>
        /// Gets the column headers.
        /// </summary>
        public ColumnHeader[] ColumnHeaders { get; private set; }

        /// <summary>
        /// Creates a list item out of a Seat.
        /// </summary>
        /// <param name="seat">
        /// Seat to converts.
        /// </param>
        /// <returns>
        /// List view item <see cref="ListViewItem"/>.
        /// </returns>
        public ListViewItem CreateListItem(Seat seat)
        {
            return new ListViewItem(this.SeatToStringArray(seat)) { Tag = seat };
        }

        /// <summary>
        /// Gets seats from the seat manager and converts them to list view items.
        /// </summary>
        /// <param name="filter">
        /// Seats filtering.
        /// </param>
        /// <returns>
        /// List view items <see cref="ListViewItem[]"/>.
        /// </returns>
        public ListViewItem[] GetSeats(Seats filter)
        {
            var seats = SeatManager.GetSeats(filter);

            var listViewItems = new ListViewItem[seats.Length];

            for (var i = 0; i < seats.Length; i++)
            {
                listViewItems[i] = this.CreateListItem(seats[i]);
            }

            return listViewItems;
        }

        /// <summary>
        /// Setups the column headers.
        /// </summary>
        private void SetupColumnHeaders()
        {
            this.ColumnHeaders = new ColumnHeader[Columns.Length];

            for (var i = 0; i < Columns.Length; i++)
            {
                this.ColumnHeaders[i] = new ColumnHeader(Columns[i]);
            }
        }

        /// <summary>
        /// Converts a seat to a string array matching the columns, can be used to create a list view item.
        /// </summary>
        /// <param name="seat">
        /// Seat to convert.
        /// </param>
        /// <returns>
        /// String array matching <see cref="Columns"/> <see cref="string[]"/>.
        /// </returns>
        private string[] SeatToStringArray(Seat seat)
        {
            var columns = new string[Columns.Length];

            columns[0] = seat.RowNbr.ToString();
            columns[1] = seat.SeatNbr.ToString();
            columns[2] = seat.Reserved ? Reserved : Vacant;
            columns[3] = seat.Name;
            columns[4] = seat.Price.ToString();

            return columns;
        }
    }
}
