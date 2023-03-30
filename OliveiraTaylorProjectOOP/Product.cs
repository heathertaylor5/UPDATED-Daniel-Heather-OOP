using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorProjectOOP
{
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
         *Sent: Product
         *Returned: String
         *This method displays product information in the specified format*/
        public virtual string DisplayInfo()
            => String.Format("{0,-8}{1,-15}{2,-7:c}{3,4},Code, Description, Price, Instock");

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
                int newInventory = product.InStock - inventory;
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
            bool productAdded = false;

            return productAdded;
        }

        /*Operator: ==
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public static bool operator == (Product existingProduct, Product newProduct) 
        {
            bool equals = false;

            return equals;
        }

        /*Operator: !=
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public static bool operator !=(Product existingProduct, Product newProduct)
        {
            bool equals = false;

            return equals;
        }

        /*Operator: EqualsTo
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public static bool Equals(Product existingProduct, Product newProduct)
        {
            bool equals = false;

            return equals;
        }

        /*Operator: GetHashCode
         *Sent: Product, Product
         *Return: bool
         *Checks that the product codes and descriptions are unique*/
        public override int GetHashCode()
        {
            int code = 0;

            return code;
        }

    }

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
            =>GetType().Name + base.DisplayInfo() + Digital + " " + Colour;
    }

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
            =>GetType().Name + base.DisplayInfo() + "Orignal: " + Original + "Framed: " + Framed;
        
    }
}
