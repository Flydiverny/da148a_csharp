// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   Defines the Address type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contacts
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Address information class.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="country">
        /// The country.
        /// </param>
        public Address(Country country) : this(string.Empty, country)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="city">
        /// The city.
        /// </param>
        /// <param name="country">
        /// The country.
        /// </param>
        public Address(string city, Country country) : this(string.Empty, string.Empty, city, country)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="street">
        /// The street.
        /// </param>
        /// <param name="zip">
        /// The zip.
        /// </param>
        /// <param name="city">
        /// The city.
        /// </param>
        /// <param name="country">
        /// The country.
        /// </param>
        public Address(string street, string zip, string city, Country country)
        {
            this.Street = street;
            this.City = city;
            this.Zip = zip;
            this.Country = country;
        }

        /// <summary>
        /// Gets the street.
        /// </summary>
        public string Street { get; private set; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// Gets the zip.
        /// </summary>
        public string Zip { get; private set; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        public Country Country { get; private set; }

        /// <summary>
        /// Simple validation to see if a zip code is somewhat valid.
        /// </summary>
        /// <param name="zipCode">
        /// The zip code.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsValidZip(string zipCode)
        {
            // Simple check for any numerical zip allowing up to 9 characters and optional space/dash
            // And strict check for either canada or netherland based zip (which contains letters).
            // Reference: http://www.barnesandnoble.com/help/cds2.asp?PID=8134#specialFormat
            var regex = new Regex(@"^(([0-9][0-9 \-]{1,7}[0-9])|([A-Z][0-9][A-Z] [0-9][A-Z][0-9])|([0-9]{4} [A-Z]{2}))\z");
            return regex.IsMatch(zipCode);
        }

        /// <summary>
        /// Returns a string representation of the address.
        /// Format parameter order; street, zip, city, country.
        /// </summary>
        /// <param name="format">
        /// String format.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToString(string format = "{0}\n{1} {2}\n{3}")
        {
            return string.Format(format, this.Street, this.Zip, this.City, this.Country);
        }
    }
}
