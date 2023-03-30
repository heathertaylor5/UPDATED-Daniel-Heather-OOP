using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorOOPFinalProject
{
    public sealed class Customer: User
    {
        //Declare a static field
        static private int nextID = 0;
        //Declare some properties
        public string Name;
        public int CustomerID;

        //Default constructor
        public Customer() { }

        //Custom constructor
        public Customer(string inName, Person inAddress, string inUserName, string inPassword) :
            base(inAddress, inUserName, inPassword)
        {
            CustomerID = nextID++;
            Name = inName;
            IsAdmin = false;
        }

        //Override the method DisplayInfo
        public override string DisplayInfo() => "Name: " + Name + "\n" + base.DisplayInfo();
    }
}
