# 🗄 Repositorio de Projetos em C#

Destinado a pequenos projetos para testar a logica de programação com algoritmos nessa linguagem incrivel.

# 🧮 [Calculadora de IMC](https://github.com/raphael-rfa/csharp/blob/main/CalculoDoIMC/CalculoDoIMC/Program.cs)

A calculadora de IMC(Indice de Massa Corporal) indica em qual faixa de  
risco o usuario esta abaixo do peso; normal; acima do peso; obesidade e  
obesidade mórbida.

### Projeto

Esse projeto recebe a altura e peso do usuario para fazer o calculo. 
Depois do calculo feito e o indice ter sido obtido é hora de descobrir
em que faixa de risco ele se encontra, se o indice esta abaixo de 20 ele
esta abaixo do peso, se estiver entre 20 e 25 esta com o peso normal, entre
de 26 a 30 com escesso de peso, se o indice estiver de 30 a 35 indica que o
usuario esta com obesidade e acima de 35 com obesidade mórbida.

O projeto é simples feito apenas com o operador condicional if else e else if  
com do while para fazer o loop até o usurio colocar dizer não.

# 📦 [Controle de Estoque](https://github.com/raphael-rfa/csharp/blob/main/ControleDeEstoque/ControleDeEstoque/Program.cs)

Controle de Estoque de uma fabrica.

### Projeto

O controle de estoque recebe a quantidade de produtos fabricados e vendidos   
e assim descobre quantos produtos deviam esta em estoque, também mostra  
o produto com maior estoque e o de menor estoque, e todos os produtos  
ordenas pela quantidade em estoque.

- 1 Imprimir o produto com maior quantidade no estoque
- 2 Imprimir o produto com menor quantidade no estoque
- 3 imprimir o produto com maior e menor quantidade
- 4 Imprimir todas os produtos
 - 5 - Sair
 
Utilizando um Array de struct para armazenar os produtos e switch case para  
o menu.


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

# 📈 [Gestão de Sala de Aula](https://github.com/raphael-rfa/Projetos-em-Csharp/blob/main/GestaoDeSalaDeAula/Gest%C3%A3oDeSalaDeAula/Program.cs)

### Projeto

Gestão de Sala de aula permite o cadastro de alunos e de suas notas, faz  
o calculo da media com as notas fornecidas e rankei os alunos da maior nota  
para a menor.

- 1 Cadastrar alunos.
- 2 Rankear turma.
- 3 Sair.

O projeto utiliza List<T> da classe Aluno para armazenar os dados como  
nome, notas e media, switch case para o menu.
