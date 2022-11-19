using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Livro//Dados dos livros 
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Area { get; set; }
        public int Ano { get; set; }
        public string? Editora { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int opcao = 0;//variavel de entrada do menu
            var livros = new List<Livro>();

            livros.Add(new Livro()//Inicialização para fazer correções mais rapidas
            {
                Id = livros.Count,
                Titulo = "Pai Rico Pai Pobre",
                Autor = "Robert Kiyosaki",
                Area = "Financas",
                Ano = 1997,
                Editora = "Alta Books"
            });
            livros.Add(new Livro()
            {
                Id = livros.Count,
                Titulo = "Os segredos da mente milionaria",
                Autor = "T. Harv Eker",
                Area = "Autoajuda",
                Ano = 2005,
                Editora = "Editora"
            });
            livros.Add(new Livro()
            {
                Id = livros.Count,
                Titulo = "Do mil ao milhão: Sem cortar o cafezinho",
                Autor = "Thiago Nigro",
                Area = "Financas",
                Ano = 2018,
                Editora = "Casa dos livros"
            });            

            do
            {
                Console.WriteLine("- 1 - Cadastrar \n- 2 - Imprimir Livros Cadastrados" +
                    "\n- 3 - Pesquisar livros por nome\n- 4 - Ordenar os livros por ano\n- 5 - Sair\n");//menu
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1://Cadastro
                        livros.Add( new Livro() { });
                        
                        livros[^1].Id = livros.Count;
                        
                        Console.WriteLine("\nTitulo:");
                        livros[^1].Titulo = Console.ReadLine();
                        
                        Console.WriteLine("\n Autor: ");
                        livros[^1].Autor = Console.ReadLine();
                        
                        Console.WriteLine("\nArea:");
                        livros[^1].Area = Console.ReadLine();
                        
                        Console.WriteLine("\nAno:");
                        livros[^1].Ano = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("\nEditora:");
                        livros[^1].Editora = Console.ReadLine();
                        
                        Console.WriteLine("\nLivro cadastrado !!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2://listar todos os livros cadastrados
                        foreach (var livro in livros)
                        {
                            Console.WriteLine("lista de todos os livros cadastrados :");
                            Console.WriteLine($" Codigo = {livro.Id}\n titulo = {livro.Titulo}\n Autor = {livro.Autor}\n Area = {livro.Area}\n Ano = {livro.Ano}\n Editora = {livro.Editora}\n =========");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3://Procurar livro
                        Console.WriteLine("Digite o livro que procura ");
                        string plvpesquisada = Console.ReadLine()!;

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
                    case 4://Ordenar livro
                        List<Livro> livrosordenados = livros.OrderBy(x => x.Ano).ToList();
                        foreach (var livro in livrosordenados)
                        {
                            Console.WriteLine("lista de todos os livros cadastrados :");
                            Console.WriteLine($" Codigo = {livro.Id}\n titulo = {livro.Titulo}\n Autor = {livro.Autor}\n Area = {livro.Area}\n Ano = {livro.Ano}\n Editora = {livro.Editora}\n =========");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            } while (opcao != 5 );
            Console.WriteLine("Raphael-rfa a sua disposição !!");
        }
    }
}