using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone NOKIA:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "A12", imei: "123445589", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("Smartphone IPHONE:");
Smartphone iphone = new Iphone(numero: "0998543", modelo: "Iphone 13", imei: "123445589", memoria: 12);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");


