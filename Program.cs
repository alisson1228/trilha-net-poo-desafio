using DesafioPOO.Models;

Nokia sp1 = new Nokia(numero: "(88) 99999-9999", modelo: "S10", imei: "4444444", memoria: 128);
Iphone sp2 = new Iphone(numero: "(85) 99999-9999", modelo: "I15MAX", imei: "5555555", memoria: 64);

Console.WriteLine("Smartphone Nokia\n");

sp1.Ligar();
sp1.SobreDispositivo();
sp1.InstalarAplicativo("Whatsapp");


Console.WriteLine("\nSmartphone Iphone\n");

sp2.ReceberLigacao();
Console.WriteLine("Numero: " + sp2.Numero);
Console.WriteLine("Modelo: " + sp2.Modelo);
Console.WriteLine("IMEI: " + sp2.IMEI);
Console.WriteLine("Memoria: " + sp2.Memoria);

sp2.InstalarAplicativo("Youtude");

sp1.Numero = "(88) 99666-6666";

Console.WriteLine("\nSmartphone Nokia\n");

sp1.SobreDispositivo();