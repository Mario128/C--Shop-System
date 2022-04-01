using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
    public enum Category{noCategory,clothes, books, electronics, sports, entertainment}


    abstract public class Article
    {
        private decimal _price;
        private int _idNumber;

        private List<Category> _categories = new List<Category>();

        public List<Category> Categories { get { return this._categories; } }
        
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return this._price; }
            set
            {
                if (value >= 0.0m)
                {
                    this._price = value;
                }
            }

        }
        public int IdNumber
        {
            get { return this._idNumber; }
            set
            {
                if(value>= 0)
                {
                    this._idNumber = value;
                }
            }
        }

        public Article(): this("", "",  0.0m, 0 ) { }
        public Article(string description, string name, decimal price, int ID)
        {
            this.Description = description;
            this.Name = name;
            this.Price = price;
            this.IdNumber = ID;
        }

        public override string ToString()
        {
            return "Name: " + this.Name +Environment.NewLine + "Beschreibung: " + this.Description +  Environment.NewLine + "Preis: " +  this.Price + " Euro"+ Environment.NewLine + "ID: " + this.IdNumber;
        }

        public void AddCategory(Category category) {
            this._categories.Add(category);
        }
        public void RemoveCategory(Category category)
        {
            this._categories.Remove(category);
        }
    }
}
