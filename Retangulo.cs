using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Retangulo
    {
        // Atributos

        public double Largura, Altura;

        // Metodo

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        // Metodo

        public double CalcularPerimetro()
        {
            return (2 * (Largura + Altura));
        }


    }
}
