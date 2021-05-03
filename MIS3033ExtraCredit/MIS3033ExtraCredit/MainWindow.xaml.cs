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

           
        }


        private void buttonclick_Click(object sender, RoutedEventArgs e)
        {
            SimpsonsAPI api = new SimpsonsAPI();
            string url = " https://thesimpsonsquoteapi.glitch.me/quotes";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<SimpsonsAPI>(json);
            }

            textquote.Text = api.ToString();
        }
    }


}
