using DesafioPOO.Models;

Nokia nokia = new Nokia("123456", "Nokia", "asd-123", 64);
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Iphone iphone = new Iphone("654321", "Iphone", "dsa-321", 128);
Console.WriteLine("Iphone");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

