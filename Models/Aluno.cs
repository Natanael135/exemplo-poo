using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade}, e sou um aluno com media {Nota}");
        }

    }
}