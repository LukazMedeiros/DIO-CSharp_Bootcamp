using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Hotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            if (nome == "" || sobrenome == "")
            {
                throw new Exception("Nome e sobrenome não podem ser vazios");
            }
            _nome = nome;
            _sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new Exception("Nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new Exception("Sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }
    }
}