using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTaylorOOPFinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Declare global lists for Admins and Customers
        List<User> users = new List<User>();


        private void Login_Load(object sender, EventArgs e)
        {   
            
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";

            //Define some properties to the password
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 15;

            //Create some objects with the address information
            Person address = new Person("King Street", "Saint John", "NB", "Canada", 123, "E2L1J9");
            Person address2 = new Person("Queen Street", "Saint John", "NB", "Canada", 234, "I3L1J9");
            Person address3 = new Person("Prince Street", "Moncton", "NB", "Canada", 234, "P3L1J9");
         
            //Create 5 Admin objects and add them to the admin list
            Admin cathy = new Admin("Cathy B.", address , "Admin", "Admin");
            users.Add(cathy);
            Admin daniel = new Admin("Daniel O.", address2, "Daniel", "Daniel");
            users.Add(daniel);
            Admin heather = new Admin("Heather T.", address3, "Heather", "Heather");
            users.Add(heather);
            Admin oliveira = new Admin("Oliveira", address, "Oliveira", "Oliveira");
            users.Add(oliveira);
            Admin taylor = new Admin("Taylor", address, "Taylor", "Taylor");
            users.Add(taylor);

            //Create 5 Customer objects and add them to the customer list
            Customer cat = new Customer("Cathy B.", address, "Cathy", "Cathy");
            users.Add(cat);
            Customer dan = new Customer("Daniel O.", address2, "Daniel", "Daniel");
            users.Add(dan);
            Customer hea = new Customer("Heather T.", address3, "Heather", "Heather");
            users.Add(hea);
            Customer oli = new Customer("Oliveira", address, "Oliveira", "Oliveira");
            users.Add(oli);
            Customer tay = new Customer("Taylor", address, "Taylor", "Taylor");
            users.Add(tay);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If the user click on radAdmin and the userName and password are correct,
            //the ProductMaintance Form opens, otherwise there will be a error message
            if(radAdmin.Checked) 
            {
                //Calling the ftn LoginTheSystem sending user.IsAdimin as true
                //If the password and user name are correct a true is returned
                bool login = LoginTheSystem(true);
                if(login)
                {
                    //Open ProductMaintaince
                    ProductMaintenance product = new ProductMaintenance();
                    product.ShowDialog();
                }
                else
                    //Dispaly a error msg
                    MessageBox.Show("Sorry incorrect user name or password", "Login error");
            }
            //If the user click on radCustomer and the userName and password are correct,
            //the ProductMaintance Form opens, otherwise there will be a error message
            else
            {
                //Calling the ftn LoginTheSystem sending user.IsAdimin as false
                //If the password and user name are correct a true is returned
                bool login = LoginTheSystem(false);
                if(login)
                {
                    //Open Order form
                    Order order = new Order();
                    order.ShowDialog();
                }
                else
                    //Dispaly a error msg
                    MessageBox.Show("Sorry incorrect user name or password", "Login error");
            }
        }
        /*
         Name: LoginTheSystem
         Send: bool
         Return: bool
         This ftn will compare if both txtPassword and txtUserName are equal to the user name and password of users list.
         If the user is login as an admin, it will be send a true, but if the user is login as costumer a false is send.
         */
        public bool LoginTheSystem( bool isAdmin)
        {
            //Declare and set a local variable
            bool res =false;
            //Loop through users list to check if txtPassword and txtUserName
            //Are equal to users.UserName and users.Password
            foreach( User user in users)
            {
                if(txtUsername.Text.Equals(user.UserName) && user.IsAdmin ==isAdmin && txtPassword.Text.Equals(user.Password))
                     res =true;
            }
            return res;
        }
    }
}
