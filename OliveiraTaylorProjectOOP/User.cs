using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorOOPFinalProject
{
    public abstract class User: IComparable<User>
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

        //Implement the interface to compare the passwords
        public int CompareTo(User user)
        {
            return Password == user.Password ? 1 : 0;
        }
    }
}
