using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade}, sou Professor e tenho um salario de {Salario} reais");
        }
    }
}