using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBExample2
{
    public class ComboBoxItem
    {
        public string ComboBoxOption { get; set; }
        public string ComboBoxHumanReadableOption { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ComboBoxItem item &&
              ComboBoxOption == item.ComboBoxOption;
        }
    }

    public class ComboBoxOptionsManager
    {
        public static void GetComboBoxList(ObservableCollection<ComboBoxItem> ComboBoxItems)
        {
            var allItems = getComboBoxItems();
            ComboBoxItems.Clear();
            allItems.ForEach(p => ComboBoxItems.Add(p));
        }

        private static List<ComboBoxItem> getComboBoxItems()
        {
            var items = new List<ComboBoxItem>();

            items.Add(new ComboBoxItem() { ComboBoxOption = "Option1", ComboBoxHumanReadableOption = "Option 1" });
            items.Add(new ComboBoxItem() { ComboBoxOption = "Option2", ComboBoxHumanReadableOption = "Option 2" });
            items.Add(new ComboBoxItem() { ComboBoxOption = "Option3", ComboBoxHumanReadableOption = "Option 3" });

            return items;
        }
    }
}
