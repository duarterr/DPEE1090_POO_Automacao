using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Conta
    {
        public string Titular;
        private double _saldo; // Convenção de nomes: Membros privados são escritos na forma _camelCase

        // Construtor da classe
        public Conta(string titular, double saldo)
        {
            Titular = titular;
            _saldo = saldo;
        }

        // Método para efetuar um depósito
        public void Deposito (double valor)
        {
            _saldo += valor;
        }

        // Método para efetuar um saque
        public void Saque (double valor)
        {
            if (_saldo >= valor) 
            { 
                _saldo -= valor;
            }
        }

        // Getter para o valor do saldo
        public double GetSaldo()
        {
            return _saldo;
        }

        // Setter para o valor do saldo
        // Nesse caso, o uso do setter viola a regra de negócios da conta bancaria. O setter abaixo serve apenas para fins didáticos de como é a sintaxe de um setter
        public void SetSaldo(double valor)
        {
            _saldo = valor;
        }
    
        //  Método para exibir os dados na tela 
        public override string ToString() 
        {
            return Titular + ":Saldo: " + _saldo.ToString("F2");
        }
    }
}
