// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerManager.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The customer manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System.Collections.Generic;

    using Contacts;

    /// <summary>
    /// The customer manager.
    /// </summary>
    public class CustomerManager
    {
        /// <summary>
        /// The customers.
        /// </summary>
        private readonly List<Customer> customers;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerManager"/> class.
        /// </summary>
        public CustomerManager()
        {
            this.customers = new List<Customer>();
        }

        /// <summary>
        /// Adds a customer to the registry.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        public void Add(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// Adds contact information to the registry by creating a new customer.
        /// </summary>
        /// <param name="contact">
        /// The contact.
        /// </param>
        public void Add(Contact contact)
        {
            this.customers.Add(new Customer(contact));
        }

        /// <summary>
        /// Removes a customer from the registry.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Remove(Customer customer)
        {
            return this.customers.Remove(customer);
        }

        /// <summary>
        /// The get customers.
        /// </summary>
        /// <returns>
        /// The <see cref="Customer[]"/>.
        /// </returns>
        public Customer[] GetCustomers()
        {
            return this.customers.ToArray();
        }
    }
}
