// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMenuItem.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Interface for a MenuItem used by <see cref="Menu" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager.MenuManager
{
    /// <summary>
    /// Interface for a MenuItem used by <see cref="Menu"/>.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets text describing the menu item.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Executes the menu item.
        /// </summary>
        void Execute();
    }
}
