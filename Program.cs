using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
        {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Testando Nokia");
        Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789", memoria: 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");


        Console.WriteLine("Testando Iphone");
        Iphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 12", imei: "987654321", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
