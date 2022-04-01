using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   abstract public class Books : Article
    {

        public string Author { get; set; }

        public Books(): this("", "", "", 0.0m, 0 ) { }
        public Books(string author, string description, string name, decimal price, int id) :base ( description,  name,  price, id)
        {
            this.Author = author;
        }



        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Author: " + this.Author;
        }
    }
}
