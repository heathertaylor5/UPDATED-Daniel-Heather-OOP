using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Declare and set a constante 
            const int SIZE = 5;

            //Declare an array
            string[] names = new string[SIZE];
            string[] address = new string[5];


            //Calling both ReadName and RandomAddres ftn
            ReadName(names);

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                address = RandomAddress(RandomNumber());
                if (names[i]=="Admin")
                {
                    Admin admin = new Admin(names[i],new Person(address[1], address[0], address[2], address[3],RandomNumber(), address[4]),"admin", "admin");
                    users.Add(admin);
                }
                else if (names[i] == "Cathy")
                {
                    Customer customer = new Customer(names[i], new Person(address[1], address[0], address[2], address[3], RandomNumber(), address[4]), name, name);
                    users.Add(customer);
                }
                else 
                {
                    Customer customer = new Customer(names[i], new Person(address[1], address[0], address[2], address[3], RandomNumber(), address[4]), name, RandomNumber().ToString());
                    users.Add(customer);
                }
            }
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";

            //Define some properties to the password
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If the user click on radAdmin and the userName and password are correct,
            //the ProductMaintance Form opens, otherwise there will be a error message
            if (radAdmin.Checked)
            {
                //Calling the ftn LoginTheSystem sending user.IsAdimin as true
                //If the password and user name are correct a true is returned
                bool login = LoginTheSystem(true);
                if (login)
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
                if (login)
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
        public bool LoginTheSystem(bool isAdmin)
        {
            //Declare and set a local variable
            bool res = false;
            //Loop through users list to check if txtPassword and txtUserName
            //Are equal to users.UserName and users.Password
            foreach (User user in users)
            {
                if (txtUsername.Text.Equals(user.UserName)  
                    && user.IsAdmin == isAdmin 
                    && txtPassword.Text.Equals(user.Password))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        /*
         Name: ReadName
         Send: an array
         Return: none
         This ftn will read the names from Names.txt and put the info in a array.
         */
        public void ReadName(string[] array)
        {
            try
            {
                //Read the file names.txt
                StreamReader namesFile = new StreamReader(@"c:/files/names.txt");

                //Set array
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = namesFile.ReadLine();
                }
                //Close coursesFile
                namesFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         Name: RandomNumber
         Send: 2 int
         Return: int
         This ftn will generate random numbers between a range of 2 int that was send.
         */
        public int RandomNumber()
        {
            Random rand = new Random();
            int num = rand.Next(0, 5 + 1);
            return num;
        }

        /*
         Name: RandomAddress
         Send: an int
         Return: string
         This ftn will return a random city name.
         */
        public string[] RandomAddress(int randNum)
        {
            string city, street, province, country = "Canada", postalCode;
            switch (randNum)
            {
                case 0:
                    city = "Saint John";
                    street = "King Street";
                    province = "NB";
                    postalCode = "E2E5A2";
                    break;
                case 1:
                    city = "Moncton";
                    street = "Queen Street";
                    province = "NB";
                    postalCode = "E1A0A3";
                    break;
                case 2:
                    city = "Fredericton";
                    street = "Prince Street";
                    province = "NB";
                    postalCode = "E3A0A1";
                    break;
                case 3:
                    city = "Toronto";
                    street = "Princess Street";
                    province = "ON";
                    postalCode = "M1LM9N";
                    break;
                case 4:
                    city = "Vancouver";
                    street = "Duke Street";
                    province = "BC";
                    postalCode = "V5M1Y4";
                    break;
                default:
                    city = "Montreal";
                    street = "Duchess Street";
                    province = "QC";
                    postalCode = "G0AJ9Z";
                    break;
            }
            //Declare an array
            string[] address = new string[5] { city, street, province, country, postalCode };
            return address;
        }
    }
}
