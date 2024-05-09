using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarphone Nokia");
Smartphone nokia1 = new Nokia(numero: "12982156987", modelo: "FR58Ok32 ", imei: "111111", memoria: 128);
nokia1.Ligar();
nokia1.InstalarAplicativo(nomeApp: "WhatsApp");

Console.WriteLine("Smarphone Nokia");
Smartphone nokia2 = new Nokia(numero: "12991452387", modelo: "Nb26Ya42", imei: "121212", memoria: 256);
nokia2.ReceberLigacao();
nokia2.InstalarAplicativo(nomeApp: "Chrome");

Console.WriteLine("Smarphone Iphone");
Smartphone iphone1 = new Iphone(numero: "12991457896", modelo: "Iphone 10", imei: "333333", memoria: 128);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo(nomeApp: "Telegram");

Console.WriteLine("Smarphone Iphone");
Smartphone iphone2 = new Iphone(numero: "12997123698", modelo: "Iphone 15", imei: "323232", memoria: 256);
iphone2.Ligar();
iphone2.InstalarAplicativo(nomeApp: "Instagram");