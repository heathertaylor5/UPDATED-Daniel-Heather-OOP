using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTheSystem
{
    public class Person
    {
        //Declare the properties
        public string Street, City, Province, Country, PostalCode;
        public int StreetNumber;

        //Defaul constructor
        public Person() { }

        //Custom constructor
        public Person(string inStreet, string inCity, string inProvince, string inCountry, int inStreetNumber, string inPostalCode)
        {
            Street = inStreet;
            City = inCity;
            Province = inProvince;
            Country = inCountry;
            StreetNumber = inStreetNumber;
            PostalCode = inPostalCode;
        }
    }

    public abstract class User : IComparable<User>
    {
        //Declare some properties
        public Person Address;
        public string UserName, Password;
        public bool IsAdmin;

        //Default constructor
        public User() { }

        //Custom constructor
        public User(Person inAddress, string inUserName, string inPassword)
        {
            Address = inAddress;
            UserName = inUserName;
            Password = inPassword;
        }

        //Create a method to display the user's information
        public virtual string DisplayInfo() => "\n User Name: " + UserName
            + "\n Address: " + "\n" + Address.StreetNumber + ", " + Address.Street +
            "\n" + Address.City + "\n" + Address.Province + "\n" + Address.PostalCode +
             "\n" + Address.Country;
        //Overload DisplayInfo
        public virtual string DisplayInfo(string sep) => "User Name: " + UserName + sep + Address.Province;

        //Implement the interface to compare the IsAdmin property
        public int CompareTo(User user)
        {
            return IsAdmin == user.IsAdmin ? 1 : 0;
        }
    }
    public sealed class Customer : User
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

    public sealed class Admin : User
    {
        //Declare a static field
        static private int nextID = 0;
        //Declare some properties
        public string Name;

        public int AdminID;

        //Default constructor
        public Admin() { }

        //Custom constructor
        public Admin(string inName, Person inAddress, string inUserName, string inPassword) :
            base(inAddress, inUserName, inPassword)
        {
            AdminID = nextID++;
            Name = inName;
            IsAdmin = true;
        }

        //Override the method DisplayInfo
        public override string DisplayInfo() => "Name: " + Name + "\n" + base.DisplayInfo();

        //Overload DisplayInfo
        public override string DisplayInfo(string sep) => base.DisplayInfo() + sep + "Name: " + Name;
    }
}
