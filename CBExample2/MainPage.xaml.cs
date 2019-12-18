using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CBExample2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {

        private ObservableCollection<ComboBoxItem> ComboBoxOptions;
        public event PropertyChangedEventHandler PropertyChanged;
        public MainPage()
        {
            this.InitializeComponent();
            ComboBoxOptions = new ObservableCollection<ComboBoxItem>();
            ComboBoxOptionsManager.GetComboBoxList(ComboBoxOptions);
            SelectedComboBoxOption = ComboBoxOptions[0];
        }

        ComboBoxItem _SelectedComboBoxOption ;
        public ComboBoxItem SelectedComboBoxOption
        {
            get
            {
                return _SelectedComboBoxOption;
            }
            set
            {
                if (_SelectedComboBoxOption != value)
                {
                    _SelectedComboBoxOption = value;
                    RaisePropertyChanged("SelectedComboBoxOption");
                }
            }
        }

        private string _editText;
        public string EditText
        {
            get => _editText;
            set { _editText = value; RaisePropertyChanged("EditText"); }
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = SelectedComboBoxOption;
        }
    }
}
