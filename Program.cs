using DesafioPOO.Models;
Console.WriteLine("\n");

Console.WriteLine("Nokia 220KS");
Nokia nokia = new Nokia("11999999999", "Nokia 220KS", "1234567891011", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone 13");
Iphone iphone = new Iphone("22999999999", "Iphone 13", "010101010101", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");