using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int numeroAgencia;
        public int numero;
        public double saldo = 100; 

        public bool Sacar(double valor) //função sacar, valor é 50
        {
            if (this.saldo < valor) //verifica se o saldo é menor
            {
                return false;
            }
            else
            {
                this.saldo -= valor; //executa se for menor que 50
                return true;
            }

        }

        public void Depositar(double valor) //usamos void pois a função não tem retorno
        {
        this.saldo += valor;
        }
        //informamos retorno boolena e informamos a função transferir (argumento valor, argumento classe informamos "recebedor"
        public bool Transferir (double valor,ContaCorrente contaDestino) //usamos void pois a função não tem retorno
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {   
                this.saldo -= valor; //this verifica se há saldo (-= subtrai e atribui novo valor)
                contaDestino.Depositar(valor);//mudamos o saldo 
                return true;
            }
        }
    }

    
}

