using System;
using System.Globalization;
using System.Windows;
using Quiz.Core;

namespace Quiz
{
    /// <summary>
    /// A converter that takes in a <see cref="BaseViewModel"/>and returns the specific UI control 
    /// that should bind to that type of ViewModel
    /// </summary>
    public class PopupContentConverter : BaseValueConverter<PopupContentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is PopupDropMenuViewModel basePopup)
                return new VerticalMenu { DataContext = basePopup.Content };

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
