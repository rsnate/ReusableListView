using System.Collections.ObjectModel;
using System.Globalization;

namespace ReusableListView
{
    public class DataTemplateItemSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = new ObservableCollection<object>() { value };
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
