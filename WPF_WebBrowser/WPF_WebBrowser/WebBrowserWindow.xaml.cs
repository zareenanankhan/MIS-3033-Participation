using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_WebBrowser
{
    /// <summary>
    /// Interaction logic for WebBrowserWindow.xaml
    /// </summary>
    public partial class WebBrowserWindow : Window // three methods shows three different ways to pass the query
    {
        public string Query { get; set; }
        public WebBrowserWindow()
        {
            InitializeComponent();

            webbrowser.Navigate($"https://www.google.com");
        }

        public void Search(string q)
        {
            Query = q;
            webbrowser.Navigate($"https://www.google.com/search?q={q}");
        }

        public void Search()
        {
            webbrowser.Navigate($"https://www.google.com/search?q={Query}");
        }
    }
}
