using BilleteraEjercicio13.Moldes;

Billetera Billetera1 = new Billetera(7,6,5,4,3,2,1); 
Console.WriteLine($"Total billetera1: {Billetera1.Total().GetType()}"); 
Console.WriteLine($"Total billetera1: {Billetera1.Total()}"); 


Billetera Billetera2 = new Billetera(1,2,3,4,5,6,7);
Console.WriteLine($"Total billetera2: {Billetera2.Total()}");


Billetera Billetera3 = new Billetera();

Billetera3 = Billetera1.Combinar(Billetera2);

Console.WriteLine($"Total billetera3: {Billetera3.Total()}");
Console.WriteLine($"Total billetera1: {Billetera1.Total()}");
Console.WriteLine($"Total billetera2: {Billetera2.Total()}");

