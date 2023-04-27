using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class Products
    {

        private static int numberOfGeneratedProducts = 0;

        //ATTRIBUTI

        private string productName;
        private string productCategory;
        private string productDescription;
        private int productPrice;
        


        //COSTRUTTORE

        public Products(string productName, string productCategory, string productDescription, int productPrice)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productDescription = productDescription;
            this.productPrice = productPrice;

        }


        //GETTERS

        public string GetProductName()
        {
            return this.productName;
        }

        public string GetProductCategory()
        {
            return this.productCategory;
        }

        public string GetProductDescription()
        {
            return this.productDescription;
        }

        public int GetProductPrice()
        {
            return this.productPrice;
        }


        //SETTERS


        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public void SetProductCategory(string category)
        {
            this.productCategory = category;
        }

        public void SetProductDescription(string description)
        {
            this.productDescription = description;
        }



        //METODI

        public string ProductInfoList()
        {
            string productInfo = "Nome Prodotto: " + this.productName + "\n";
            productInfo += "Categoria: " + this.productCategory + "\n";
            productInfo += "Descrizione: " + this.productDescription + "\n";
            productInfo += "Prezzo: " + this.productPrice + " euro" + "\n";


            return productInfo;

        }
    }
}
