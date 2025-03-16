using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

class Program
{
    static void Main(string[] args)
    {
        ContaPoupanca conta = new ContaPoupanca("12345", "Roberto Carlos", 10000.00,
            "carlosroberto", "robertocarlos@gmail.com", 1234, "Av. Paulista, 1106", 8000.00);

        Console.WriteLine("Bem-vindo ao Banco FIAP!");
        Console.WriteLine($"Conta: {conta.NumeroConta}, Titular: {conta.Titular}, Saldo: {conta.Saldo.ToString("F2")}");

        while (true)
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Aplicar Juros");
            Console.WriteLine("4. Mostrar Informações da Conta");
            Console.WriteLine("5. Sair");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite o valor para depositar: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case "2":
                    Console.Write("Digite o valor para sacar: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case "3":
                    conta.AplicarJuros();
                    break;
                case "4":
                    conta.MostrarInformacoes();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}