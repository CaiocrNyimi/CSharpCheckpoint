using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(string numeroConta, string titular, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);

        public double LimiteSaque { get; set; }
        protected double TaxaJuros { get; set; } = 0.01;
        internal string Senha { get; set; }
        protected internal string Email { get; set; }
        private int NumeroSeguranca { get; set; }
        private protected string Endereco { get; set; }

        protected int GetNumeroSeguranca()
        {
            return NumeroSeguranca;
        }

        protected void SetNumeroSeguranca(int numeroSeguranca)
        {
            NumeroSeguranca = numeroSeguranca;
        }
    }
}
