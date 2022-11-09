using System;
namespace CalculoDoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            Console.WriteLine("Esse programa verifica o seu IMC(Indice de Massa Corporal) mas para isso preciso do seu peso e sua altura primeiro coloque sua altura em metros");

            do
            {
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Agora coloque o seu peso");
                double peso = double.Parse(Console.ReadLine());
                double imc = peso / Math.Pow(altura, 2);

                if (imc < 20)
                {
                    Console.WriteLine($"O seu imc é de {(int)imc} e indica que você esta abaixo do peso.");
                    Console.ReadLine();
                }
                else if (imc >= 20 && imc <= 25)
                {
                    Console.WriteLine($"O seu imc é de {(int)imc} que é considerado normal.");
                    Console.ReadLine();
                }
                else if (imc > 25 && imc <= 30)
                {
                    Console.WriteLine($"O seu IMC é de {(int)imc} indicando que você esta com excesso de peso.");
                    Console.ReadLine();
                }
                else if (imc > 30 && imc <= 35)
                {
                    Console.WriteLine($"O seu IMC é de {(int)imc} indicando obesidade.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"O seu IMC é de {(int)imc} indicando obesidade mórbida.");
                    Console.ReadLine();
                }
                Console.WriteLine("Deseja realizar nova consulta sim/nao");
                resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    Console.WriteLine("Digite a sua altura");
                }
            } while (resposta == "sim");
            Console.WriteLine("Raphael-rfa a sua disposição");
            Console.ReadLine();
        }
    }
}
