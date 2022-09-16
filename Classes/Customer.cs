using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        private string _firstName;
        public string FirstName2 { 
            get { return "Mrs." + _firstName; } 
            set {_firstName = value;} 
                       }

    }
}
