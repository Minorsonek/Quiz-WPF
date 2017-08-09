using System.Collections.Generic;

namespace Quiz.Core
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class PopupDropMenuViewModel : BasePopupViewModel
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PopupDropMenuViewModel()
        {
            // Add items to popup menu
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>(new[]
                {
                    new MenuItemViewModel { Text = "Pomoc", Icon = IconType.Help },
                    new MenuItemViewModel { Text = "Historia odpowiedzi", Icon = IconType.History },
                })
            };
        }

        #endregion


    }
}
