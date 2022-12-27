using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Hotel.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (tipoSuite == "")
            {
                throw new Exception("Tipo de suite nao pode ser vazio");
            }
            if (value < 1)
            {
                throw new Exception("A capacidade mínima é 1");
            }
            if (value < 0)
            {
                throw new Exception("O valor não pode ser negativo");
            }
            _tipoSuite = tipoSuite;
            _capacidade = capacidade;
            _valorDiaria = valorDiaria;
        }

        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;
        public string TipoSuite
        {
            get => _tipoSuite;
            set
            {
                if (value == "")
                {
                    throw new Exception("Tipo de suite nao pode ser vazio");
                }
            }
        }
        public int Capacidade
        {
            get => _capacidade;
            set
            {
                if (value < 1)
                {
                    throw new Exception("A capacidade mínima é 1");
                }
            }
        }
        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set
            {
                if (value < 0)
                {
                    throw new Exception("O valor não pode ser negativo");
                }
            }
        }
    }
}