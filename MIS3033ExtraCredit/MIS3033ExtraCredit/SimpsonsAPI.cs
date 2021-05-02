using System;
using System.Collections.Generic;
using System.Text;

namespace MIS3033ExtraCredit
{
    public class SimpsonsAPI
    {
        public string quote { get; set; }
        public List<character> results { get; set; }
        public string image { get; set; }
        public string characterDirection { get; set; }

    }

    public class character
    {
        public string name { get; set; }
    }
}