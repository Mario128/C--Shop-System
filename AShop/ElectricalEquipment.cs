using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   
    abstract public class ElectricalEquipment:Article
    {
        private double _screenDiagonal;
        private double _weight;

        public double ScreenDiagonal
        {
            get { return this._screenDiagonal; }
            set
            {
                if (value >= 0)
                {
                    this._screenDiagonal = value;
                }
            }
        }
        public double Weight
        {
            get { return this._weight; }
            set
            {
                if(value >= 0)
                {
                    this._weight = value;
                }
            }
        }

        public string Color { get; set; }
        public string Brand { get; set; }

        public ElectricalEquipment(): this(0.0, 0.0,  "", "", "", "", 0.0m, 0) { }
        public ElectricalEquipment(double screendiagonal, double weight,  string color, string brand, string description, string name, decimal price, int id) :base(description, name, price, id)
        {
            this.ScreenDiagonal = screendiagonal;
            this.Weight = Weight;
            this.Color = color;
            this.Brand = brand;
            
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Bildschirmdiagonale: "  + this.ScreenDiagonal + " Zoll" +  Environment.NewLine + "Gewicht: " + this.Weight + " Gramm" + Environment.NewLine + "Farbe :" + this.Color + Environment.NewLine + "Marke :" + this.Brand;
        }

    }
}
