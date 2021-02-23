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
using WPF_Classes_Participation;

namespace WPF_Classes_Participatipn
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
            bool iseverythinggood = true;

            if (string.IsNullOrWhiteSpace(textcity.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid city.");
            }

            if (string.IsNullOrWhiteSpace(textfirstname.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid first name.");
            }

            if (string.IsNullOrWhiteSpace(textlastname.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid last name.");
            }

            if (string.IsNullOrWhiteSpace(textmajor.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid major.");
            }

            if (string.IsNullOrWhiteSpace(textstreetname.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid street name.");
            }

            if (string.IsNullOrWhiteSpace(textstate.Text) == true)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid State.");

            }

            double gpa;

            if (double.TryParse(textcumulativegpa.Text, out gpa) == false)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid GPA.");
            }

            int streetnumber, zipcode;

            if (int.TryParse(textstreetnumber.Text, out streetnumber) == false)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid ZIP Street Number.");
            }

            if (int.TryParse(textzip.Text, out zipcode) == false)
            {
                iseverythinggood = false;
                MessageBox.Show("You must enter a valid ZIP Code.");
            }

            if (iseverythinggood == false)
            {
                return;
            }

            Student student = new Student()
            {
                FirstName = textfirstname.Text,
                GPA = gpa,
                LastName = textlastname.Text,
                Major = textmajor.Text,

            };

            student.SetAddress(streetnumber, textstreetname.Text, textstate.Text, textcity.Text, zipcode);

            listgraduationhandout.Items.Add(student);

            textfirstname.Clear();
            textlastname.Clear();
            textmajor.Clear();
            textcumulativegpa.Clear();
            textstreetnumber.Clear();
            textstreetname.Clear();
            textcity.Clear();
            textstate.Clear();
            textzip.Clear();
        }

        private void listgraduationhandout_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StudentDetails newstudent = new StudentDetails();
            newstudent.StudentSearch((Student)listgraduationhandout.SelectedItem);
            newstudent.ShowDialog();
        }
    }
}
