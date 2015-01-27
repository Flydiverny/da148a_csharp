// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITypedInformation.cs" company="Markus Maga">
//   AC7525 Markus Maga 18-08-13
// </copyright>
// <summary>
//   The information type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contacts
{
    /// <summary>
    /// The information type.
    /// </summary>
    public enum InformationType
    {
        /// <summary>
        /// Work type, for work information such as work phone number.
        /// </summary>
        Work,

        /// <summary>
        /// Private type, for personal/private information such as private phone number.
        /// </summary>
        Private,

        /// <summary>
        /// Unknown type
        /// </summary>
        Unknown
    }

    /// <summary>
    /// The TypedInformation interface.
    /// </summary>
    public interface ITypedInformation
    {
        /// <summary>
        /// Gets the information type.
        /// </summary>
        InformationType Type { get; }
    }
}
