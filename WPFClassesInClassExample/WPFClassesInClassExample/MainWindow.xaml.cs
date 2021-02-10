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
using WPFClassesInClassExample;

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object textbreed;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Pet myPet = new Pet()
            {
                Breed = textbreed.Text;
                Name = textname.Text;
                PictureURL = textpicture.Text;
            }
        
            //myPet.Breed = txtBreed.Text;

            lstPets.Items.Add(myPet);
        }

        
    }
}





