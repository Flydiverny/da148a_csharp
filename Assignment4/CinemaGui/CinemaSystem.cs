// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CinemaSystem.cs" company="Markus Maga">
//   AC7525 Markus Maga 29-07-13
// </copyright>
// <summary>
//   The cinema system.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CinemaGui
{
    using System.Windows.Forms;

    /// <summary>
    /// The cinema system.
    /// </summary>
    public class CinemaSystem
    {
        /// <summary>
        /// The total amount of seats.
        /// </summary>
        private const int AmountOfRows = 12;

        /// <summary>
        /// The amount of seats per row.
        /// </summary>
        private const int AmountOfSeatsPerRow = 6;

        /// <summary>
        /// The seat presenter.
        /// </summary>
        private readonly SeatPresenter seatPresenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="CinemaSystem"/> class.
        /// </summary>
        public CinemaSystem()
        {
            this.seatPresenter = new SeatPresenter(AmountOfRows, AmountOfSeatsPerRow);
        }

        /// <summary>
        /// Shows the main form.
        /// </summary>
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(this.seatPresenter));
        }
    }
}
