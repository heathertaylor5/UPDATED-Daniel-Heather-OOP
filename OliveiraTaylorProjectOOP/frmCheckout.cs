using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTaylorOOPFinalProject
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            //Add our names to form and call PopulateCart
            this.Text = "Daniel & Heather";
            PopulateCart();
        }

        //User Clicks Back to store button - closes this form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hide the cardnumber info for cash or cheque, display for any credit type
        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paymentType = cboPaymentMethod.SelectedItem.ToString();
            switch (paymentType) 
            {
                case "Visa": 
                case "AMEX": 
                case "MasterCard":
                    {
                        txtCardNum.Show();
                        lblCardNum.Show();
                        break;
                    }
                case "Cash":
                case "Cheque":
                    {
                        txtCardNum.Hide();
                        lblCardNum.Hide();
                        break;
                    }
            }
        }

        //Confirm order button is clicked - Generate receipt to be saved
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            //Check that the user has selected a payment method
            if(cboPaymentMethod.SelectedItem != null) 
            {
                //If the user chose a credit Card, check that they inputted the last 4 digits of the card
                //Display a message if not
                if(txtCardNum.Text.Length != 4 && Validator.IsInt32(txtCardNum) &&
                    (cboPaymentMethod.SelectedItem.ToString() == "AMEX" || 
                    cboPaymentMethod.SelectedItem.ToString() == "MasterCard" ||
                    cboPaymentMethod.SelectedItem.ToString() == "Visa") 
                    )
                {
                    MessageBox.Show("Must enter last 4 digits of card", "Error");
                }
                else
                {
                    DialogResult userSelection = sfdOrderReceipt.ShowDialog();
                    //If user cancels saving the receipt
                    if (userSelection == DialogResult.Cancel)
                    {
                        MessageBox.Show("Order not processed - User cancelled", "Not Processed");
                    }
                    //User saves the receipt
                    else
                    {
                        //Build streamwriter
                        StreamWriter receipt = new StreamWriter(sfdOrderReceipt.FileName);
                        //Add info to receipt
                        receipt.WriteLine("HD Art Purchase Receipt\n");
                        for (int i = 0; i < lstOrdersInCart.Items.Count; i++)
                        {
                            string currentItem = lstOrdersInCart.Items[i].ToString();
                            string itemCode = currentItem.Substring(0, 5);
                            Product item = FindProduct(itemCode);
                            receipt.WriteLine(item.Code + "   " + item.Description + "   " + item.Price.ToString("c"));
                        }
                        receipt.WriteLine("\nTotal Price: " + lblTotal.Text);
                        receipt.WriteLine("\nThank you for your purchase");
                        //Close StreamWriter
                        receipt.Close();
                        //Thank user for purchase - close Checkout form
                        MessageBox.Show("Thanks for your purchase!", "Daniel & Heather");
                        this.Close();
                    }
                }              
            }
            //Show a messagebox if no payment method is selected
            else
            {
                MessageBox.Show("Must select a payment method", "Error");
            }           
        }

        //Methods
        /*Name: PopulateCart
         *Sent: None
         *Returned: None
         *Shows a description of items in the users cart and calculates total*/
        public void PopulateCart()
        {
            decimal totalCost = 0;
            foreach (string item in frmOrder.OrderList)
            {
                string code = item.Substring(0, 5);
                Product product = FindProduct(code);
                lstOrdersInCart.Items.Add(product.DisplayInfo());
                totalCost += product.Price;
            }
            lblTotal.Text = totalCost.ToString("c");
        }

        /*Name: FindProduct
         *Sent: String
         *Returned: Product
         *This function finds a product from the main inventory list using a string and returns the product*/
        public Product FindProduct(string code)
        {
            Product item = null;
            foreach (Product product in frmLogin.products)
            {
                if (product.Code == code)
                {
                    item = product;
                    break;
                }
            }
            return item;
        }
    }
}
