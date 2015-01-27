// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Email.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   Defines the Email type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contacts
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Simple class for an Email.
    /// </summary>
    public class Email : ITypedInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email"/> class.
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        public Email(string address, InformationType type = InformationType.Unknown)
        {
            this.Address = address;
            this.Type = type;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public InformationType Type { get; private set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Validates email address.
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsValid(string address)
        {
            // Email regex pattern from http://www.rhyous.com/2010/06/15/csharp-email-regular-expression/
            var reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");

            return reg.IsMatch(address);
        }

        /// <summary>
        /// Returns the email address
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Address;
        }
    }
}
