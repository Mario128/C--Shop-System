using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   public class TV : ElectricalEquipment
    {
        
        private double _displayResolution;

        public double DisplayResolution
        {
            get { return this._displayResolution; }
            set
            {
                if(value >= 0.0)
                {
                    this._displayResolution = value;
                }
            }
        }

        public bool HasInternet { get; set; }
        public string ScreenForm { get; set; }

     
        public TV(): this( 0,"", "", 0.0m, 0.0, true, "", 0.0, 0.0, "", "") { }
        public TV(int id, string name, string description, decimal price,  double displayResolution, bool hasInternet, string screenform, double screendiagonal, double weight, string color, string brand) : base(screendiagonal, weight, color, brand, description, name, price, id)
        {
            this.DisplayResolution = displayResolution;
            this.HasInternet = hasInternet;
            this.ScreenForm = screenform;
        }


        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Bildschirmauflösung: " + this.DisplayResolution + " Pixel" + Environment.NewLine + "Wlan Empfang: " + this.HasInternet + Environment.NewLine + "Bildschirmform: " + this.ScreenForm;
        }
    }
}
