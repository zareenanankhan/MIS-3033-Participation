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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for Pokemon.xaml
    /// </summary>
    public partial class Pokemon : Window
    {
        public Pokemon()
        {
            InitializeComponent();
        }

        InformationAPI info;
        public void setupwindow(InformationAPI info)
        {
            this.info = info;
            imagepokemon.Source = new BitmapImage(new Uri(info.sprites.front_default));
            imagepokemon.Source = new BitmapImage(new Uri(info.sprites.back_default));
            poketext.Text = info.ToString();
            
        }

        bool shouldishowfront = true;

        private void buttonflip_Click(object sender, RoutedEventArgs e)
        {
            //bool shouldishowfront = true;

                if (shouldishowfront == true)
                {

                    imagepokemon.Source = new BitmapImage(new Uri(info.sprites.front_default));
                    shouldishowfront = false;
                }
                else
                {

                    imagepokemon.Source = new BitmapImage(new Uri(info.sprites.back_default));
                    shouldishowfront = true; 
                }

            
        }

        
    }
}
