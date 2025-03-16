using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string numeroConta, string titular, double saldoInicial,
            string senha, string email, int numeroSeguranca, string endereco, double limiteSaque)
            : base(numeroConta, titular, saldoInicial)
        {
            Senha = senha;
            Email = email;
            SetNumeroSeguranca(numeroSeguranca);
            Endereco = endereco;
            LimiteSaque = limiteSaque;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
            Logger.Log($"Depositado {valor.ToString("F2")} na conta {NumeroConta}.\n" +
                $"Novo saldo: {Saldo.ToString("F2")}");
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo && valor <= LimiteSaque)
            {
                Saldo -= valor;
                Logger.Log($"Sacado {valor.ToString("F2")} na conta {NumeroConta}.\n" +
                    $"Novo saldo: {Saldo.ToString("F2")}");
            }
            else if (valor > LimiteSaque)
            {
                Logger.Log($"Saque de {valor.ToString("F2")} excede o limite de saque" +
                    $" diário de {LimiteSaque.ToString("F2")}.");
            }
            else {
                Logger.Log("Saldo insuficiente.");
            }
        }

        public void AplicarJuros()
        {
            Saldo += Saldo * TaxaJuros;
            Logger.Log($"Juros aplicados.\nNovo saldo: {Saldo.ToString("F2")}");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Número de Segurança: {GetNumeroSeguranca()}");
            Console.WriteLine($"Limite de Saque Diário: {LimiteSaque.ToString("F2")}");
        }
    }

    file class Logger
    {
        public static void Log(string mensagem)
        {
            Console.WriteLine($"[LOG]: {mensagem}");
        }
    }
}
