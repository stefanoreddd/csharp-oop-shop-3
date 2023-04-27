using C__Shop_3;


Console.OutputEncoding = System.Text.Encoding.Unicode; // Per inserire i caratteri speciali


Shop negozioMilano = new Shop("Negozio Milano", "Milano", "Italia", "Via Aldo Rossi", 8, "Jerry Cardinale");


Water acquaLilia = new Water("Bottiglietta d'acqua Lilia", "Bevande", "Bottiglietta d'acqua da 0,5L naturale", 1, 0.5d, 7, "Rubinetto", "Lilia", "Naturale", "Plastica");

List<Products> prodottiNegozioMilano = new List<Products> { acquaLilia };


negozioMilano.productToAdd(prodottiNegozioMilano);




Console.WriteLine(negozioMilano.ToString());

try
{
    acquaLilia.Bevi();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("Numero di litri dopo aver bevuto la bottiglia: " + acquaLilia.GetLitri());
Console.WriteLine();

try
{
    acquaLilia.Riempi();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    acquaLilia.SetLitri(0.5d);
}

Console.WriteLine();
Console.WriteLine("Numero di litri dopo aver riempito la bottiglia: " + acquaLilia.GetLitri());
Console.WriteLine();

try
{
    acquaLilia.Svuota();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



