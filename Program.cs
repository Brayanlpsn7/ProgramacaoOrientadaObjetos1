/*
 *=== Classes
 * Modelo ou "molde" para criar objetos
 * 
 * definição, onde ele explica. (O que é?)
 * 
 *=== Objetos
 * Instancia de uma classe (instanciar - criar um objeto)
 * Materializar
 * 
 * HB20, Corolla 
 * Pessoa, cpf, email 
 *
 *=== Atributos
 * Caracteristicas do objeto. exemplo:
 * Sabor, cor, e tamanho do bolo
 * 
 * ===Metodos
 * Ações que o objeto pode realizar.
 * exemplo: Assar, cortar e docorar bolo
 * */

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


// Variavel
// Tipo NOME
using ProgramacaoOrientadaObjetos;  // Ctrl + .(ponto) se der erro

internal class Program
{
    private static void Main(string[] args)
    {
        //Instanciar
        Carro carroDoBrayan = new Carro();

        carroDoBrayan.Marca = "Hyundai";
        carroDoBrayan.Modelo = "HB20s";
        carroDoBrayan.Ano = 2024;

        carroDoBrayan.ExibirInformacoes();

        //Instanciem um novo objeto

        Carro carroDoBrayan2 = new Carro();

        carroDoBrayan2.Marca = "Toyota";
        carroDoBrayan2.Modelo = "Corolla XEi";
        carroDoBrayan2.Ano = 2019;

        carroDoBrayan2.ExibirInformacoes();







        // Criar Classe Pedido
        // NomeDoCliente, item, Quantidade, preco

        Pedido pedido01 = new Pedido();
        Console.WriteLine("\nDigite o nome do cliente: ");
        pedido01.NomeCliente = Console.ReadLine();

        Console.WriteLine("\nDigite o item: ");
        pedido01.Item = Console.ReadLine();

        Console.WriteLine("\nDigite a quantidade: ");
        pedido01.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o preço: ");
        pedido01.Preco = double.Parse(Console.ReadLine());

        pedido01.ExibirinfPedidos();


        // === Exercicios ===

        //=== 1. Pessoa
        Console.WriteLine("\n === Ex.1 Pessoa");
        Pessoa pessoa01 = new Pessoa();

        pessoa01.NomePessoa = "Ana";

        pessoa01.IdadePessoa = 25;

        pessoa01.Apresentar();

        Pessoa pessoa02 = new Pessoa();

        pessoa02.NomePessoa = "Bruno";

        pessoa02.IdadePessoa = 31;

        pessoa02.Apresentar();




        //=== 2. Retangulo
        Console.WriteLine("\n === Ex.2 Retangulo");

        Retangulo retangulo01 = new Retangulo();

        retangulo01.Largura = 5;
        retangulo01.Altura = 3;

        Console.WriteLine($"Área: {retangulo01.CalcularArea()}");
        Console.WriteLine($"Perimetro: {retangulo01.CalcularPerimetro()}");

        
        
        
        //=== 3. Lâmpada 
        Console.WriteLine("\n === Ex.3 Lâmpada");

        Lampada lampada01 = new Lampada();

        lampada01.ExibirEstado();
        lampada01.Ligar();
        lampada01.ExibirEstado();
        lampada01.Alternar();
        lampada01.ExibirEstado();



        //=== 4. Conta bancária
        Console.WriteLine("\n === Ex.4 Conta bancária");

















        // === Lista 2
        Console.WriteLine("\n Lista 2");

        // === Ex.1 Saudação
        Console.WriteLine(" === Ex.1 Saudação\n");

        Pessoa02 ana = new Pessoa02();
        ana.Nome = "Ana";

        ana.Cumprimentar();
        ana.CumprimentarAlguem("Bruno");

        string frase = ana.ObterApresentacao();
        Console.WriteLine(frase);




        // === 2. Calculadora
        Console.WriteLine("=== Ex.2 Calculadora");

        // Alterei
    }
}