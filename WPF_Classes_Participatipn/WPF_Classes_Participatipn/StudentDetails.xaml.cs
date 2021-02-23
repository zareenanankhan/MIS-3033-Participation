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

namespace WPF_Classes_Participation
{
    /// <summary>
    /// Interaction logic for StudentDetails.xaml
    /// </summary>
    public partial class StudentDetails : Window
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        public void StudentSearch(Student s)
        {
            textfirstname.Text = s.FirstName; 
            textlastname.Text = s.LastName;
            textstreetname.Text = s.Address.StreetName;
            textstreetnumber.Text = s.Address.StreetNumber.ToString();
            textcity.Text = s.Address.City;
            textstate.Text = s.Address.State;
            textzip.Text = s.Address.ZipCode.ToString();
        }

       


    }
}
