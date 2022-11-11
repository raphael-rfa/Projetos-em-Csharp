using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var livros = new List<Livro>();
            var ordenarlivros = new List<Livro>() { new Livro() { Id = 0, Titulo = " ", Autor = " ", Area = " ", Ano = 0, Editora = " " } };
            int opcao;

            do
            {
                Console.WriteLine("- 1 - Cadastrar \n- 2 - Imprimir Livros Cadastrados\n- 3 - Pesquisar livros por nome\n- 4 - Ordenar os livros por ano\n- 5 - Sair\n");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n Cadastrar livro nessa sequencia : \n Condigo: \n Titulo: \n Autor: \n Area: \n Ano: \n Editora: \n");
                        livros.Add(new Livro() { Id = Convert.ToInt32(Console.ReadLine()), Titulo = Console.ReadLine(), Autor = Console.ReadLine(), Area = Console.ReadLine(), Ano = Convert.ToInt32(Console.ReadLine()), Editora = Console.ReadLine() });
                        Console.WriteLine("Livro cadastrado !!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        foreach (var livro in livros)
                        {
                            Console.WriteLine("lista de todos os livros cadastrados :");
                            Console.WriteLine($" Codigo = {livro.Id}\n titulo = {livro.Titulo}\n Autor = {livro.Autor}\n Area = {livro.Area}\n Ano = {livro.Ano}\n Editora = {livro.Editora}\n =========");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Digite o livro que procura ");
                        string plvpesquisada = Console.ReadLine();

                        var pesquisa = from info in livros
                                       where info.Titulo.Contains(plvpesquisada)
                                       select info;

                        foreach (var info in pesquisa)
                        {
                            Console.WriteLine($"Titulo : {info.Titulo}, Codigo : {info.Id} ");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        for (int i = 0; i < livros.Count - 1; i++)
                        {
                            for (int j = 1; j < livros.Count; j++)
                            {
                                if (livros[i].Ano > livros[j].Ano)
                                {
                                    ordenarlivros[0] = livros[i];
                                    livros[i] = livros[j];
                                    livros[j] = ordenarlivros[0];
                                }
                            }
                        }

                        Console.WriteLine("Ordenado com sucesso !! para ver a lista inteira digite a segunda opção do menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }


            } while (opcao != 5 );

            Console.WriteLine("Raphael-rfa a sua disposição !!");
        }
        public class Livro
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Area { get; set; }
            public int Ano { get; set; }
            public string Editora { get; set; }
        }


    }
}