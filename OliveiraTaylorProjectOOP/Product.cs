using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTaylorOOPFinalProject
{
    //Add list of products
    public abstract class Product
    {
        //Properties
        public int InStock { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Constructors
        public Product() { }
        public Product(int inInStock, string inCode, decimal inPrice, string inDescription)
        {
            InStock = inInStock;
            Code = inCode;
            Price = inPrice;
            Description = inDescription;
        }

        //Methods
        /*Name: DisplayInfo
         *Sent: None
         *Returned: String
         *This method displays product information in the specified format*/
        public virtual string DisplayInfo()
            => String.Format("{0,-8}{1,-25}", Code, Description);

        /*Name: DisplayCart
         *Sent: None
         *Returned: String
         *This method displays product information in the format for the cart*/
        public string DisplayCart()
            => String.Format("{0,-25}{1,6:c}", Code, Price);
        //Operator Overloading

        //Mathmatical Operators
        /*Operator: -
         *Sent: Product, int
         *Returned: bool
         *removes a specified value from product in stock*/
        public static bool operator - (Product product, int inventory)
        {
            bool inventoryRemoved = false;

            if (inventory <= product.InStock && inventory > 0)
            {
                int newInventory = product.InStock - inventory;
                product.InStock = newInventory;
                inventoryRemoved = true;
            }
            return inventoryRemoved;
        }

        /*Operator: +
         *Sent: Product, int
         *Returned: bool
         *Adds a specified value to product in stock*/
        public static bool operator + (Product product, int inventory)
        {
            bool inventoryAdded = false;

            if (inventory > 0)
            {
                int newInventory = product.InStock + inventory;
                product.InStock = newInventory;
                inventoryAdded = true;
            }
            return inventoryAdded;
        }

        //OVERLOADED OVERRIDDEN OPERATOR
        /*Operator: +
         *Sent: List, Product
         *Returned: bool
         *Adds a new product to the product list*/
        public static bool operator + (List<Product> productList, Product product)
        {
            bool productAdded = true;
            //check if the product being added is equal to any in the list
            foreach(Product product1 in productList)
            {
                if (product == product1)
                {
                    //if equal, return false and break out of loop
                    productAdded = false;
                    MessageBox.Show("Cannot add a product with the same code or " +
                        "description as an already existing product", "Error");
                    break;
                }
            }
            //return boolean for whether the product was added or not
            productList.Add(product);
            return productAdded;
        }

        /*Operator: ==
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public static bool operator == (Product existingProduct, Product newProduct) 
        {
            bool equals = false;
            if (existingProduct.Code == newProduct.Code || existingProduct.Description == newProduct.Description)
            {
                equals = true;
            }
            return equals;
        }

        /*Operator: !=
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public static bool operator !=(Product existingProduct, Product newProduct)
            => !(existingProduct == newProduct);
        

        /*Operator: EqualsTo
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public override bool Equals(Object product)
        {
            bool equals = false;
            Product p = (Product)product;
            if (Code == p.Code && Description == p.Description)
                return true;
            return equals;
        }

        /*Operator: GetHashCode
         *Sent: None
         *Return: int
         *Returns a unique hash code for the current item*/
        public override int GetHashCode()
        {
            string hashString = Code + GetType().Name + Description + Price;
            return hashString.GetHashCode();
        }

    }//END PRODUCT


    //START PHOTO CLASS
    public sealed class Photo : Product
    {
        //Properties
        public bool Digital { get; set; }
        public bool Colour { get; set; }

        //Constructors
        public Photo() { }
        public Photo(int inInStock, string inCode, decimal inPrice, string inDescription, bool inDigital, bool inColour) :
            base(inInStock, inCode, inPrice, inDescription)
        {
            Digital = inDigital;
            Colour = inColour;
        }

        //Methods

        /*Name: DisplayInfo
         *Sent: Product
         *Returned: String
         *This is overridden from the base class - adds additional information*/
        public override string DisplayInfo()
            => base.DisplayInfo() + String.Format("{0,-15}{1,20}{2,15:c}{3,10}",
                ("Digital: " + Digital), ("Colour: " + Colour), Price, InStock);
    } //END PHOTO

    //START PAINTING CLASS
    public sealed class Painting : Product
    {
        //Properties
        public bool Original { get; set; }
        public bool Framed { get; set; }

        //Constructors
        public Painting() { }
        public Painting(int inInStock, string inCode, decimal inPrice, string inDescription, bool inOriginal, bool inFramed) :
            base(inInStock, inCode, inPrice, inDescription)
        {
            Original = inOriginal;
            Framed = inFramed;
        }
        
        //Methods

        /*Name: DisplayInfo
         *Sent: Product
         *Returned: String
         *This is overridden from the base class - adds additional information*/
        public override string DisplayInfo()
            => base.DisplayInfo() + String.Format("{0,20}{1,20}{2,15:c}{3,10}",
                ("Original: " + Original), ("Framed: " + Framed), Price, InStock);

    }//END PAINTING
}
