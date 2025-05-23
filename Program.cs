using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("01", "16", "123", 256);
Smartphone nokia = new Nokia("02", "17", "234", 128);

Console.WriteLine($"Iphone {iphone.Numero} ------ ");
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine($"Nokia {nokia.Numero} ------ ");
nokia.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();