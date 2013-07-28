// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputUtility.cs" company="Markus Maga">
//   AC7525 Markus Maga 21-07-13
// </copyright>
// <summary>
//   The input utility.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment3
{
    /// <summary>
    /// The input utility.
    /// </summary>
    public class InputUtility
    {
        /// <summary>
        /// Converts a string to an integer.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="intOutValue">
        /// The parsed integer value.
        /// </param>
        /// <returns>
        /// True if successful. <see cref="bool"/>.
        /// </returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue)
        {
            return int.TryParse(stringToConvert, out intOutValue);
        }

        /// <summary>
        /// Converts a string to a integer, and validates if its inside the min and max limit specified.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="intOutValue">
        /// The parsed integer value.
        /// </param>
        /// <param name="minLimit">
        /// Minimum limit to validate.
        /// </param>
        /// <param name="maxLimit">
        /// Maximum limit to validate.
        /// </param>
        /// <returns>
        /// True if parsed and within min and max <see cref="bool"/>.
        /// </returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimit, int maxLimit)
        {
            var parsed = GetInteger(stringToConvert, out intOutValue);

            return parsed && intOutValue >= minLimit && intOutValue <= maxLimit;
        }

        /// <summary>
        /// Converts a string to a integer, and validates if its larger than the min limit specified.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="intOutValue">
        /// The parsed integer value.
        /// </param>
        /// <param name="minLimit">
        /// Minimum limit to validate.
        /// </param>
        /// <returns>
        /// True if parsed and larger than min <see cref="bool"/>.
        /// </returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimit)
        {
            return GetInteger(stringToConvert, out intOutValue, minLimit, int.MaxValue);
        }

        /// <summary>
        /// Converts a string to an integer and returns true only if the conversion is successful and the value is positive.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="intOutValue">
        /// The parsed double value
        /// </param>
        /// <returns>
        /// True if value was parsed and positive <see cref="bool"/>.
        /// </returns>
        public static bool GetPositiveInteger(string stringToConvert, out int intOutValue)
        {
            return GetInteger(stringToConvert, out intOutValue) && IsPositive(intOutValue);
        }

        /// <summary>
        /// Converts a string to a double.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="dblOutvalue">
        /// The parsed double value.
        /// </param>
        /// <returns>
        /// True if successful. <see cref="bool"/>.
        /// </returns>
        public static bool GetDouble(string stringToConvert, out double dblOutvalue)
        {
            return double.TryParse(stringToConvert, out dblOutvalue);
        }

        /// <summary>
        /// Converts a string to a double, and validates if its inside the min and max limit specified.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="dblOutvalue">
        /// The parsed double value.
        /// </param>
        /// <param name="minLimit">
        /// Minimum limit to validate.
        /// </param>
        /// <param name="maxLimit">
        /// Maximum limit to validate.
        /// </param>
        /// <returns>
        /// True if parsed and within min and max <see cref="bool"/>.
        /// </returns>
        public static bool GetDouble(string stringToConvert, out double dblOutvalue, double minLimit, double maxLimit)
        {
            var parsed = GetDouble(stringToConvert, out dblOutvalue);

            return parsed && dblOutvalue >= minLimit && dblOutvalue <= maxLimit;
        }

        /// <summary>
        /// Converts a string to a double, and validates if its larger than the min limit specified.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="dblOutvalue">
        /// The parsed double value.
        /// </param>
        /// <param name="minLimit">
        /// Minimum limit to validate.
        /// </param>
        /// <returns>
        /// True if parsed and larger than min <see cref="bool"/>.
        /// </returns>
        public static bool GetDouble(string stringToConvert, out double dblOutvalue, double minLimit)
        {
            return GetDouble(stringToConvert, out dblOutvalue, minLimit, double.MaxValue);
        }


        /// <summary>
        /// Converts a string to a double and returns true only if the conversion is successful and the value is positive.
        /// </summary>
        /// <param name="stringToConvert">
        /// The string to convert.
        /// </param>
        /// <param name="dblOutValue">
        /// The parsed double value
        /// </param>
        /// <returns>
        /// True if value was parsed and positive <see cref="bool"/>.
        /// </returns>
        public static bool GetPositiveDouble(string stringToConvert, out double dblOutValue)
        {
            return GetDouble(stringToConvert, out dblOutValue) && IsPositive(dblOutValue);
        }

        /// <summary>
        /// Checks if a number is positive or not.
        /// </summary>
        /// <param name="nbr">
        /// Number to validate.
        /// </param>
        /// <returns>
        /// True if positive. <see cref="bool"/>.
        /// </returns>
        public static bool IsPositive(double nbr)
        {
            return nbr >= 0d;
        }

        /// <summary>
        /// Checks to see if a string is null, empty or just whitespace.
        /// </summary>
        /// <param name="str">
        /// String to validate.
        /// </param>
        /// <returns>
        /// True if empty. <see cref="bool"/>.
        /// </returns>
        public static bool IsEmpty(string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
