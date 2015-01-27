// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerPresenter.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The customer presenter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System.Windows.Forms;

    using Contacts;

    /// <summary>
    /// The customer presenter.
    /// </summary>
    public class CustomerPresenter : CustomerManager
    {
        /// <summary>
        /// Columns used by the list view.
        /// </summary>
        private static readonly string[] Columns = new[]
                                                      {
                                                          "ID", "Name", "Street", "Zip", "City", "Country",
                                                          "Phone (Private)", "Email (Private)", "Phone (Work)",
                                                          "Email (Work)"
                                                      };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPresenter"/> class.
        /// </summary>
        public CustomerPresenter()
        {
            this.SetupColumnHeaders(Columns);
        }

        /// <summary>
        /// Gets the column headers.
        /// </summary>
        public ColumnHeader[] ColumnHeaders { get; private set; }

        /// <summary>
        /// Gets customers from the customer manager and converts them to list view items.
        /// </summary>
        /// <returns>
        /// List view items <see cref="ListViewItem[]"/>.
        /// </returns>
        public new ListViewItem[] GetCustomers()
        {
            var customers = base.GetCustomers();

            var listViewItems = new ListViewItem[customers.Length];

            for (var i = 0; i < customers.Length; i++)
            {
                listViewItems[i] = CreateListItem(customers[i]);
            }

            return listViewItems;
        }

        /// <summary>
        /// Creates a list item out of a Customer.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <returns>
        /// List view item <see cref="ListViewItem"/>.
        /// </returns>
        private static ListViewItem CreateListItem(Customer customer)
        {
            return new ListViewItem(CustomerToStringArray(customer)) { Tag = customer };
        }

        /// <summary>
        /// Converts a contact to a string array matching the columns, can be used to create a list view item.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <returns>
        /// String array matching <see cref="Columns"/> <see cref="string[]"/>.
        /// </returns>
        private static string[] CustomerToStringArray(Customer customer)
        {
            var columns = new string[Columns.Length];

            columns[0] = customer.Guid.ToString();
            columns[1] = customer.Contact.FullName();
            columns[2] = customer.Contact.Address.Street;
            columns[3] = customer.Contact.Address.Zip;
            columns[4] = customer.Contact.Address.City;
            columns[5] = customer.Contact.Address.Country.ToString().Replace('_', ' ');
            columns[6] = Utility.CollectionToString(customer.Contact.GetPhoneNbrs(InformationType.Private));
            columns[7] = Utility.CollectionToString(customer.Contact.GetEmails(InformationType.Private));
            columns[8] = Utility.CollectionToString(customer.Contact.GetPhoneNbrs(InformationType.Work));
            columns[9] = Utility.CollectionToString(customer.Contact.GetEmails(InformationType.Work));

            return columns;
        }

        /// <summary>
        /// Setups the column headers.
        /// </summary>
        /// <param name="columns">
        /// The columns.
        /// </param>
        private void SetupColumnHeaders(string[] columns)
        {
            this.ColumnHeaders = new ColumnHeader[columns.Length];

            for (var i = 0; i < columns.Length; i++)
            {
                this.ColumnHeaders[i] = new ColumnHeader() { Text = columns[i] };
            }
        }
    }
}
