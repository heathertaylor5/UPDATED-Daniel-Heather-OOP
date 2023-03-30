using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorOOPFinalProject
{
    public class Person
    {
        //Declare the properties
        public string Street, City, Province, Country, PostalCode;
        public int StreetNumber;

        //Defaul constructor
        public Person() { }

        //Custom constructor
        public Person(string inStreet,string inCity, string inProvince, string inCountry, int inStreetNumber, string inPostalCode)
        {
            Street = inStreet;
            City = inCity;  
            Province = inProvince;
            Country = inCountry;
            StreetNumber = inStreetNumber;
            PostalCode = inPostalCode;
        }
    }
}
