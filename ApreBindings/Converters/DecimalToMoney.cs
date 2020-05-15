using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace ApreBindings.Converters
{
    using Xamarin.Forms;
    public class DecimalToMoney : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (decimal)value;
            return valor.ToString("C");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            return valor.Remove(0);
        }
    }
}
