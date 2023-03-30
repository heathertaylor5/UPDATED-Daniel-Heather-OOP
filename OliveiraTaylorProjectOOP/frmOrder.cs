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

        private void Order_Load(object sender, EventArgs e)
        {
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";
            List<Product> products = ProductDB.GetProducts();

            foreach(Product product in products)
            {
                lstInventory.Items.Add(product.DisplayInfo());
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
