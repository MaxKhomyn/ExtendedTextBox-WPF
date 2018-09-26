using System.Windows.Data;
using System.Data;
using System;

namespace TextBoxStyle.Converters
{
    public class ExpressionToDoubleConverter : IValueConverter
    {
        #region Fields

        private DataTable _DataTable = new DataTable();

        #endregion Fields

        #region Methods

        //Set value to TextBox
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => value;

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                //Compute value from expression and convert it to double;
                return System.Convert.ToDouble(_DataTable.Compute(value.ToString(), null));
            }
            catch
            {
                // If (Expression with mistakes) return null,
                //because double is not nullable type TextBox throw exception and won`t update property
                return null;
            }
        }

        #endregion Methods
    }
}