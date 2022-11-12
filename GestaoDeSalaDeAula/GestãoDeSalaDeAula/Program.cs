using System;
using System.Collections.Generic;

namespace GestaoDeSalaDeAula
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            var ordenaralounos = new List<Aluno>() { new Aluno() {Id = 0, Nome = " ", Nota1 = 0, Nota2 = 0, Nota3 = 0, Nota4 = 0, Media = 0 } };
            int opcao, id = 0;

            do
            {
                Console.WriteLine("1 - Cadastrar Aluno\n2 - Exibir rank da turma\n3 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(opcao)
                {
                    case 1:
                        alunos.Add(new Aluno() { Id = id });

                        Console.WriteLine("Cadastre o Nome :");
                        alunos[id].Nome = Console.ReadLine();

                        Console.WriteLine("Cadastre a primeira nota :");
                        alunos[id].Nota1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a segunda Nota2 :");
                        alunos[id].Nota2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a terceira Nota3 :");
                        alunos[id].Nota3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cadastre a qaurta Nota4 :");
                        alunos[id].Nota4 = Convert.ToInt32(Console.ReadLine()); 
                        
                        alunos[id].Media = (alunos[id].Nota1 + alunos[id].Nota2 + alunos[id].Nota3 + alunos[id].Nota4) / 4;
                        id++;
                        Console.WriteLine("Cadastrado com sucesso !!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:

                        for (int i = 0; i < alunos.Count - 1; i++)
                        {
                            for (int j = 1; j < alunos.Count; j++)
                            {
                                if (alunos[i].Media < alunos[j].Media)
                                {
                                    ordenaralounos[i] = alunos[i];
                                    alunos[i] = alunos[j];
                                    alunos[j] = ordenaralounos[i];
                                }
                            }
                        }

                        foreach (var aluno in alunos)
                        {
                            Console.WriteLine($"Nome : {aluno.Nome} \nMedia : {aluno.Media} \n========" );
                        }
                        break;
                    default: break;
                }

            } while (opcao != 3);

            Console.WriteLine("Raphael-rfa a disposição");
        }

        public class Aluno
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Nota1 { get; set; }
            public double Nota2 { get; set;}
            public double Nota3 { get; set;}
            public double Nota4 { get; set;}
            public double Media { get; set;}
        }
    }
}