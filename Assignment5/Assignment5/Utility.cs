// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The utility.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment5
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// The utility.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Splits input data and trims whitespace.
        /// </summary>
        /// <param name="box">
        /// Textbox to get input from.
        /// </param>
        /// <param name="separator">
        /// The separator.
        /// </param>
        /// <returns>
        /// <see cref="string[]"/>.
        /// </returns>
        public static IEnumerable<string> SplitAndTrim(TextBox box, char separator = ';')
        {
            var splitted = box.Text.Split(separator);

            for (var i = 0; i < splitted.Length; i++)
            {
                splitted[i] = splitted[i].Trim();
            }

            return splitted;
        }

        /// <summary>
        /// Converts a collection to a single string, values separated by separator.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <param name="separator">
        /// The separator.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string CollectionToString(IEnumerable collection, string separator = "; ")
        {
            var sb = new StringBuilder();
            foreach (var obj in collection)
            {
                sb.Append(obj.ToString());
                sb.Append(separator);
            }

            // Remove the last separator
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - separator.Length, separator.Length);
            }

            return sb.ToString();
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
