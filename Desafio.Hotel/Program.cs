using System.Text;
using Desafio.Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Hospede1");
Pessoa p2 = new Pessoa(nome:"Hospede2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite();