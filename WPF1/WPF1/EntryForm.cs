using System;

namespace WPF1
{
    class EntryForm
    { 
        public string Name { get; set;}
        public string Address { get; set;}
        public int ZipCode { get; set; }

        public EntryForm()
        {
            string Name = string.Empty;
            string Address = string.Empty;
            int ZipCode = 00000;
        }

        public override string ToString()
        {
            return $"{Name} ({Address}) ({ZipCode})";

            
        }
    }
}
