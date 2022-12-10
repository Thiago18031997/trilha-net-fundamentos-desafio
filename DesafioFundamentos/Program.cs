using System.Drawing;
using System.Text.Unicode;
using System.Text;
using System.Runtime.CompilerServices;

namespace App;
class Program
{   
    public static void MudaCor()
    {
        var corOriginal = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    public static void Menu(Estacionamento es, bool exibirMenu = true)
    {
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculo();
                    break;

                case "2":
                    Program.MudaCor();
                    es.RemoverVeiculo();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "3":
                    Program.MudaCor();
                    es.ListarVeiculos();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n Digite o preço inicial:");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Agora digite o preço por hora:");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
        // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
        // Realiza o loop do menu
        Program.Menu(es);
        Console.WriteLine("O programa se encerrou");
    }
}