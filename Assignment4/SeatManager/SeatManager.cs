// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SeatManager.cs" company="Markus Maga">
//   AC7525 Markus Maga 27-07-13
// </copyright>
// <summary>
//   The seat manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeatManager
{
    using System.Collections.Generic;

    /// <summary>
    /// The seat manager.
    /// </summary>
    public class SeatManager
    {
        /// <summary>
        /// The seat rows.
        /// </summary>
        private readonly int seatRows;

        /// <summary>
        /// The seats per row.
        /// </summary>
        private readonly int seatsPerRow;

        /// <summary>
        /// The seats.
        /// </summary>
        private readonly Seat[,] seats;

        /// <summary>
        /// The reservation count.
        /// </summary>
        private int reservedSeatCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeatManager"/> class.
        /// </summary>
        /// <param name="seatRows">
        /// The seat rows.
        /// </param>
        /// <param name="seatsPerRow">
        /// The seats per row.
        /// </param>
        public SeatManager(int seatRows, int seatsPerRow)
        {
            this.seatRows = seatRows;
            this.seatsPerRow = seatsPerRow;

            this.seats = new Seat[seatRows, seatsPerRow];

            for (var row = 0; row < seatRows; row++)
            {
                for (var seat = 0; seat < seatsPerRow; seat++)
                {
                    // Creates a seat with human readable row and seat numbers.
                    this.seats[row, seat] = new Seat(row + 1, seat + 1);
                }
            }
        }

        /// <summary>
        /// Gets the amount of seats per row.
        /// </summary>
        public int SeatsPerRow
        {
            get
            {
                return this.seatsPerRow;
            }
        }

        /// <summary>
        /// Gets the amount of rows.
        /// </summary>
        public int SeatRows
        {
            get
            {
                return this.seatRows;
            }
        }

        /// <summary>
        /// Gets the amount of seats.
        /// </summary>
        public int TotalSeatCount
        {
            get
            {
                return this.SeatRows * this.SeatsPerRow;
            }
        }

        /// <summary>
        /// Gets the reservation count.
        /// </summary>
        public int ReservedSeatCount
        {
            get
            {
                return this.reservedSeatCount;
            }
        }

        /// <summary>
        /// Gets the free seats.
        /// </summary>
        public int FreeSeatCount
        {
            get
            {
                return this.TotalSeatCount - this.ReservedSeatCount;
            }
        }

        /// <summary>
        /// Returns a list with all seats.
        /// </summary>
        /// <returns>
        /// List of seats <see cref="List"/>.
        /// </returns>
        public List<Seat> Seats()
        {
            var list = new List<Seat>();

            for (var row = 0; row < this.seats.GetLength(0); row++)
            {
                for (var seat = 0; seat < this.seats.GetLength(1); seat++)
                {
                    list.Add(this.seats[row, seat]);
                }
            }

            return list;
        }

        /// <summary>
        /// Returns a list of free seats.
        /// </summary>
        /// <returns>
        /// List of seats <see cref="List"/>.
        /// </returns>
        public List<Seat> VacantSeats()
        {
            return this.GetSeats(false);
        }

        /// <summary>
        /// Returns a list of reserved seats.
        /// </summary>
        /// <returns>
        /// List of seats <see cref="List"/>.
        /// </returns>
        public List<Seat> ReservedSeats()
        {
            return this.GetSeats(true);
        }
        
        /// <summary>
        /// Adds a reservation, at a given row and seat. 
        /// </summary>
        /// <param name="seat">
        /// The seat.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public void NewReservation(Seat seat, string name, double price)
        {
            this.UpdateReservationCount(seat, true);

            seat.Reserve(name, price);
        }

        /// <summary>
        /// Cancels a reservation.
        /// </summary>
        /// <param name="seat">
        /// Seat to cancel reservation.
        /// </param>
        public void CancelReservation(Seat seat)
        {
            this.UpdateReservationCount(seat, false);

            seat.CancelReservation();
        }

        /// <summary>
        /// Checks if the given seat has a reservation.
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="seat">
        /// The seat.
        /// </param>
        /// <returns>
        /// True if reserved <see cref="bool"/>.
        /// </returns>
        public bool HasReservation(int row, int seat)
        {
            return this.seats[row, seat].Reserved;
        }

        /// <summary>
        /// The get seat.
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="seat">
        /// The seat.
        /// </param>
        /// <returns>
        /// The <see cref="Seat"/>.
        /// </returns>
        public Seat GetSeat(int row, int seat)
        {
            return this.seats[row, seat];
        }

        /// <summary>
        /// Updates the reservation count.
        /// </summary>
        /// <param name="seat">
        /// The seat.
        /// </param>
        /// <param name="reserve">
        /// Increases count if true, decreases if false.
        /// </param>
        private void UpdateReservationCount(Seat seat, bool reserve)
        {
            // Only increase or decrease if only one is true.
            if (reserve ^ seat.Reserved)
            {
                this.reservedSeatCount += reserve ? +1 : -1;
            }
        }

        /// <summary>
        /// Returns a list of seats.
        /// </summary>
        /// <param name="reserved">
        /// Filtering, only show reserved or vacant seats.
        /// </param>
        /// <returns>
        /// List of seats <see cref="List"/>.
        /// </returns>
        private List<Seat> GetSeats(bool reserved)
        {
            var list = new List<Seat>();

            for (var row = 0; row < this.seats.GetLength(0); row++)
            {
                for (var seat = 0; seat < this.seats.GetLength(1); seat++)
                {
                    var resrv = this.seats[row, seat];
                    if (resrv.Reserved == reserved)
                    {
                        list.Add(resrv);
                    }
                }
            }

            return list;
        } 
    }
}

