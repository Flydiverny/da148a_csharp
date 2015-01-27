// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactForm.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The contact form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Contacts;

    /// <summary>
    /// The contact form.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// The validation cases.
        /// </summary>
        private List<ValidationCase> validationCases;

        /// <summary>
        /// Prevent window from closing if validation errors.
        /// </summary>
        private bool allowClose = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactForm"/> class.
        /// Used to create a new contact.
        /// </summary>
        public ContactForm() : this(new Contact())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactForm"/> class.
        /// </summary>
        /// <param name="contact">
        /// Contact to use for prefilling of textboxes.
        /// </param>
        public ContactForm(Contact contact)
        {
            this.Contact = contact;

            this.InitializeComponent();

            this.SetupValidationCases();
            this.SetupCountryList();

            this.FillTextFieldsFromContact();

            this.Closing += this.ContactFormOnClosing;
        }

        /// <summary>
        /// Gets the contact used in the contact form.
        /// </summary>
        public Contact Contact { get; private set; }

        /// <summary>
        /// Performs validation on all validation cases and shows error message if invalid.
        /// </summary>
        /// <param name="cases">
        /// The cases.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool PerformValidation(params ValidationCase[] cases)
        {
            foreach (var c in cases)
            {
                if ((c.TextBox.Text.Length > 0 || c.Required) && !Validate(c, true))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if a a validation case validates. Can optionally show the validation case error message.
        /// </summary>
        /// <param name="c">
        /// The validation case.
        /// </param>
        /// <param name="showError">
        /// Whether the error message should be shown on invalid data. Default: false.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool Validate(ValidationCase c, bool showError = false)
        {
            var result = c.Validate();

            if (!result && showError)
            {
                Utility.ShowErrorMessage(c.ErrorMsg, "Validation error");
            }

            return result;
        }

        /// <summary>
        /// Fills all form fields with data from the current contact information.
        /// </summary>
        private void FillTextFieldsFromContact()
        {
            this.txtFName.Text = Contact.FirstName;
            this.txtLName.Text = Contact.LastName;

            this.txtPhonePrivate.Text = Utility.CollectionToString(Contact.GetPhoneNbrs(InformationType.Private));
            this.txtPhoneWork.Text = Utility.CollectionToString(Contact.GetPhoneNbrs(InformationType.Work));

            this.txtEmailPrivate.Text = Utility.CollectionToString(Contact.GetEmails(InformationType.Private));
            this.txtEmailWork.Text = Utility.CollectionToString(Contact.GetEmails(InformationType.Work));

            if (Contact.Address != null)
            {
                this.txtStreet.Text = Contact.Address.Street;
                this.txtCity.Text = Contact.Address.City;
                this.txtZip.Text = Contact.Address.Zip;

                this.cmbCountry.SelectedItem = Contact.Address.Country;
            }
        }

        /// <summary>
        /// Populates the combo box containing countries.
        /// </summary>
        private void SetupCountryList()
        {
            this.cmbCountry.DataSource = Enum.GetValues(typeof(Country));

            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Format += delegate(object sender, ListControlConvertEventArgs e) { e.Value = e.Value.ToString().Replace('_', ' '); };
        }

        /// <summary>
        /// The contact form on closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ContactFormOnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!this.allowClose)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Creates all validation cases for easy future validation.
        /// </summary>
        private void SetupValidationCases()
        {
            this.validationCases = new List<ValidationCase>
                {
                    new ValidationCase(this.txtFName, string.IsNullOrEmpty, "Please enter a First Name!", true, true, 1),
                    new ValidationCase(this.txtPhonePrivate, Phone.IsValid, "The private phone number(s) you entered seems to be incorrect!", false),
                    new ValidationCase(this.txtPhoneWork, Phone.IsValid, "The work phone number(s) you entered seems to be incorrect!", false),
                    new ValidationCase(this.txtEmailPrivate, Email.IsValid, "The private emails address(es) you entered seems to be incorrect!", false),
                    new ValidationCase(this.txtEmailWork, Email.IsValid, "The work email address(es) you entered seems to be incorrect!", false),
                    new ValidationCase(this.txtZip, Address.IsValidZip, "The zip code you entered seems to be incorrect!", false, false, 1),
                };
        }

        private ValidationCase FindValidationCase(TextBox box)
        {
            foreach (var validationCase in validationCases)
            {
                if (validationCase.TextBox.Equals(box))
                {
                    return validationCase;
                }
            }

            throw new Exception("There's no validation case for this textbox.");
        }

        /// <summary>
        /// Checks if entered value is valid when text changes.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxTextChanged(object sender, System.EventArgs e)
        {
            Validate(this.FindValidationCase((TextBox)sender));
        }

        /// <summary>
        /// The button save click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (!PerformValidation(this.validationCases.ToArray()))
            {
                return;
            }

            this.Contact = this.InputToNewContact();

            this.allowClose = true;
        }

        /// <summary>
        /// Creates a new contact from all the entered user input.
        /// </summary>
        /// <returns>
        /// The <see cref="Contact"/>.
        /// </returns>
        private Contact InputToNewContact()
        {
            var contact = new Contact(this.txtFName.Text, this.txtLName.Text);

            foreach (var nbr in Utility.SplitAndTrim(this.txtPhonePrivate))
            {
                contact.AddPhoneNbr(new Phone(nbr, InformationType.Private));
            }

            foreach (var nbr in Utility.SplitAndTrim(this.txtPhoneWork))
            {
                contact.AddPhoneNbr(new Phone(nbr, InformationType.Work));
            }

            foreach (var email in Utility.SplitAndTrim(this.txtEmailPrivate))
            {
                contact.AddEmail(new Email(email, InformationType.Private));
            }

            foreach (var email in Utility.SplitAndTrim(this.txtEmailWork))
            {
                contact.AddEmail(new Email(email, InformationType.Work));
            }

            contact.Address = new Address(this.txtStreet.Text, this.txtZip.Text, this.txtCity.Text, (Country)cmbCountry.SelectedItem);

            return contact;
        }

        /// <summary>
        /// The button cancel click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
           this.allowClose = true;
        }
    }
}
