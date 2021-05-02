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

namespace MIS3033ExtraCredit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://thesimpsonsquoteapi.glitch.me/quotes";

            while (string.IsNullOrWhiteSpace(url) == false)
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string jsondata = client.GetStringAsync(url).Result;

                        SimpsonsAPI api = JsonConvert.DeserializeObject<SimpsonsAPI>(jsondata);

                        foreach (var character in api.results)
                        {
                            listcharacters.Items.Add(character);
                        }

                        
                    }

                }
            }
        }

        public object JsonConvert { get; }

        private void listcharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image newwindow = new Image();
            newwindow.setupwindow((character)listcharacters.SelectedItem);
            newwindow.ShowDialog();
        }
    }


}
