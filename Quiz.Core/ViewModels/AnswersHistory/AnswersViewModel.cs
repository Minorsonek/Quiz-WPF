using System.Collections.ObjectModel;

namespace Quiz.Core
{
    /// <summary>
    /// The View Model for an answer history control which contains answer items
    /// </summary>
    public class AnswersViewModel : BaseViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton instance of this view model
        /// </summary>
        public static AnswersViewModel Instance { get; set; } = new AnswersViewModel
        {
            Items = new ObservableCollection<AnswersItemViewModel>()
        };

        #endregion

        #region Public Properties

        /// <summary>
        /// The list (collection) of items in this control
        /// </summary>
        public ObservableCollection<AnswersItemViewModel> Items { get; set; }

        #endregion
    }
}
