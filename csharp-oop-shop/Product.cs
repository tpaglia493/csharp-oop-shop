using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    /*
     Gli altri attributi siano accessibili sia in lettura che in scrittura
     Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
     Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
     Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
      */
    public class Product
    {
        //ATTRIBUTES & PROPERTIES
        private int code;
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }

        private string description;
        public string Description { get { return this.description; } set { this.description = value; } }

        private float price;
        public float Price { get { return this.price; } set { this.price = value; } }

        private float iva;

        public float Iva { get { return this.iva; } set { this.iva = value; } }
        //STATES


        //CONSTRUCTOR

        public Product(string name)
        {
            this.name = name;
            CodeGenerator();
        }

        public Product(string name, string description, float price, float iva)
        {
            this.name= name;
            CodeGenerator();
            this.description = description;
            this.price = price;
            this.iva = iva;
        }



        //GETTERS
        public int getCode()
        {
            return this.code;
        }

        //METHODS

        private void CodeGenerator() 
        {
            Random code = new Random();
            this.code = code.Next(1, 99999999);
        }

        public string GetInfo()
        {
            string info = this.code +" " + Name;
                 return info;
        }
       
        public float GetIvaPrice()
        {
            float ivaPrice = Price + Price * Iva;
            return ivaPrice;
        }
    }
}
