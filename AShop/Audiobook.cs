using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{
   public class  Audiobook : Books
    {
        private double _duration;
        
        public double Duration
        {
            get { return this._duration; }
            set
            {
                if(value >= 0.0)
                {
                    this._duration = value;
                }
            }
        }

        public Audiobook(): this(0.0, "", "", 0.0m, 0, "" ) { }
        public Audiobook(double duration, string description, string name, decimal price, int id, string author) : base(author,description, name, price, id)
        {
            this.Duration = duration;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Dauer: " + this.Duration + "min";
        }
    }
}
