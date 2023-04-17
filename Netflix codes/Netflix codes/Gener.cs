using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_codes
{
    public class Gener
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string URL { get; set; }
        public bool Favorite { get; set; }
        public string Letter { get; set; }

        public Gener(string name, string code, string url, bool favorite)
        {
            Name = name;
            Code = code;
            URL = url;
            Favorite = favorite;
            Letter = name[0].ToString();
        }
    }
}
