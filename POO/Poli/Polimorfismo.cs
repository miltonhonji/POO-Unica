using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Poli
{
    public class Polimorfismo
    {
        public void Execucao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo número: ");
            var numero2 = Convert.ToInt16(Console.ReadLine());

            var soma = Somar(numero1, numero2);
        }

        private int Somar(int numero1, int numero2)
        {
            var resultado = numero1 + numero2;

            return resultado;
        }

        public int Somar(int n1, int n2, int n3)
        {
            var resultado = 0;
            return resultado;
        }

        public int Somar(int n1, int n2, int n3, bool verifica)
        {
            var resultado = 0;
            return resultado;
        }

    }
}
