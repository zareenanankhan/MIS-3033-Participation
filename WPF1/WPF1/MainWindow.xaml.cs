using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, RoutedEventArgs e)
        {

            EntryForm form = new EntryForm()
            {
                Name = textname.Text,
                Address = textaddress.Text,
                ZipCode = Convert.ToInt32(textzip.Text),

            };

            listbox.Items.Add(form);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EntryForm selected = (EntryForm)listbox.SelectedItem;
        }
    }
}
