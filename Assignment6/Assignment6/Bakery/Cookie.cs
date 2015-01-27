// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cookie.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The cookie.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6.Bakery
{
    /// <summary>
    /// The cookie.
    /// </summary>
    public class Cookie : BakeryItem
    {
        /// <summary>
        /// The weight.
        /// </summary>
        private readonly double weight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cookie"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="weight">
        /// The weight.
        /// </param>
        public Cookie(string name, double price, double weight) : base(name, price)
        {
            this.weight = weight;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public override double Price
        {
            get
            {
                return (base.Price * this.weight) / 1000;
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
            return "Weight in grams";
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}\n{1} {2}", base.ToString(), "\nThese delicious cookies will cost you ", this.Price);
        }
    }
}
