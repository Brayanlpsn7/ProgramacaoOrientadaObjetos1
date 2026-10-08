using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Pessoa
    {
        // Atributos

        public string NomePessoa;
        public int IdadePessoa;

        // Metodo

        public void Apresentar()
        {
            Console.WriteLine($"\nÓla, meu nome é {NomePessoa} e tenho {IdadePessoa} anos.");
        }





    }
}
