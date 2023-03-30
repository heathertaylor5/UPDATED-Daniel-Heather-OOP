using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OliveiraTaylorOOPFinalProject
{
    public static class ProductDB
    {
        //Set the path to find the XML File
        private const string Path = @"C:\Users\heath\Desktop\UPDATED-Daniel-Heather-OOP\OliveiraTaylorProjectOOP\Products.xml";

        /*Name: GetProducts
         *Sent: none
         *Returned: List<Product>
         *This function populates a list of products from an xml file*/
        public static List<Product> GetProducts()
        {
            //Create the list
            List<Product> products = new List<Product>();

            //Create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments= true;

            //Create the Xml Reader object using the path and settings determined earlier
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            //Read past all nodes to the first Painting node
            if(xmlIn.ReadToDescendant("Painting"))
            {
                //Create one Painting object for each Painting node
                do
                {
                    //Create new painting object and fill data with information from xml file
                    Painting painting = new Painting();
                    xmlIn.ReadStartElement("Painting");
                    painting.Code = xmlIn.ReadElementContentAsString();
                    painting.Description = xmlIn.ReadElementContentAsString();
                    painting.Price = xmlIn.ReadElementContentAsDecimal();
                    painting.Original = xmlIn.ReadElementContentAsBoolean();
                    painting.Framed = xmlIn.ReadElementContentAsBoolean();
                    products.Add(painting);
                }
                while (xmlIn.ReadToNextSibling("Painting"));
            }
            if(xmlIn.ReadToDescendant("Photo"))
            {
                do
                {
                    Photo photo = new Photo();
                    xmlIn.ReadStartElement("Photo");
                    photo.Code = xmlIn.ReadElementContentAsString();
                    photo.Description = xmlIn.ReadElementContentAsString();
                    photo.Price = xmlIn.ReadElementContentAsDecimal();
                    photo.Digital = xmlIn.ReadElementContentAsBoolean();
                    photo.Colour = xmlIn.ReadElementContentAsBoolean();
                    products.Add(photo);
                }
                while (xmlIn.ReadToDescendant("Photo"));
            }

            //Close xmlReader object
            xmlIn.Close();
            //Return the list
            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            //create xmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("  ");

            //Create xmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            //write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Products");

            //Loop through list to add products to xml file
            foreach (Product product in products) 
            {
                //Write painting elements
                xmlOut.WriteStartElement(product.GetType().Name);
                xmlOut.WriteElementString("Code", product.Code);
                xmlOut.WriteElementString("Description", product.Description);
                xmlOut.WriteElementString("Price", Convert.ToString(product.Price));
                if (product.GetType().Name == "Painting")
                {
                    
                }
                   
            }

            //Write end tag for root element and Close xmlWriter
            xmlOut.WriteEndElement();
            xmlOut.Close();
        }
    }
}
