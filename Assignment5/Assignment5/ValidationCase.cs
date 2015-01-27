// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationCase.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   Defines the ValidationCase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The validation case.
    /// </summary>
    public class ValidationCase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationCase"/> class.
        /// </summary>
        /// <param name="txt">
        /// The textbox.
        /// </param>
        /// <param name="validator">
        /// The validator.
        /// </param>
        /// <param name="error">
        /// The error.
        /// </param>
        /// <param name="required">
        /// The required.
        /// </param>
        /// <param name="maxcount">
        /// The max count.
        /// </param>
        public ValidationCase(TextBox txt, Func<string, bool> validator, string error, bool required = true, bool inverse = false, int maxcount = -1)
        {
            this.TextBox = txt;
            this.Validator = validator;
            this.ErrorMsg = error;
            this.MaxCount = maxcount;
            this.Required = required;
            this.Inverse = inverse;
        }

        public TextBox TextBox { get; private set; }

        public Func<string, bool> Validator { get; private set; }

        public string ErrorMsg { get; private set; }

        public int MaxCount { get; private set; }

        public bool Required { get; private set; }

        public bool Inverse { get; private set; }

        /// <summary>
        /// Checks if a textbox input is valid, will mark invalid input red.
        /// </summary>
        /// <param name="textBox">
        /// The text box to fetch value from and color red if invalid input.
        /// </param>
        /// <param name="func">
        /// Validation function, returning boolean taking parameter string.
        /// </param>
        /// <param name="maxcount">
        /// Max count allowed in input field (separated by ;).
        /// </param>
        /// <param name="inverse">
        /// The inverse.
        /// </param>
        /// <param name="separator">
        /// The separator, default ';'
        /// </param>
        /// <returns>
        /// True if valid, false if invalid <see cref="bool"/>.
        /// </returns>
        public bool Validate(char separator = ';')
        {
            // Assume value is separated by semicolon and split it up.
            var values = TextBox.Text.Split(separator);

            // Lets be Aggressive, assume its invalid to begin with.
            TextBox.ForeColor = Color.Red;

            if (MaxCount > -1 && values.Length > MaxCount)
            {
                return false;
            }

            if (values.Any(s => !(Validator(s.Trim()) ^ Inverse)))
            {
                return false;
            }

            TextBox.ResetForeColor();
            return true;
        }
    }
}
