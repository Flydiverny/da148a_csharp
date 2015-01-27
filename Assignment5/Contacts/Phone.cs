// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Phone.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The phone.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contacts
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Phone number class.
    /// </summary>
    public class Phone : ITypedInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone"/> class.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        public Phone(string number, InformationType type = InformationType.Unknown)
        {
            this.Number = number;
            this.Type = type;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public InformationType Type { get; private set; }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsValid(string number)
        {
            var regex = new Regex(@"^([0-9 \-+]){5,20}\z");
            return regex.IsMatch(number);
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <param name="format">
        /// The format.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToString(string format = "{0}")
        {
            return string.Format(format, this.Number);
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
