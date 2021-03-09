using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_InClassExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //https://rickandmortyapi.com/api/character

            string url= "https://rickandmortyapi.com/api/character";

            while (string.IsNullOrWhiteSpace(url)==false)
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string jsondata = client.GetStringAsync(url).Result;

                        RickMortyAPI api = JsonConvert.DeserializeObject<RickMortyAPI>(jsondata);

                        foreach (var character in api.results)
                        {
                            listcharacters.Items.Add(character);
                        }

                        url = api.info.next;
                    }
                    
                }
            }
        }

        private void listcharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcharacter = (character)listcharacters.SelectedItem;
            imagecharacter.Source = new BitmapImage(new Uri(selectedcharacter.image));
        }


    }
}
