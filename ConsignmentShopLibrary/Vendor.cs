using System;
using System.Collections.Generic;
using System.Text;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public string Diplay
        {
            get
            {
                return string.Format("{0} {1} - ${2}", FirstName, LastName, );
            }
        }
        public Vendor()
        {
            Commission = .5;
        }
    }
}
