using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using static CBExample2.MainPage;

namespace CBExample2
{
    public class ComboBoxItemConvert : IValueConverter
    {
        public ObservableCollection<ComboBoxItem> Options { get; set; }
        public string ComboBoxEditText { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //string x = value.ToString(); 

            if (value != null && value.GetType().Equals(typeof(ComboBoxItem)))
            {
                return value;
            }
            var newItem = new ComboBoxItem() { ComboBoxOption = ComboBoxEditText ?? "new", ComboBoxHumanReadableOption = ComboBoxEditText ?? "new" };
           // var newItem = new ComboBoxItem() { ComboBoxOption = "new", ComboBoxHumanReadableOption = "new" };
            if (Options != null && !Options.Contains(newItem))
            {
                Options.Add(newItem);
            }
            return newItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value as ComboBoxItem;
        }
    }
}
