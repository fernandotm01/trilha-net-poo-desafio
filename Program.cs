// See https://aka.ms/new-console-template for more information
// TODO: Realizar os testes com as classes Nokia e Iphone
// Entrega do projeto finalizada, sem mais alterações necessárias.
// Fernando Milani

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");         
Nokia nokia = new Nokia(numero: "123456789", modelo: "Modelo X", imei: "123456789012345", memoria: 64);
nokia.Ligar();  
nokia.InstalarAplicativo("WhatsApp"); 
Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone();       
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
    
