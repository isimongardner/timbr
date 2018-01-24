using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Timbr.Converters
{
    public class DateTimeToTimeSpanConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                DateTime dt = (DateTime)value;
                TimeSpan? ts = DateTimeConverter.DateTimeToTimeSpan(dt);
                return ts.GetValueOrDefault(TimeSpan.MinValue);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return TimeSpan.MinValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                TimeSpan ts = (TimeSpan)value;
                DateTime? dt = DateTimeConverter.TimeSpanToDateTime(ts);
                return dt.GetValueOrDefault(DateTime.MinValue);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return DateTime.MinValue;
            }
        }
    }
}
