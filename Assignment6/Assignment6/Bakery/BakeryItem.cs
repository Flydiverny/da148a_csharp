// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BakeryItem.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   Defines the BakeryItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6.Bakery
{
    /// <summary>
    /// The bakery item.
    /// </summary>
    public class BakeryItem
    {
        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        /// <summary>
        /// The price.
        /// </summary>
        private double price;

        /// <summary>
        /// Initializes a new instance of the <see cref="BakeryItem"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public BakeryItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public virtual double Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.name;
        }

        /// <summary>
        /// The unit descriptor.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string UnitDescriptor()
        {
            return "Bakery Units";
        }
    }
}
