using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   public enum Shutter { notSpecified, velcroFastener, shoelace}

   public class Shoes:Clothes
    {
        public string Sole { get; set; }
        public Shutter Shutter { get; set; }
        public string Style { get; set; } 

        public Shoes():this(" ",Shutter.notSpecified," ", "", "", 0.0m, 0, "", "", "", Gender.notSpecified, 0) { }
        public Shoes(string sole, Shutter shutter, string style, string description, string name, decimal price, int id, string color, string material, string brand, Gender gender, int size) : base(color, material, brand, gender, size, description, name, price, id)
        {
            this.Sole = sole;
            this.Shutter = shutter;
            this.Style = style;
        }
        
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Sohle: " + this.Sole + Environment.NewLine + " Verschluss: " + this.Shutter + Environment.NewLine +  "Stil: " + this.Style;
        }

    }
}
