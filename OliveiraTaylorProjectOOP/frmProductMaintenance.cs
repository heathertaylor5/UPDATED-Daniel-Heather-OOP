using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTaylorOOPFinalProject
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private void ProductMaintenance_Load(object sender, EventArgs e)
        {
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";
            DisplayProducts();
            lstAllProducts.SelectedIndex = 0;
        }

        //Add stock button is clicked - Use overloaded + operator to add nud value to stock
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int index = lstAllProducts.SelectedIndex;
            if (nudNumStock.Value <= 0)
                MessageBox.Show("Must have a value above 0 to change stock count", "Error");
            else
            {
                //Use overloaded operator to update stock
                Product currentProduct = FindProduct();
                if (currentProduct + Convert.ToInt32(nudNumStock.Value))
                {
                    MessageBox.Show("Stock count updated", "Success");
                    lstAllProducts.Items.Clear();
                    DisplayProducts();
                    lstAllProducts.SelectedIndex = index;
                }
            }
        }
        
        //Selected index changed - display product info to labels
        private void lstAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Find the current product based on the code
            Product currentProduct = FindProduct();
            //Populate the labels with the product information.
            lblProductName.Text = currentProduct.Description;
            lblInStock.Text = currentProduct.InStock.ToString();
        }

        //Remove stock Button is clicked
        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            //set index and find value to change stock
            int index = lstAllProducts.SelectedIndex;
            int updateStock = Convert.ToInt32(nudNumStock.Value);
            //If nud contains a 0 or less
            if (nudNumStock.Value <= 0)
                MessageBox.Show("Must have a value above 0 to change stock count", "Error");
            else
            {
                //Use overloaded operator to update stock
                Product currentProduct = FindProduct();
                if (currentProduct.InStock >= updateStock && currentProduct - updateStock)
                {
                    MessageBox.Show("Stock count updated", "Success");
                    lstAllProducts.Items.Clear();
                    DisplayProducts();
                    lstAllProducts.SelectedIndex = index;
                }
                //if quantity to remove is more than 
                else
                    MessageBox.Show("Failed to update stock", "Error");
            }
        }

        //Add new item button is clicked - open new form
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            //Open form to add new item
            frmAddItem addItem = new frmAddItem();
            addItem.ShowDialog();
        }

        //Generate report is clicked - refresh list and open savefile dialog
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            DialogResult userSelection = sfdInventoryReport.ShowDialog();
            if(userSelection == DialogResult.Cancel) 
            {
                MessageBox.Show("Cancelled Report", "Report not Generated");
            }
            else
            {
                //Generate values for report
                int totalOnHand = 0;
                StreamWriter outputFile = new StreamWriter(sfdInventoryReport.FileName);
                outputFile.WriteLine("INVENTORY REPORT HD ART\n");
                outputFile.WriteLine("\nCode       Description              Price        In Stock");
                for(int i = 0; i<frmLogin.products.Count; i++) 
                {
                    //loop through product list to fill report
                    Product product = frmLogin.products[i];
                    string output = String.Format("{0,-10}{1,-25}{2,10:c}{3,10}", 
                        product.Code, product.Description, product.Price, product.InStock);
                    outputFile.WriteLine(output);
                    totalOnHand += product.InStock;
                }
                //Write final line of report and close streamwriter
                outputFile.WriteLine("\nTotal Product on Hand: " + totalOnHand.ToString());
                outputFile.Close();
            }
        }


        //Methods
        /*Name: DisplayProducts
         *Sent: None
         *Returned: None
         *This method displays the products in the listbox*/
        public void DisplayProducts()
        {
            lstAllProducts.Items.Clear();
            foreach (Product product in frmLogin.products)
            {
                lstAllProducts.Items.Add(product.DisplayInfo());
            }
        }

        /*Name: FindProduct
         *Sent: string code
         *Returned: Product
         *This method loops through the product list to find the matching item and returns that product*/
        public Product FindProduct()
        {
            Product currentProduct = null;
            if (lstAllProducts.SelectedIndex != -1)
            {
                string listItem = lstAllProducts.SelectedItem.ToString();
                string code = listItem.Substring(0, 5);
                foreach (Product product in frmLogin.products)
                {
                    if (product.Code == code)
                    {
                        currentProduct = product;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item", "Error");
            }
            return currentProduct;
        }  
    }
}
