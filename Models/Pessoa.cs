using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public virtual void Apresentar()
        {

            Console.WriteLine($"Olá Meu nome é {Nome}, eu tenho {Idade} anos");
        }
    }
}