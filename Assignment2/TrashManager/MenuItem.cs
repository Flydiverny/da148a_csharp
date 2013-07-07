// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuItem.cs" company="Markus Maga">
//   Markus Maga
// </copyright>
// <summary>
//   Implementation of my IMenuItem, wraps a IStartable class and runs it on execute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrashManager
{
    using TrashManager.MenuManager;

    /// <summary>
    /// MenuItem which wraps a <see cref="IStartable"/> class.
    /// </summary>
    /// <typeparam name="T">
    /// Program to start when this menu item is chosen.
    /// </typeparam>
    public class MenuItem<T> : IMenuItem where T : IStartable, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem{T}"/> class.
        /// </summary>
        /// <param name="text">
        /// Text describing this menu item.
        /// </param>
        public MenuItem(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Gets or (privately) sets the text describing this menu item.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Executes this menu item by starting the program T.
        /// </summary>
        public void Execute()
        {
            new T().Start();
        }
    }
}