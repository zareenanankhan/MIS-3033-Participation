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

namespace JSON_InClassExample
{
    /// <summary>
    /// Interaction logic for Image.xaml
    /// </summary>
    public partial class Image : Window
    {
        public Image()
        {
            InitializeComponent();
        }

        public void setupwindow (character info)
        {
            imagewindow.Source = new BitmapImage(new Uri(character.image));

        }
    }
}
