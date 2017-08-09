using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Quiz.Core
{
    /// <summary>
    /// The View Model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The name of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// True if error message should be shown
        /// </summary>
        public bool ErrorMessage { get; set; } = false;

        #endregion

        #region Commands

        /// <summary>
        /// The command to go to the main page
        /// </summary>
        public ICommand ToMainPageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterViewModel()
        {
            // Create commands
            ToMainPageCommand = new RelayCommand(async () => await ChangePageAsync());
        }

        #endregion

        /// <summary>
        /// Takes the user to the main page
        /// </summary>
        public async Task ChangePageAsync()
        {
            // Set username from text input
            IoC.Application.Username = Username;

            // Then go to main page
            IoC.Application.GoToPage(ApplicationPage.Main);

            await Task.Delay(1);
        }
    }
}
