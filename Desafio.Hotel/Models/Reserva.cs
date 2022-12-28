using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Hotel.Models;

namespace Desafio.Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes excede a capacidade da suite!");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }
        public decimal CalcularValorDiaria()
        {
            decimal total = this.DiasReservados * Suite.ValorDiaria;
            if (this.DiasReservados >= 10)
            {
                total = total * 0.9m;
            }
            return total;
        }
    }
}