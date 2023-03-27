﻿using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return numeroAgencia;
            }

            private set
            {

                if (value > 0)
                {
                    this.numeroAgencia = value;
                }

            }

        }

        // private string conta;
        public string Conta { get; set; }

        private double saldo = 100;
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {

            saldo += valor;

        }

        public bool Sacar(double valor)
        {

            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {

            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }

        }

        public void SetSaldo(double valor)
        {

            if(valor < 0)
            {

                return;

            } 
            else
            {

                this.saldo = valor;

            }

        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {

            this.numeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            TotalDeContasCriadas++;

        }

    }
}
