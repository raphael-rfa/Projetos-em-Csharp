# 🗄 Repositorio de Projetos em C#

Destinado a pequenos projetos para testar a logica de programação com algoritmos nessa linguagem incrivel.

# 🧮 [Calculadora de IMC](https://github.com/raphael-rfa/csharp/blob/main/CalculoDoIMC/CalculoDoIMC/Program.cs)

Essa calculadora indica em qual faixa de risco o usuario esta :
abaixo do peso; normal; acima do peso; obesidade e obesidade mórbida.

### Projeto

Esse projeto recebe a altura e peso do usuario para fazer o calculo. 
Depois do calculo feito e o indice ter sido obtido é hora de descobrir
em que faixa de risco ele se encontra, se o indice esta abaixo de 20 ele
esta abaixo do peso, se estiver entre 20 e 25 esta com o peso normal, entre
de 26 a 30 com escesso de peso, se o indice estiver de 30 a 35 indica que o
usuario esta com obesidade e acima de 35 com obesidade mórbida.


# 📦 [Controle de Estoque](https://github.com/raphael-rfa/csharp/blob/main/ControleDeEstoque/ControleDeEstoque/Program.cs)

Controle de Estoque de uma fabrica.

### Projeto

O controle de estoque recebe a quantidade de produtos fabricados e vendidos   
e assim descobre quantos produtos deviam esta em estoque, também mostra  
o produto com maior estoque e o de menor estoque, e todos os produtos  
ordenas pela quantidade em estoque.

# 📚 [Biblioteca](https://github.com/raphael-rfa/Projetos-em-Csharp/blob/main/Biblioteca/Biblioteca/Program.cs)

### Projeto

O progama permite fazer o cadastro ilimitado de livros com os seguintes   
dados CODIGO, TITULO, AUTOR, AREA, ANO e EDITORA. O menu da a opção de : 

- 1 Cadastrar livros.
- 2 Imprimir todos os livros.
- 3 Pesquisar livros por nome.
- 4 Ordenar livros por Ano.
- 5 Sair.

Utilizando uma List<T> fiz uma lista generica da classe Livro assim  
não precisa setar o tamanho da lista e ela fica do tamanho que precisar.  
Para fazer a busca do livro pelo nome usei LINQ query.
