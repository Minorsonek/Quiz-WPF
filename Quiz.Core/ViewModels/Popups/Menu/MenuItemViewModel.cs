using System.Windows.Input;

namespace Quiz.Core
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The text to display for the menu item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The icon for this menu item
        /// </summary>
        public IconType Icon { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to change page after clicking item in popup menu
        /// </summary>
        public ICommand ChangePageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuItemViewModel()
        {
            // Create commands
            ChangePageCommand = new RelayCommand(ChangePage);
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Changes page based on which item was clicked
        /// </summary>
        private void ChangePage()
        {
            // Check which item was clicked and go to right page
            if (this.Icon == IconType.Help)
                IoC.Application.GoToSideMenuPage(ApplicationPage.Help);
            else if (this.Icon == IconType.History)
                IoC.Application.GoToSideMenuPage(ApplicationPage.History);

            // TODO: After successful operation, hide popup menu
        }

        #endregion
    }
}
