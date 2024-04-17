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

        // Propriedade Saldo
        public double Saldo
        {
            // Getter da propriedade
            get 
            { 
                return _saldo; 
            }

            // Setter da propriedade
            set
            {
                if (value >= 0) 
                    _saldo =  value;
            }
        }
    
        //  Método para exibir os dados na tela 
        public override string ToString() 
        {
            return Titular + ": _saldo: " + _saldo.ToString("F2");
        }


    }
}
