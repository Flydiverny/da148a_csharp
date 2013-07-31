// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SeatManager.cs" company="Markus Maga">
//   AC7525 Markus Maga 29-07-13
// </copyright>
// <summary>
//   The seat manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeatManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;

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

            this.PopulateSeats();
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
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// Array of seats <see cref="Seat[]"/>.
        /// </returns>
        public Seat[] GetSeats(Seats filter = Seats.All)
        {
            var list = new List<Seat>();

            var reservedSeats = (filter == Seats.All) || (filter == Seats.Reserved);
            var vacantSeats = (filter == Seats.All) || (filter == Seats.Vacant);

            for (var row = 0; row < this.seats.GetLength(0); row++)
            {
                for (var seat = 0; seat < this.seats.GetLength(1); seat++)
                {
                    var s = this.seats[row, seat];

                    if ((reservedSeats && s.Reserved) || (vacantSeats && !s.Reserved))
                    {
                        list.Add(s);
                    }
                }
            }

            return list.ToArray();
        }

        /// <summary>
        /// Adds a reservation, at a given row and seat. 
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="seat">
        /// The seat.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public void NewReservation(int row, int seat, string name, double price)
        {
            this.NewReservation(this.seats[row, seat], name, price);
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
            if (!this.seats[seat.RowNbr - 1, seat.SeatNbr - 1].Equals(seat))
            {
                throw new ArgumentException("Uhm.. where did this seat come from again? It's certainly not from this seat manager!");
            }

            this.UpdateReservationCount(seat, true);

            seat.Reserve(name, price);
        }

        /// <summary>
        /// Cancels a reservation.
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="seat">
        /// The seat.
        /// </param>
        public void CancelReservation(int row, int seat)
        {
            this.CancelReservation(this.seats[row, seat]);
        }

        /// <summary>
        /// Cancels a reservation.
        /// </summary>
        /// <param name="seat">
        /// Seat to cancel reservation.
        /// </param>
        public void CancelReservation(Seat seat)
        {
            if (!this.seats[seat.RowNbr - 1, seat.SeatNbr - 1].Equals(seat))
            {
                throw new ArgumentException("Uhm.. where did this seat come from again? It's certainly not from this seat manager!");
            }

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
        /// Resets the entire booking.
        /// </summary>
        public void ResetReservations()
        {
            this.PopulateSeats();
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
        /// Fills the seat array with seats.
        /// </summary>
        private void PopulateSeats()
        {
            this.reservedSeatCount = 0;

            for (var row = 0; row < this.seatRows; row++)
            {
                for (var seat = 0; seat < this.seatsPerRow; seat++)
                {
                    // Creates a seat with human readable row and seat numbers.
                    this.seats[row, seat] = new Seat(row + 1, seat + 1);
                }
            }
        }
    }
}

