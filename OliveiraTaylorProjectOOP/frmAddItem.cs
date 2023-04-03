using Classy;
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
    //HIDE GRPPRODUCTINFO until either radio button in checked
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";
        }

        //Product type is chosen
        private void btnSelectType_Click(object sender, EventArgs e)
        {
            //Check that at least 1 radio button is checked
            if(!radPhoto.Checked && !radPainting.Checked)
            {
                MessageBox.Show("Must select a product type");
            }
            else
            {
                //Change the label text based on product type
                if (radPainting.Checked)
                {
                    lblColourFrame.Text = "Framed: ";
                    lblDigitalOriginal.Text = "Original: ";
                }
                else if (radPhoto.Checked)
                {
                    lblColourFrame.Text = "In Colour: ";
                    lblDigitalOriginal.Text = "Digital: ";
                }
                grpProductInfo.Show();
                grpProductType.Enabled = false;
            } 
        }

        //Validate that all text boxes are filled properly before adding the new item to the list
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtNumInStock) &&
                Validator.IsPresent(txtDigitalOriginal) &&
                Validator.IsPresent(txtColourFrame) &&
                Validator.IsInt32(txtCode) &&
                Validator.IsDecimal(txtPrice) &&
                Validator.IsInt32(txtNumInStock) &&
                Validator.IsBoolean(txtDigitalOriginal) &&
                Validator.IsBoolean(txtColourFrame))
            {
                if(radPainting.Checked)
                {
                    //Create new painting object and add to list
                    Painting painting = new Painting();
                    painting.Code = "PA" + txtCode.Text;
                    painting.Price = Convert.ToDecimal(txtPrice.Text);
                    painting.Description = txtDescription.Text;
                    painting.InStock = Convert.ToInt32(txtNumInStock.Text);
                    painting.Original = Convert.ToBoolean(txtDigitalOriginal.Text);
                    painting.Framed = Convert.ToBoolean(txtColourFrame.Text);
                    if (frmLogin.products + painting)
                        MessageBox.Show("Painting added successfully", "Success");
                }
                if (radPhoto.Checked)
                {
                    //Create new photo object and add to list
                    Photo photo = new Photo();
                    photo.Code = "PH" + txtCode.Text;
                    photo.Price = Convert.ToDecimal(txtPrice.Text);
                    photo.Description = txtDescription.Text;
                    photo.InStock = Convert.ToInt32(txtNumInStock.Text);
                    photo.Digital = Convert.ToBoolean(txtDigitalOriginal.Text);
                    photo.Colour = Convert.ToBoolean(txtColourFrame.Text);
                    if (frmLogin.products + photo)
                        MessageBox.Show("Photo added successfully", "Success");
                }
                //Clear text boxes and hide grpProductInfo enable grpProductType
                grpProductType.Enabled = true;
                grpProductInfo.Hide();
                txtCode.Clear();
                txtDescription.Clear();
                txtNumInStock.Clear();
                txtDigitalOriginal.Clear();
                txtColourFrame.Clear();
                txtPrice.Clear();
            }
        }
    }
}
