using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        //Constructor 
        public CellPhone()
        {
            Brand = "";
            Model = "";
            Price = "0m";
        }

        //Brand property getter/setter
        public string Brand { get; set; }

        // Model property getter/Setter
        public string Model { get; set; }

        //Price property getter/setter
        public decimal Price { get; set; }

    }
}
