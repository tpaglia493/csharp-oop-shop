using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        //ATTRIBUTES
        private int code;
        private string name;
        private string description;
        private float price;
        private float iva;

        //STATES


        //CONSTRUCTOR
        public Product(string name) 
        { 
            this.name = name;
            CodeGenerator();
        }
        /*
        Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        Il codice prodotto sia accessibile solo in lettura
        Gli altri attributi siano accessibili sia in lettura che in scrittura
        Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
        Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
        Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
         */
        //GETTERS
        public int getCode()
        {
            return this.code;
        }

        //SETTERS

        //METHODS

        private void CodeGenerator() 
        {
            Random code = new Random();
            this.code = code.Next(1, 99999999);
        }
    }
}
