using SistemaDeCelularesPOO.Models;

Console.WriteLine("\n");

Console.WriteLine("--------- Smartphone Nokia ---------\n");
Smartphone nokia = new Nokia(numero: "(21) 91234-1234", modelo: "N-95", imei: "01010101", memoria: 16);


nokia.Caracteristicas();
Console.WriteLine("");

nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();


Console.WriteLine("\n");

Console.WriteLine("--------- Smartphone Iphone ---------\n");
Smartphone iphone = new Iphone(numero: "(21) 99876-9876", modelo: "12 Pro Max", imei: "02020202", memoria: 64);

iphone.Caracteristicas();
Console.WriteLine("");

iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

Console.WriteLine("\n");