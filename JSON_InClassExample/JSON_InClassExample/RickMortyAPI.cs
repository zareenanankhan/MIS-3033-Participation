using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_InClassExample
{
    public class RickMortyAPI
    {
        public Info info {get;set;}
        public List<character> results { get; set; }
    }

    public class character
    {
        public string name { get; set; }
        public string image { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            return $"{name}";
        }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
    }
}
