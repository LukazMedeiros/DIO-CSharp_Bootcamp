using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Desafio.Fundamentos.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal precoHora { get; set; }
        private List<string> Veiculos = new List<string>();
        public bool Cadastrar(string placa)
        {
            if (placa == "")
            {
                Console.WriteLine("Uma placa deve ser informada");
                return false;
            }

            Regex mercosul = new Regex(@"[a-zA-z]{3}[0-9][a-zA-z][0-9]{2}");
            Regex antigo = new Regex(@"[a-zA-Z]{3}\-?[0-9]{4}");
            bool isMercosul = mercosul.IsMatch(placa);
            bool isModeloAntigo = antigo.IsMatch(placa);

            if (!isMercosul && !isModeloAntigo)
            {
                Console.WriteLine("A placa digitada é inválida");
                return false;
            }

            this.Veiculos.Add(placa);
            return true;
        }
        public bool Remover(string placa)
        {

            if (placa == "")
            {
                Console.WriteLine("Uma placa deve ser informada");
                return false;
            }

            if (!this.Veiculos.Contains(placa))
            {
                Console.WriteLine("O veículo informado não existe");
                return false;
            }

            this.Veiculos.Remove(placa);
            return true;
        }
        public string Listar()
        {
            if (this.QuantidadeVeiculos() < 1)
            {
                return "Não possui veículos cadastrados";
            }

            string veiculos = "";
            foreach (var item in Veiculos)
            {
                veiculos += $"\n Veículo placa: {item.ToString()}";
            }
            return veiculos;
        }

        public decimal CalcularTotal(int totalHoras)
        {
            decimal valorTotalHoras = totalHoras * this.precoHora;
            decimal total = this.PrecoInicial + valorTotalHoras;
            return total;
        }

        public int QuantidadeVeiculos()
        {
            return this.Veiculos.Count();
        }
    }
}