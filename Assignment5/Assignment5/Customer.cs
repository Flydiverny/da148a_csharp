// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The customer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System;

    using Contacts;

    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="contact">
        /// The contact.
        /// </param>
        public Customer(Contact contact)
        {
            this.Guid = Guid.NewGuid();
            this.Contact = contact;
        }

        /// <summary>
        /// Gets the guid.
        /// </summary>
        public Guid Guid { get; private set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        public Contact Contact { get; set; }
    }
}
