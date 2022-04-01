using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   public class Smartphone : ElectricalEquipment
    {
        private int _storage;
        private int _camera;

        public int Storage
        {
            get { return this._storage; }
            set
            {
                if (value >= 0)
                {
                    this._storage = value;
                }
            }
        }
        public int Camera
        {
            get { return this._camera; }
            set
            {
                if (value >= 0)
                {
                    this._camera = value;
                }
            }
        }

        public string OS { get; set; }
        public bool HasTouch { get; set; }

        public Smartphone(): this(0, 0 ,"", true,0.0,0.0,"","","","",0.0m,0) { }
        public Smartphone(int storage, int camera, string os, bool hasTouch, double screendiagonal,
            double weight, string color, string brand,string description, string name, decimal price, int id)
            : base(screendiagonal,weight,color,brand,description,name,price, id)
        {
            this.Storage = storage;
            this.Camera = camera;
            this.OS = os;
            this.HasTouch = hasTouch;
        }

        public override string ToString()
        {
            return base.ToString() +Environment.NewLine +  "Speicher: " + this.Storage + " GB" + Environment.NewLine + "Kameraauflösung: " + this.Camera + " MP" + Environment.NewLine + "Betriebssystem: " + this.OS + Environment.NewLine + "Touch-Display: " + this.HasTouch;
        }
    }
}
