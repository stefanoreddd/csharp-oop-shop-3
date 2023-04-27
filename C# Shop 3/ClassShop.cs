using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class Shop
    {
        // ATTRIBUTI

        private string name;
        private string city;
        private string country;
        private string address;
        private int number;
        private string owner;
        private List<Products> prodotti;

        // COSTRUTTORE

        public Shop(string name, string city, string country, string address, int number, string owner)
        {
            this.name = name;
            this.city = city;
            this.country = country;
            this.address = address;
            this.number = number;
            this.owner = owner;

            this.prodotti = new List<Products>();
        }

        // GETTERS

        public string GetName()
        {
            return this.name;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetCountry()
        {
            return this.country;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public string GetOwner()
        {
            return this.owner;
        }


        // SETTERS

        public void SetCity(string city)
        {
            this.city = city;
        }

        public void SetCountry(string country)
        {
            this.country = country;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetOwner(string owner)
        {
            this.owner = owner;
        }


        // METODI

        public void addProduct(Products nuovoProdotto)
        {
            prodotti.Add(nuovoProdotto);
        }

        public void productToAdd(List<Products> ListProduct)
        {
            foreach (Products newProduct in ListProduct)
            {
                this.prodotti.Add(newProduct);
            }

        }

        public string ShopInfoList()
        {
            string shopInfoList = "Nome negozio: " + this.name + "\n";
            shopInfoList += "Indirizzo: " + this.address + ", " + this.number + "\n";
            shopInfoList += "Città: " + this.city + ", " + this.country + "\n";

            foreach (Products infoProduct in prodotti)
            {
                shopInfoList += infoProduct.ToString() + "\n";
            }

            shopInfoList += "\n";

            return shopInfoList;
        }
    }
}
