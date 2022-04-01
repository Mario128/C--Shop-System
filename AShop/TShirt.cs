using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AShop
{

   public enum Cut { VNeck , RoundNeck, notSpecified}

    public class TShirt: Clothes
    {
        public Cut Cut { get; set; }

        public TShirt() : this(Cut.notSpecified, " ", "", 0.0m, 0, "", "", "", Gender.notSpecified, 0) { }
        public TShirt(Cut cut, string description, string name, decimal price, int id, string color, string material, string brand, Gender gender, int size) : base(color, material, brand, gender, size, description, name, price, id)
        
        {
            this.Cut = cut;
        }

        public override string ToString()
        {
            return base.ToString() +Environment.NewLine + "Ausschnitt: " +  this.Cut;
        }
    }
}
