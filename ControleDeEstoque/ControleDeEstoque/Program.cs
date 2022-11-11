using System;

namespace ControleDeEstoque
{
    class Program
    {
        struct Produtos //Dados dos produtos
        {
            public string nome;
            public int qntProduzida;
            public int qntVendida;
            public int qntEstoque;
        }

        static void Main(string[] args)
        {                        
            /* fiz esse projeto com array por isso preciso perguntar quantos 
             * produtos tem já que o array não são autoincremete como list 
             * mas amanha quando eu fizer um controle de livraria farei com list*/

            Console.WriteLine("Quantos produtos a empresa tem ?");
            int qntProdutos = Convert.ToInt32(Console.ReadLine());

            
            Produtos[] produtos = new Produtos[qntProdutos];//Array de struct
            Produtos produtostroca = new Produtos();//Array de troca para fazer a ordenação.

            for (int i = 0; i < produtos.Length; i++)//entrada dos dados
            {
                Console.WriteLine($"Coloque o nome do {i+1}º produto");
                produtos[i].nome = Console.ReadLine();

                Console.WriteLine($"Coloque a quantidade produzida de {produtos[i].nome}");
                produtos[i].qntProduzida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Coloque a quantidade vendida de {produtos[i].nome}");
                produtos[i].qntVendida = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                produtos[i].qntEstoque = produtos[i].qntProduzida - produtos[i].qntVendida;
            }

            for(int i = 0; i < produtos.Length - 1; i++)
            {
                for(int j = 1; j < produtos.Length; j++)
                {

                    if (produtos[i].qntEstoque > produtos[j].qntEstoque)//Ordenação em ordem crescente
                    {
                        produtostroca = produtos[i];;
                        produtos[i] = produtos[j];
                        produtos[j] = produtostroca;
                    }
                }
            }

            int opcao;
            Console.WriteLine(" 1 - Imprimir o produto com maior quantidade no estoque \n " +
                "2 - Imprimir o produto com menor quantidade no estoque \n " +
                "3 - imprimir o produto com maior e menor quantidade \n " +
                "4 - Imprimir todas os produtos" +
                "5 - Sair");//Menu

            do
            {
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{produtos[produtos.Length - 1].nome} \n {produtos[produtos.Length - 1].qntEstoque} \n ===============");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine($"{produtos[0].nome} \n {produtos[0].qntEstoque} \n ===============");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"O produto em menor quantidade no estoque : \n " +
                            $"{produtos[0].nome} \n {produtos[0].qntEstoque} \n =============== \n");

                        Console.WriteLine($"O produto em maior quantidade no estoque : " +
                            $"{produtos[produtos.Length - 1].nome} \n {produtos[produtos.Length - 1].qntEstoque} \n ===============");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        for (int i = 0; i < produtos.Length; i++)
                        {
                            Console.WriteLine($"Nome : {produtos[i].nome}\n " +
                                $"Quantidade Produzida : {produtos[i].qntProduzida}\n " +
                                $"Quantidade Vendida : {produtos[i].qntVendida}\n " +
                                $"Quantidade em Estoque : {produtos[i].qntEstoque} \n\n");

                        }
                        break;
                    case 5:
                        Console.WriteLine("Raphael a disposição só me contratar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: 
                        Console.WriteLine("Opção invaliada");
                        break;

                }

                Console.WriteLine(" 1 - Imprimir o produto com maior quantidade no estoque \n " +
                    "2 - Imprimir o produto com menor quantidade no estoque \n " +
                    "3 - imprimir o produto com maior e menor quantidade \n " +
                    "4 - Imprimir todas os produtos \n " +
                    "5 - Sair");

            } while (opcao != 5);//iteração do menu
            Console.ReadLine(); 

        }
    }
}