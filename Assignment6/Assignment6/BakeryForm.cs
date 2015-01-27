// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BakeryForm.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The bakery form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment6
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The bakery form.
    /// </summary>
    public partial class BakeryForm : Form
    {
        public BakeryForm()
        {
            this.InitializeComponent();

            this.cmbItemType.DataSource = Enum.GetValues(typeof(ProductType));
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Format += delegate(object sender, ListControlConvertEventArgs e) { e.Value = e.Value.ToString().Replace('_', ' '); };
        }

        /// <summary>
        /// The btn ok click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnOkClick(object sender, EventArgs e)
        {
            double price, unit;

            if (!this.ValidateInputAndShowErrors(out price, out unit))
            {
                return;
            }

            var bakery = BakeryMachine.CreateBakery((ProductType)cmbItemType.SelectedItem, price, unit);

            txtOutput.Text = bakery.ToString();
        }

        /// <summary>
        /// The validate input and show errors.
        /// </summary>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="unit">
        /// The unit.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool ValidateInputAndShowErrors(out double price, out double unit)
        {
            unit = price = -1;

            if (!double.TryParse(txtUnitCount.Text, out unit))
            {
                ShowErrorMessage("Invalid unit entered", "Validation Error");
                return false;
            }

            if (!double.TryParse(txtPrice.Text, out price))
            {
                ShowErrorMessage("Invalid price entered", "Validation Error");
                return false;
            }

            return true;
        }

        private void CmbItemTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            lblUnitDesc.Text = BakeryMachine.GetBakeryUnit((ProductType)cmbItemType.SelectedItem);
        }

        /// <summary>
        /// Shows an error message with an error icon and a standard Ok button.
        /// </summary>
        /// <param name="msg">
        /// Message to show in dialog.
        /// </param>
        /// <param name="caption">
        /// Title on dialog.
        /// </param>
        public static void ShowErrorMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
