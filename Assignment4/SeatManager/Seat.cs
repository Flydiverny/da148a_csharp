// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Seat.cs" company="Markus Maga">
//   AC7525 Markus Maga 29-07-13
// </copyright>
// <summary>
//   The reservation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeatManager
{
    /// <summary>
    /// The reservation.
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class.
        /// </summary>
        /// <param name="rowNbr">
        /// The row number.
        /// </param>
        /// <param name="seatNbr">
        /// The seat number.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public Seat(int rowNbr, int seatNbr, string name, double price) : this(rowNbr, seatNbr)
        {
            this.Reserved = true;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class.
        /// </summary>
        /// <param name="rowNbr">
        /// The row number.
        /// </param>
        /// <param name="seatNbr">
        /// The seat number.
        /// </param>
        public Seat(int rowNbr, int seatNbr)
        {
            this.RowNbr = rowNbr;
            this.SeatNbr = seatNbr;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// Gets the row number.
        /// </summary>
        public int RowNbr { get; private set; }

        /// <summary>
        /// Gets the seat number.
        /// </summary>
        public int SeatNbr { get; private set; }

        /// <summary>
        /// Gets a value indicating whether its reserved.
        /// </summary>
        public bool Reserved { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Reserves the seat.
        /// </summary>
        /// <param name="reservationName">
        /// The reservation Name.
        /// </param>
        /// <param name="reservationPrice">
        /// The reservation Price.
        /// </param>
        internal void Reserve(string reservationName, double reservationPrice)
        {
            this.Name = reservationName;
            this.Price = reservationPrice;
            this.Reserved = true;
        }

        /// <summary>
        /// Cancels the seat reservation.
        /// </summary>
        internal void CancelReservation()
        {
            this.Reserved = false;
            this.Name = string.Empty;
            this.Price = 0;
        }
    }
}
