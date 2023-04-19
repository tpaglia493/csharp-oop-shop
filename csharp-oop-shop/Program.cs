/*

BONUS:
create un metodo che restituisca il codice con un pad left di '0' per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, 
mentre codice 123445567 resta come è)
Usando un array, dichiarate un elenco dei prodotti di un negozio
e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio. (Suggerimento potreste guardarvi List) 
 */


using csharp_oop_shop;

//TEST TO GENERATE CODES


Product test = new Product("test1","è solo un test",25.00f,22f);
string info = test.GetInfo();

Console.WriteLine(test.getFormattedCodePadLeft8());
Console.WriteLine(test.Name);
Console.WriteLine(test.Description);
Console.WriteLine(test.Price);
Console.WriteLine(test.Iva);
Console.WriteLine(info);
Console.WriteLine(test.GetIvaPrice());
