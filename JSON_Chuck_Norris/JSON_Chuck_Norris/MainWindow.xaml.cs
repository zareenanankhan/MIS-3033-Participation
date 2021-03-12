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

namespace JSON_Chuck_Norris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string norrisurl = "https://api.chucknorris.io/jokes/random?category";
        string categoriesurl = "https://api.chucknorris.io/jokes/categories";
        public MainWindow()
        {
            InitializeComponent();

           
            string categoriesurl = "https://api.chucknorris.io/jokes/categories";
            List<string> categorieslist = new List<string>();
            using (var client=new HttpClient())
            {

                string categorydata = client.GetStringAsync(categoriesurl).Result;

                categorieslist= JsonConvert.DeserializeObject<List<string>>(categorydata);
                
                foreach (string category in categorieslist)
                {
                    combobox.Items.Add(category);
                }

                combobox.Items.Add("All");
            }

        }

        private void buttonselect_Click(object sender, RoutedEventArgs e)
        {

            string selectedcategory = combobox.SelectedItem.ToString();

            APINorris joke = new APINorris();

            string url1 = $"https://api.chucknorris.io/jokes/random?category={selectedcategory}";

            string url2 = $"https://api.chucknorris.io/jokes/random";

            if (selectedcategory == "All")
            {
                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync(url2).Result;
                    joke = JsonConvert.DeserializeObject<APINorris>(json);

                }
            }
            else
            {
                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync(url1).Result;
                    joke = JsonConvert.DeserializeObject<APINorris>(json);
                }
            }

            joketext.Text = joke.value;
        }
    }
}
