// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System.Windows.Forms;

    using Contacts;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The customer presenter.
        /// </summary>
        private readonly CustomerPresenter customerPresenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm() : this(new CustomerPresenter())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        /// <param name="customerPresenter">
        /// The customer presenter.
        /// </param>
        public MainForm(CustomerPresenter customerPresenter)
        {
            this.customerPresenter = customerPresenter;

            this.InitializeComponent();

            this.lstCustomers.Columns.AddRange(customerPresenter.ColumnHeaders);

            this.lstCustomers.Items.AddRange(customerPresenter.GetCustomers());
        }

        /// <summary>
        /// The button add click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAddClick(object sender, System.EventArgs e)
        {
            this.ShowContactForm();
        }

        /// <summary>
        /// The button edit click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnEditClick(object sender, System.EventArgs e)
        {
            var customer = this.GetSelectedCustomer();

            if (customer != null)
            {
                this.ShowContactForm(customer);
            }
            else
            {
                Utility.ShowErrorMessage("No customer was selected.", "Invalid selection.");
            }
        }

        /// <summary>
        /// Shows the contact form and handles its return status.
        /// </summary>
        /// <param name="customer">
        /// The customer data to show in contacts form.
        /// </param>
        private void ShowContactForm(Customer customer = null)
        {
            var contactForm = new ContactForm(customer == null ? new Contact() : customer.Contact);

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                if (customer != null)
                {
                    customer.Contact = contactForm.Contact;
                }
                else
                {
                    this.customerPresenter.Add(contactForm.Contact);
                }

                this.UpdateList();
            }
        }

        /// <summary>
        /// The button delete click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnDeleteClick(object sender, System.EventArgs e)
        {
            this.customerPresenter.Remove(this.GetSelectedCustomer());
            this.UpdateList();
        }

        /// <summary>
        /// The get selected customer.
        /// </summary>
        /// <returns>
        /// The <see cref="Customer"/>.
        /// </returns>
        private Customer GetSelectedCustomer()
        {
            var items = this.lstCustomers.SelectedItems;

            if (items.Count > 0)
            {
                return (Customer)items[0].Tag;
            }

            return null;
        }

        /// <summary>
        /// Clears the customer registry list and gets a new list from the presenter.
        /// </summary>
        private void UpdateList()
        {
            this.lstCustomers.Items.Clear();
            this.lstCustomers.Items.AddRange(this.customerPresenter.GetCustomers());
        }
    }
}
