using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class constructor
    {
        public int MyProperty {get; set;}

        private string _address;

        public RealEstate(string address)
        
        {
            _address = address;
        }
    }
}

