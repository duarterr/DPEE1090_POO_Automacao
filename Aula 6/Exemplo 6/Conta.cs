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

        // Propriedade autodeimplementada Saldo
        // Apenas get é acessível fora da classe.
        // Alteração do valor não é permitida
        public double Saldo { get; private set; }

        // Construtor da classe
        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        // Método para efetuar um depósito
        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        // Método para efetuar um saque
        public void Saque (double valor)
        {
            if (Saldo >= valor) 
            { 
                Saldo -= valor;
            }
        }
    
        //  Método para exibir os dados na tela 
        public override string ToString() 
        {
            return Titular + ": saldo: " + Saldo.ToString("F2");
        }


    }
}
