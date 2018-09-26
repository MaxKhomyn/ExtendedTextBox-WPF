using System.Globalization;
using System.Windows.Data;
using System.Windows;
using System;

namespace TextBoxStyle.Converters
{
    public class BoolToVisibilityHiddenConverter : IValueConverter
    {
        #region Fields

        public Visibility FalseValue { get; set; } = Visibility.Hidden;

        #endregion Fields

        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Boolean) return (bool)value == false ? FalseValue : Visibility.Visible;
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("BooleanToVisibilityHiddenConverter can only be used OneWay.");
        }

        #endregion Methods
    }
}