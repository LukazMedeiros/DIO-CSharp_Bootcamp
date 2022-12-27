using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Hotel.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            if (diasReservados < 1)
            {
                throw new Exception("Ao menos 1 dia deve ser reservado");
            }
            _diasReservados = diasReservados;
        }
        private List<Pessoa> _hospede;
        private Suite _suite;
        private int _diasReservados;
        List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get => _suite; set; }
        public int DiasReservados { get => _diasReservados; set; }
        public void CadastrarHospedes(List<Pessoa> hospedes) { }
        public void CadastrarSuite(Suite suite) { }
        public int ObterQuantidadeHospedes() { return 0; }
        public decimal CalcularValorDiaria() { return 0; }

    }
}