using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDp_Hands_On3
{
    class Product
    {
        private string _personType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();
        public Product(string personType)
        {
            this._personType = personType;
        }
        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Package Type:{0} ", _personType);
            Console.WriteLine("Sweet : {0}",parts["sweets"]);
            Console.WriteLine("Savory : {0}", parts["savory"]);

        }
    }
}
