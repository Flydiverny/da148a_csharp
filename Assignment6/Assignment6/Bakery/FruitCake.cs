// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FruitCake.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The fruit.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6.Bakery
{
    using System;

    /// <summary>
    /// The fruit.
    /// </summary>
    public enum Fruit
    {
        Apple, Pear, Orange, Blueberry, Strawberry, Cranberry
    }

    /// <summary>
    /// The fruit cake.
    /// </summary>
    public class FruitCake : Cake
    {
        /// <summary>
        /// The fruit one.
        /// </summary>
        private Fruit mainFruit;

        /// <summary>
        /// The fruit two.
        /// </summary>
        private Fruit secondaryFruit;

        /// <summary>
        /// Initializes a new instance of the <see cref="FruitCake"/> class.
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
        public FruitCake(string name, double price, int pieces) : base(name, price, pieces)
        {
            var values = Enum.GetValues(typeof(Fruit));
            var rng = new Random();

            this.mainFruit = (Fruit)values.GetValue(rng.Next(values.Length));
            this.secondaryFruit = (Fruit)values.GetValue(rng.Next(values.Length));
        }

        /// <summary>
        /// Gets or sets the main fruit.
        /// </summary>
        public Fruit MainFruit
        {
            get
            {
                return this.mainFruit;
            }

            set
            {
                this.mainFruit = value;
            }
        }

        /// <summary>
        /// Gets or sets the secondary fruit.
        /// </summary>
        public Fruit SecondaryFruit
        {
            get
            {
                return this.secondaryFruit;
            }

            set
            {
                this.secondaryFruit = value;
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
            return string.Format("This awesomely delicious {0} containing {1} and {2} will cost you {3} ", this.Name, this.mainFruit.ToString(), this.secondaryFruit.ToString(), this.Price);
        }
    }
}
