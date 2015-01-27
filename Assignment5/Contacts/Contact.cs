// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The contact.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contacts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contact information class.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        private readonly List<Email> emails;

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        private readonly List<Phone> phoneNbrs;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
            this.emails = new List<Email>();
            this.phoneNbrs = new List<Phone>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="lastName">
        /// The last name.
        /// </param>
        public Contact(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// The full name.
        /// </summary>
        /// <param name="format">
        /// The format, use by string.Format, FirstName is {0} and LastName {1}
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string FullName(string format = "{0} {1}")
        {
            return string.Format(format, this.FirstName, this.LastName);
        }

        /// <summary>
        /// The add phone number.
        /// </summary>
        /// <param name="phone">
        /// The phone.
        /// </param>
        public void AddPhoneNbr(Phone phone)
        {
            this.phoneNbrs.Add(phone);
        }

        /// <summary>
        /// The add email.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        public void AddEmail(Email email)
        {
            this.emails.Add(email);
        }

        /// <summary>
        /// Returns an array of email addresses.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="Email[]"/>.
        /// </returns>
        public Email[] GetEmails(InformationType? type = null)
        {
            return this.GetTypedCollection(this.emails, type);
        }

        /// <summary>
        /// Returns an array of phone numbers.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="Phone[]"/>.
        /// </returns>
        public Phone[] GetPhoneNbrs(InformationType? type = null)
        {
            return this.GetTypedCollection(this.phoneNbrs, type);
        }

        /// <summary>
        /// Returns an array of ITypedInformation.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="ITypedInformation[]"/>.
        /// </returns>
        private T[] GetTypedCollection<T>(IEnumerable<T> collection, InformationType? type = null) where T : ITypedInformation
        {
            return collection.Where(typed => type == null || typed.Type == type).ToArray();
        }
    }
}
