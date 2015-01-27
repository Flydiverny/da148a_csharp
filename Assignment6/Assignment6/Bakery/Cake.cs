// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cake.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The cake.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6.Bakery
{
    /// <summary>
    /// The cake.
    /// </summary>
    public class Cake : BakeryItem
    {
        /// <summary>
        /// The pieces.
        /// </summary>
        private int pieces;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cake"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="pieces">
        /// The pieces.
        /// </param>
        public Cake(string name, double price, int pieces) : base(name, price)
        {
            this.pieces = pieces;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public override double Price
        {
            get
            {
                return base.Price * this.pieces;
            }
        }

        /// <summary>
        /// The unit descriptor.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static new string UnitDescriptor()
        {
            return "Number of pieces";
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}\n{1} {2}", base.ToString(), "\nThis delicious cake will cost you ", this.Price);
        }
    }
}
