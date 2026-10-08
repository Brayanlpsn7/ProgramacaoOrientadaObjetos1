/*Como eu instancio um objeto?
1. Criar classe
** 1 Classe = 1 Arquivo
*public class NOME_DA_CLASSE {}
*
* 2. Atributos
* public TIPO NOME
* 
* 3. Defino Métodos
* public RETORNO(void) NOME() { }
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Carro
    {
        // Atributos

        public string Marca;
        public string Modelo;
        public int Ano;

        // Metodos
        // Mostrar as informções do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nMarca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

    }
}
