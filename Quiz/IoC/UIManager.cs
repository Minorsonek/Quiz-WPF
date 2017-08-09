using System;
using System.Threading.Tasks;
using Quiz.Core;
using System.Windows;

namespace Quiz
{
    /// <summary>
    /// The applications implementation of the <see cref="IUIManager"/>
    /// </summary>
    public class UIManager : IUIManager
    {
        /// <summary>
        /// Displays a single message box to the user
        /// </summary>
        /// <param name="viewModel">The view model</param>
        /// <returns></returns>
        public Task ShowMessage(MessageBoxDialogViewModel viewModel)
        {
            return new DialogMessageBox().ShowDialog(viewModel);
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <returns></returns>
        public void CloseApplication()
        { 
            // Close the whole application
            Application.Current.Shutdown();
        }
    }
}