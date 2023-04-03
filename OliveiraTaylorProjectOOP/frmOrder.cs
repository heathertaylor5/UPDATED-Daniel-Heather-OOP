using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OliveiraTaylorOOPFinalProject 
{ 
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        //Create order list to be accessed from all other forms
        public static List<string> OrderList = new List<string>();

        private void Order_Load(object sender, EventArgs e)
        {

            //Put the name of the students on the title
            this.Text = "Daniel & Heather";
           
            //Populate Listbox
            DisplayStoreInventory();
            //Select first index
            lstInventory.SelectedIndex = 0;
        }

        //ADD TO ORDER BUTTON IS CLICKED
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //Find the index of the current Item
            int index = lstInventory.SelectedIndex;

            //Get the info and find the productCode
            string productInfo = lstInventory.SelectedItem as string;
            string productCode = productInfo.Substring(0, 5);

            //Find the current Product in the list by using the productCode
            foreach (Product product in frmLogin.products) 
            {
                //If there is a matching product - remove 1 from stock and add to cart
                //Break out of loop after product has been dealt with
                if(productCode.Equals(product.Code)) 
                {
                    product.InStock--;
                    lstCart.Items.Add(product.DisplayCart());
                    break;
                }
            }
            //Redisplay the main inventory list (updating inventory count)
            DisplayStoreInventory();
            //Highlight the same index. If it was the last in the list and product is gone, move up one
            if(index >= lstInventory.Items.Count) 
            {
                index--;
            }
            lstInventory.SelectedIndex = index;
        }

        /*Name: DisplayStoreInventory
         *Sent: List of Products
         *Returned: None
         *This function populates the list for the lstInventory*/
        public void DisplayStoreInventory()
        {
            //Clear the listbox
            lstInventory.Items.Clear();
            //Add each product in the list, add to the listbox if instock is above 0
            foreach (Product product in frmLogin.products)
            {
                if (product.InStock > 0)
                    lstInventory.Items.Add(product.DisplayInfo());
            }
        }

        //Selected Index Change - Show correct groupbox
        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the info and find the product Type from the code
            string productInfo = lstInventory.SelectedItem as string;
            string productType = productInfo.Substring(0, 2);
            
            //Photo
            if(productType == "PH")
            {
                grpPaintings.Hide();
                grpPhotos.Show();
            }
            //Painting
            else if(productType == "PA")
            {
                grpPhotos.Hide();
                grpPaintings.Show();
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            //Open Checkout Form if there is something in the cart
            if(lstCart.Items.Count > 0) 
            {
                foreach(string item in lstCart.Items)
                {
                    OrderList.Add(item);
                }
                frmCheckout checkout= new frmCheckout();
                checkout.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must have at least 1 item in cart", "Error");
            }

        }
    }
}
