using Quiz.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Quiz
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Register:
                    return new RegisterPage();

                case ApplicationPage.Main:
                    return new MainPage();

                case ApplicationPage.Help:
                    return new HelpPage();

                case ApplicationPage.History:
                    return new HistoryPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
