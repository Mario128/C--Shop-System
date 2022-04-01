using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazonshop
{
    class User
    {
        //fields
        private int _age;
        private int _postalCode;

        //properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        

        public int Age
        {
            get { return this._age; }
            set
            {
                if(value >= 0)
                {
                    this._age = value;
                }
            }
        }

        public int PostalCode
        {
            get { return this._postalCode; }
            set
            {
                if (value >= 0)
                {
                    this._postalCode = value;
                }
            }
        }
        
        //ctors
        public User(): this("", "", "","", "",  0 ,0) { }
        public User(string firstname, string lastname, string country, string city, string street, int age, int postalcode)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Age = age;
            this.PostalCode = postalcode;
        }

        //other Methods
        public override string ToString()
        {
            return "Name:" + this.Firstname + " " + this.Lastname + " " + Environment.NewLine +
                   "Alter" + this.Age + Environment.NewLine +
                   "Adresse:" + this.PostalCode + " " + this.City + " " + this.Street + " ";
        }
    }
}
