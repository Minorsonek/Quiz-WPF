using Quiz.Core;
using System.Windows.Controls;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for SideMenuControl.xaml
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();

            DataContext = new SideMenuViewModel();
        }
    }
}
