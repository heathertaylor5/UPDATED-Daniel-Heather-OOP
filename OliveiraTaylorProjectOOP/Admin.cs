using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorOOPFinalProject
{
    public sealed class Admin : User
    {
        //Declare a static field
        static private int nextID = 0;
        //Declare some properties
        public string Name;

        public int AdminID;

        //Default constructor
        public Admin () { }

        //Custom constructor
        public Admin(string inName, Person inAddress, string inUserName, string inPassword):
            base(inAddress, inUserName, inPassword)
        {
            AdminID = nextID++;
            Name = inName;
            IsAdmin = true;
        }

        //Override the method DisplayInfo
        public override string DisplayInfo() => "Name: " + Name + "\n" + base.DisplayInfo();

    }
}
