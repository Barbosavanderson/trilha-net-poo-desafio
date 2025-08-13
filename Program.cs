using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("123456789");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Smartphone nokia = new Nokia("987654321");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");  
        Console.WriteLine("Testes concluídos com sucesso!");
    }
}