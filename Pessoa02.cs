using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Pessoa02
    {
        // Atributo

        public string Nome;

        // Metodo

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}!");
        }

        public void CumprimentarAlguem( string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa}! Eu sou {Nome}.");
        }

        public string ObterApresentacao()
        {
            return $"Meu nome é {Nome}. ";
        }
    }
}
