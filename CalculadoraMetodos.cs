using System;

namespace Calculadora
{
       
    
    public class CalculatoraMetodos
    {
        public int Adicao(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public int Divisao(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Nao pode dividir por zero");

            return a / b;
        }
    }
}


