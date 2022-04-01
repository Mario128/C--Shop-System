using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
    public enum Gender
    {
        male, female, notSpecified
    }
    abstract public class Clothes:Article
    {
        private int _size;      

        public string Color { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        public Gender Gender { get; set; }
        public int Size
        {
            get { return this._size; }
            set
            {
                if(value >= 0)
                {
                    this._size = value;
                }
            }
        }

        public Clothes(): this("", "", "", Gender.notSpecified, 0, "", "", 0.0m, 0) { }
        public Clothes(string color, string material, string brand, Gender gender, int size,string description, string name, decimal price, int id) :base(description, name, price, id)
        {
            this.Color = color;
            this.Material = material;
            this.Brand = brand;
            this.Gender = gender;
            this.Size = size;
        }

        public override string ToString()
        {
            return base.ToString() +Environment.NewLine+  "Farbe: " + this.Color + Environment.NewLine + "Material: " + this.Material + Environment.NewLine +"Marke: " + this.Brand + Environment.NewLine+ "Geschlecht: " + this.Gender + Environment.NewLine+  "Größe: " + this.Size;       }
    
    }
}
