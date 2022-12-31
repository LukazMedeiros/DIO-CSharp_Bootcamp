using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.NET_POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public string Memoria { get; set; }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação....");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}