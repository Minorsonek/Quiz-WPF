using Quiz.Core;
using System.Windows;

namespace Quiz
{
    /// <summary>
    /// A base page for side menu pages to gain base functionality
    /// </summary>
    public class BaseSideMenuPage : BasePage
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseSideMenuPage()
        {
            // If we are animating in, hide to begin with
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            // Change default animations since side menu page is different sized
            PageLoadAnimation = PageAnimation.FadeIn;
            PageUnloadAnimation = PageAnimation.FadeOut;

            // Listen out for the page loading
            Loaded += BaseSideMenuPage_Loaded;
        }

        #endregion

        private async void BaseSideMenuPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // If we are setup to animate out on load
            if (ShouldAnimateOut)
                // Animate the page out
                await AnimateOutAsync();
            else
                // Animate the page in
                await AnimateInAsync();
        }
    }

    /// <summary>
    /// A base side menu page with added ViewModel support
    /// </summary>
    public class BaseSideMenuPage<VM> : BaseSideMenuPage
        where VM : BaseViewModel, new()
    {
        #region Private Member

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => mViewModel;
            set
            {
                // If nothing has changed, return
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set the data context for this page
                DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseSideMenuPage() : base()
        {
            // Create a default view model
            ViewModel = new VM();
        }

        #endregion
    }
}
