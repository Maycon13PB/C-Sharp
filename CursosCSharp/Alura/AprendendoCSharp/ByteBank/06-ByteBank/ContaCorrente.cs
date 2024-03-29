﻿//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public int agencia;
        public int numero;
        private double _saldo = 100;
        public Cliente Titular { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value <0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}

