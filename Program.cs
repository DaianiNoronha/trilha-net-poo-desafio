using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "0000", modelo: "Modelo 0", imei: "000", memoria: "120");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "1111", modelo: "Modelo 1", imei: "111", memoria: "64");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");