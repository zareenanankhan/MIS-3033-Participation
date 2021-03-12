using System;
using System.Collections.Generic;
using System.Text;

namespace GOTQuote
{
    public class gotquote
    {
        public string quote { get; set; }
        public string character { get; set; }

        public override string ToString()
        {
            return $"Quote: {quote} \n Who said it: {character}.";
        }
    }
}
