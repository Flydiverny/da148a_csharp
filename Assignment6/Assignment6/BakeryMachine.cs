// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BakeryMachine.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The bakery machine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6
{
    using Assignment6.Bakery;

    /// <summary>
    /// The bakery machine.
    /// </summary>
    public class BakeryMachine
    {
        /// <summary>
        /// The create bakery.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="unitcount">
        /// The unit count.
        /// </param>
        /// <returns>
        /// The <see cref="BakeryItem"/>.
        /// </returns>
        public static BakeryItem CreateBakery(ProductType type, double price, double unitcount)
        {
            var name = type.ToString().Replace('_', ' ');

            if (IsCake(type))
            {
                if (type.Equals(ProductType.Fruit_Cake))
                    return new FruitCake(name, price, (int)unitcount);

                return new Cake(name, price, (int)unitcount);
            }

            if (IsCookie(type))
            {
                return new Cookie(name, price, unitcount);
            }

            return new BakeryItem(name, price);
        }

        /// <summary>
        /// The get bakery unit.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetBakeryUnit(ProductType type)
        {
            if (IsCake(type))
            {
                return Cake.UnitDescriptor();
            }

            if (IsCookie(type))
            {
                return Cookie.UnitDescriptor();
            }

            return BakeryItem.UnitDescriptor();
        }

        /// <summary>
        /// The is cake.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool IsCake(ProductType type)
        {
            return type.ToString().ToLower().Contains("cake");
        }

        /// <summary>
        /// The is cookie.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool IsCookie(ProductType type)
        {
            return type.ToString().ToLower().Contains("cookie");
        }
    }
}
