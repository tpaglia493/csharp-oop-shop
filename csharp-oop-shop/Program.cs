/*
nome repo: csharp-oop-shop
Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
 codice (numero intero)
nome
descrizione
prezzo
iva


Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter (o eventualmente le properties) 
ed eventuali altri metodi di “utilità” per fare in modo che:

Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.


BONUS:
create un metodo che restituisca il codice con un pad left di '0' per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, 
mentre codice 123445567 resta come è)
Usando un array, dichiarate un elenco dei prodotti di un negozio
e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio. (Suggerimento potreste guardarvi List) 
 */


using csharp_oop_shop;

//TEST TO GENERATE CODES
for(int i = 0; i < 100; i++) { 
Product test = new Product("test1");

Console.WriteLine(test.getCode());

}