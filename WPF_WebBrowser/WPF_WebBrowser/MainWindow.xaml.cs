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

namespace WPF_WebBrowser
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

        private void buttongo_Click(object sender, RoutedEventArgs e)
        {
            string query = textquery.Text;

            WebBrowserWindow google = new WebBrowserWindow(); //shows three different ways to pass the query
            //google.Query = query;
            google.Search();
            google.Search(query);
            google.ShowDialog();
        }
    }
}
