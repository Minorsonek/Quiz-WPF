using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Core
{
    /// <summary>
    /// A view model for the side menu
    /// </summary>
    public class SideMenuViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The text to display in the side menu
        /// </summary>
        public string HelpText { get; set; } = 
            "Witaj w Quizie." + "\n" +
            "Aby rozpoczac, kliknij przycisk \"Start\"." + "\n" + 
            "Wyswietli sie wtedy pytanie, aby odpowiedziec kliknij jeden z przyciskow A B C D." + "\n\n" + "" +
            "Program by Patryk Mikulski" + "\n" + 
            "All rights reserved.";

        /// <summary>
        /// The username to display on sidebar
        /// </summary>
        public string Username => IoC.Application.Username;

        /// <summary>
        /// True to show the drop menu, false to hide it
        /// </summary>
        public bool DropMenuVisible { get; set; }

        /// <summary>
        /// True if any popup menus are visible
        /// </summary>
        public bool AnyPopupVisible => DropMenuVisible;

        /// <summary>
        /// The view model for the drop menu
        /// </summary>
        public PopupDropMenuViewModel DropMenu { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the drop menu button is clicked
        /// </summary>
        public ICommand DropMenuButtonCommand { get; set; }

        /// <summary>
        /// The command for when the area outside of any popup is clicked
        /// </summary>
        public ICommand PopupClickawayCommand { get; set; }

        #endregion

        #region Constructor

        public SideMenuViewModel()
        {
            // Create commands
            DropMenuButtonCommand = new RelayCommand(DropMenuButton);
            PopupClickawayCommand = new RelayCommand(PopupClickaway);

            // Make a default menu
            DropMenu = new PopupDropMenuViewModel();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// When the drop menu button is clicked show/hide the menu popup
        /// </summary>
        public void DropMenuButton()
        {
            // Toggle menu visibility
            DropMenuVisible ^= true;
        }

        /// <summary>
        /// When the popup clickaway area is clicked hide any popups
        /// </summary>
        public void PopupClickaway()
        {
            // Hide drop menu
            DropMenuVisible = false;
        }

        #endregion
    }
}
