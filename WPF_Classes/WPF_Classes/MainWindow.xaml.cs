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

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush background; 

        public MainWindow()
        {
            InitializeComponent();
            background = WindowName.Background;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, dobtext;

            name = txtName.Text;
            dobtext = txtDOB.Text;

            DateTime dob = Convert.ToDateTime(dobtext);

            if (dpDOB.SelectedDate.HasValue)
            { 
                dob = dpDOB.SelectedDate.Value;

            }
           
            TimeSpan age = DateTime.Now - dob;

            MessageBox.Show($"{name} you are {(age.TotalDays/365).ToString("N0")} years old"); 
        }

        private void Buttonsubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            WindowName.Background = Brushes.Aquamarine;
        }

        private void Buttonsubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            WindowName.Background = background;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
