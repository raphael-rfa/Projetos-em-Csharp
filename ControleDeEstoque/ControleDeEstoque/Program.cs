using System;
using System.Collections.Generic;

namespace ControleDeEstoque
{
    class Program
    {
        class Produtos //Dados dos produtos
        {
            public string? Nome { get; set; }
            public int QntProduzida { get; set; }
            public int QntVendida { get; set; }
            public int QntEstoque
            {
                get { return QntProduzida - QntVendida; }
            }

            static void Main()
            {
                int opcao;//Variavel do menu
                var produtos = new List<Produtos>();
                //Inicialização para poupar tempo
                produtos.Add(new Produtos() { Nome = "garrafa", QntProduzida = 10, QntVendida = 4 });
                produtos.Add(new Produtos() { Nome = "panela", QntProduzida = 10, QntVendida = 9 });
                produtos.Add(new Produtos() { Nome = "colher", QntProduzida = 10, QntVendida = 8 });
                produtos.Add(new Produtos() { Nome = "garfo", QntProduzida = 10, QntVendida = 7 });
                produtos.Add(new Produtos() { Nome = "faca", QntProduzida = 10, QntVendida = 6 });
                produtos.Add(new Produtos() { Nome = "tabua", QntProduzida = 10, QntVendida = 5 });
                produtos.Add(new Produtos() { Nome = "xicara", QntProduzida = 10, QntVendida = 6 });

                List<Produtos> produtosOrdenados = produtos.OrderBy(x => x.QntEstoque).ToList();

                do
                {
                    Console.WriteLine(" 1 - Cadastrar produto \n " +
                        "2 - Imprimir os produtos com maior e menor quantidade no estoque \n " +
                        "3 - Imprimir todas os produtos em ordem decrecente \n " +
                        "4 - Imprimir todas os produtos em ordem crescente\n " +
                        "5 - Sair");//Menu
                        opcao = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Clear();

                    switch (opcao)
                    {
                        case 1://Cadastro
                            produtos.Add(new Produtos() { });
                            Console.WriteLine($"Coloque o nome do {produtos.Count}º produto");
                            produtos[^1].Nome = Console.ReadLine();//O index ^1 siginifica .count - 1

                            Console.WriteLine($"Coloque a quantidade produzida de {produtos[^1].Nome}");
                            produtos[^1].QntProduzida = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Coloque a quantidade vendida de {produtos[^1].Nome}");
                            produtos[^1].QntVendida = Convert.ToInt32(Console.ReadLine());
                            produtosOrdenados = produtos.OrderBy(x => x.QntEstoque).ToList();
                            Console.Clear();
                            break;
                        case 2://Exibindo produto com maior e menor quantidade em estoque
                            Console.WriteLine($"O produto em menor quantidade no estoque : \n " +
                                $"{produtosOrdenados[0].Nome} \n {produtosOrdenados[0].QntEstoque} \n");

                            Console.WriteLine($"O produto em maior quantidade no estoque : \n " +
                                $"{produtosOrdenados[^1].Nome} \n {produtosOrdenados[^1].QntEstoque}");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3://Exibindo todos os produtos em ordem decrecente de quantidade no estoque
                            List<Produtos> produtosDecrescente = produtos.OrderByDescending(x => x.QntEstoque).ToList();
                            foreach (var produto in produtosDecrescente)
                            {
                                Console.WriteLine($" Nome : {produto.Nome}\n " +
                                    $"Quantidade Produzida : {produto.QntProduzida}\n " +
                                    $"Quantidade Vendida : {produto.QntVendida}\n " +
                                    $"Quantidade em Estoque : {produto.QntEstoque} \n\n");
                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4://Exibindo todos os produtos em ordem crescente de quantidade em estoque
                            foreach (var produto in produtosOrdenados)
                            {
                                Console.WriteLine($" Nome : {produto.Nome}\n " +
                                    $"Quantidade Produzida : {produto.QntProduzida}\n " +
                                    $"Quantidade Vendida : {produto.QntVendida}\n " +
                                    $"Quantidade em Estoque : {produto.QntEstoque} \n\n");                                
                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:break;
                    }
                } while (opcao != 5);//iteração do menu
                Console.WriteLine("Raphael a disposição só me contratar");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}