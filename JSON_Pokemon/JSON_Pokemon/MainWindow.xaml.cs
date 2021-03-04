﻿using Newtonsoft.Json;
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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";
         

            using (var client=new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }

            foreach(var item in api.results.OrderBy(x =>x.name).ToList())
            {
                listpokemon.Items.Add(item);
                
            }

            // double click item in list box and open new form    
            // sprites, we only care about front default which has a string data type. 
           
            

        }

        private void listpokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformationAPI api1;

            var selectedCharacter = (ResultObject)listpokemon.SelectedItem;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedCharacter.url).Result;
                api1 = JsonConvert.DeserializeObject<InformationAPI>(json);
            }

            Pokemon wnd = new Pokemon();
            wnd.setupwindow(api1);
            wnd.ShowDialog();



        }



    }
}
