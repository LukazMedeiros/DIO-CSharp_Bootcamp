
using Desafio.NET_POO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia = new Nokia();
        Iphone iphone = new Iphone();

        nokia.Memoria = "512mb";
        nokia.Numero = "(11) 99999-8888";
        nokia.IMEI = "87768597687576476";

        iphone.Memoria = "1gb";
        iphone.Numero = "(21) 99999-1111";
        iphone.IMEI = "213123124123123123";

        nokia.Ligar();
        nokia.InstalarAplicativo("whatsapp");
        nokia.ReceberLigacao();

        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");
        iphone.ReceberLigacao();
    }
}