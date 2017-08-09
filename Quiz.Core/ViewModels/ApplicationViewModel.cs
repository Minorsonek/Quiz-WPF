using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core
{
    /// <summary>
    /// The application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Register;

        /// <summary>
        /// The current page of the side menu
        /// </summary>
        public ApplicationPage SideMenuCurrentPage { get; private set; } = ApplicationPage.Help;

        /// <summary>
        /// The username of the quiz player
        /// </summary>
        public string Username { get; set; } = "Niepodpisany";

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;

        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page">The page to go to</param>
        public void GoToPage(ApplicationPage page)
        {
            // Set the current page
            CurrentPage = page;

            // Show side menu or not?
            SideMenuVisible = page == ApplicationPage.Main;
        }

        /// <summary>
        /// Navigates to the specified side menu page
        /// </summary>
        /// <param name="page">The page to go to</param>
        public void GoToSideMenuPage(ApplicationPage page)
        {
            // Set the current page
            SideMenuCurrentPage = page;
        }
    }
}
