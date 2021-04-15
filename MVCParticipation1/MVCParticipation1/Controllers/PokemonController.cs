﻿using MVCParticipation1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCParticipation1.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI api;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=20&limit=1100").Result;
                api = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }
            return View(api.results);

            
        }

        public ActionResult Info(string id)
        {
            PokemonInfo info;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon{id}").Result;
                info = JsonConvert.DeserializeObject<PokemonInfo>(json);
            }
            return View(info);
        }
    }
}