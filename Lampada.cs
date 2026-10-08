using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Lampada
    {
        // Atributo

       public bool Ligada; // começa valendo false

        // Metodo

        public void Ligar()
        {
            Ligada = true;
        }

        public void Desligar()
        {
            Ligada = false;
        }

        public void Alternar() // Inves do if/else pss usar !Ligada que inverte o valor do bool
        {
            if (Ligada == true)
            {
                Ligada = false;
            }
            else
            {
                Ligada = true;
            }
        }

        public void ExibirEstado()
        {
            if (Ligada == true)
            {
                Console.WriteLine("A lâmpada está ligada.");
            }
            else
            {
                Console.WriteLine("A lâmpada está desligada.");
            }

        }
        
    }
}
