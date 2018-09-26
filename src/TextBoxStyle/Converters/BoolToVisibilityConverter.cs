using System.Windows.Data;
using System.Windows;
using System;

namespace TextBoxStyle.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is Boolean && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is Visibility && (Visibility)value == Visibility.Visible) ? true : false;
        }

        #endregion Methods
    }
}