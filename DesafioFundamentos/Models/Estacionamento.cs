using System;
using System.Collections;
using System.Collections.Generic;
namespace App;
class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<Veiculo> veiculos = new List<Veiculo>();
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {   
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    // O (1)
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar");
        string pl = Console.ReadLine();
        veiculos.Add(new Veiculo(pl));
    }
    //O (n)
    public void RemoverVeiculo()
    {
        this.ListarVeiculos();
        Console.WriteLine("Escolha um dos veículos acima para remover!");
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine().ToLower();
        for (int i = this.veiculos.Count - 1; i >= 0; i--)
        {
            
            if (this.veiculos[i].placa == placa)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                decimal quantidadeHoras = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Removendo veículo...");
                this.veiculos.RemoveAt(i);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$: {quantidadeHoras * this.precoPorHora + this.precoInicial}");
                break;
            }else if(i == 0){
                Console.WriteLine("Veículo não encontrado! Tente novamente.");
            }
        }
       
    }                                                                                                                                           
    //O (n)
    public void ListarVeiculos()
    {
        if (this.veiculos.Count == 0)
        {
            Console.WriteLine("Sem veículos estacionados!");
        }
        foreach(Veiculo veiculo in this.veiculos)
        {
            Console.WriteLine(veiculo.placa);
        }
    }
}
