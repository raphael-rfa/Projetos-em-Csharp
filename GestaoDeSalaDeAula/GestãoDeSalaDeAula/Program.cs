using System;
using System.Collections.Generic;

namespace GestaoDeSalaDeAula
{
    public class Aluno//Dados dos alunos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double Media 
        {
            get { return (Nota1 + Nota2+ Nota3 + Nota4)/4; } 
        }
    }
    public class Program
    {
        static void Main()
        {
            var alunos = new List<Aluno>();            
            int opcao; //Variavel do Menu

            alunos.Add( new Aluno() { Id = alunos.Count, Nome = "Harry Potter",
            Nota1 = 8.4D, Nota2 = 7.1D, Nota3 = 5.9D, Nota4 = 5.5D});
            
            alunos.Add( new Aluno() { Id = alunos.Count, Nome = "Ronald Weasley",
            Nota1 = 7.9D, Nota2 = 5.9D, Nota3 = 6.3D, Nota4 = 5.7D});

            alunos.Add( new Aluno() { Id = alunos.Count, Nome = "Hermione Granger",
            Nota1 = 10D, Nota2 = 10D, Nota3 = 10D, Nota4 = 10D});

            do
            {
                Console.WriteLine(" 1 - Cadastrar Aluno\n 2 - Exibir rank da turma\n 3 - Sair");//Menu
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(opcao)
                {
                    case 1://Cadastrar
                        alunos.Add(new Aluno() {});

                        Console.WriteLine("Cadastre o nome :");
                        alunos[^1].Nome = Console.ReadLine();

                        Console.WriteLine("Cadastre a primeira nota :");
                        alunos[^1].Nota1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a segunda nota :");
                        alunos[^1].Nota2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a terceira nota :");
                        alunos[^1].Nota3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a quarta nota :");
                        alunos[^1].Nota4 = Convert.ToInt32(Console.ReadLine()); 

                        Console.WriteLine("Cadastrado com sucesso !!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2://Ranquear Alunos da maior nota para a menor
                        List<Aluno> ordenaralunos = alunos.OrderByDescending(x => x.Media).ToList();
                        foreach (var aluno in ordenaralunos)
                        {
                            Console.WriteLine($"Nome : {aluno.Nome} \nMedia : {aluno.Media:#.##} \n" );
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }

            } while (opcao != 3);//Iteração do menu

            Console.WriteLine("Raphael-rfa a disposição");
        }
    }
}