
using exemplo_poo.Models;


Aluno aluno1 = new Aluno("Natanael", 24);

aluno1.Nota = 10;
aluno1.Apresentar();

Professor prof1 = new Professor("Prof. Natanael", 40);
prof1.Salario = 1000M;
prof1.Apresentar();

Diretor diretor1 = new Diretor("Diretor Natanael", 60);
diretor1.Salario = 2000M;
diretor1.Apresentar();