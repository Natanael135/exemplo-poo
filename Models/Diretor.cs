using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome, int idade) : base(nome, idade)
        {
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade}, sou Diretor e tenho um salario de {Salario} reais");
        }
    }
}