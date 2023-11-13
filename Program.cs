using System;

namespace Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculatoraMetodos calculatora = new CalculatoraMetodos();

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ExecuteOperacao(calculatora.Adicao, "adição");
                    break;
                case 2:
                    ExecuteOperacao(calculatora.Subtracao, "subtração");
                    break;
                case 3:
                    ExecuteOperacao(calculatora.Multiplicacao, "multiplicação");
                    break;
                case 4:
                    ExecuteOperacao(calculatora.Divisao, "divisão");
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();
        }
                
        private static void ExecuteOperacao(Func<int, int, int> operacao, string nomeOperacao)
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = operacao(n1, n2);

            Console.WriteLine($"Resultado da {nomeOperacao}: {resultado}");
        }
    }
}
