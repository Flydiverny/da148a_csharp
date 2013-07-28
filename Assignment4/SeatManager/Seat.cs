// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Seat.cs" company="Markus Maga">
//   AC7525 Markus Maga 27-07-13
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
        /// The row number.
        /// </summary>
        private readonly int rowNbr;

        /// <summary>
        /// The seat number.
        /// </summary>
        private readonly int seatNbr;

        /// <summary>
        /// Whether the seat is reserved or not.
        /// </summary>
        private bool reserved = false;

        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        /// <summary>
        /// The price.
        /// </summary>
        private double price;

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
            this.reserved = true;
            this.name = name;
            this.price = price;
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
            this.rowNbr = rowNbr;
            this.seatNbr = seatNbr;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public double Price
        {
            get
            {
                return this.price;
            }
        }

        /// <summary>
        /// Gets the row number.
        /// </summary>
        public int RowNbr
        {
            get
            {
                return this.rowNbr;
            }
        }

        /// <summary>
        /// Gets the seat number.
        /// </summary>
        public int SeatNbr
        {
            get
            {
                return this.seatNbr;
            }
        }

        /// <summary>
        /// Gets a value indicating whether its reserved.
        /// </summary>
        public bool Reserved
        {
            get
            {
                return this.reserved;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        
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
            this.name = reservationName;
            this.price = reservationPrice;
            this.reserved = true;
        }

        /// <summary>
        /// Cancels the seat reservation.
        /// </summary>
        internal void CancelReservation()
        {
            this.reserved = false;
            this.name = string.Empty;
            this.price = 0;
        }
    }
}
