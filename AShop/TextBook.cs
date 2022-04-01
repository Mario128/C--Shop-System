using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   public  class TextBook : Books
    {        
        private int _pages;
        
        public int Pages
        {
            get { return this._pages; }
            set
            {
                if (value >= 0)
                {
                    this._pages = value;
                }
            }
        }

        public TextBook(): this(0, "", "", 0.0m, 0, "") { }
        public TextBook(int pages, string description, string name, decimal price, int id, string author) :base(author, description, name, price, id)
        {
            this.Pages = pages;
        }

        public override string ToString()
        {
            return base.ToString() +Environment.NewLine + "Seiten: " +  this.Pages;
        }
    }
}
