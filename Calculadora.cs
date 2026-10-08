using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Calculadora
    {
        // Metodo

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"Resultado: {valor}");
        }



    }
}
