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

namespace First_WPF_Application_Participation
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

        private void calculateage_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text;
            string answer = DOBBox.Text;
            DateTime date = Convert.ToDateTime(answer);
            DateTime todaydate = DateTime.Now;
            TimeSpan age = todaydate - date;
            MessageBox.Show($"Hi {name}! Your our age is {age.Days/365}");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            WindowName.Background = Brushes.Red; 
        }

        private void btnSubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            WindowName.Background = Brushes.Blue;
        }

    }
}
