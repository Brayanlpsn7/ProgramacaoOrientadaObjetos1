using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    public class Pedido
    {
        // Atributos - caracteristicas
        public string NomeCliente;
        public string Item;
        public int Quantidade;
        public double Preco;

        // Metodos - ações
        public void ExibirinfPedidos()
        {
            Console.WriteLine($"\nNome: {NomeCliente}");
            Console.WriteLine($"Item: {Item}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Preço: {Preco * Quantidade:c}");
        }
    }
}
