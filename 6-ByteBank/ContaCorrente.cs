using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public int Agencia { get; set; }
        public int NumeroAgencia { get; set; }
        public int Numero { get; set; }


        private double _saldo = 100; // campo do saldo que está no this.saldo
        //saldo é um campo inteno que só pode ser alterado em ContaCorrente, foi encapsulado
        
        
        public double Saldo // Ao ter {} e adicionar get e set a primeira letra da propriedade deve ser maíusculo 
        {
            get //obtem saldo
            {
                return _saldo; //campo interno
            }
            set //define saldo
            {
                if (value < 0) 
                {
                    return; 
                }

                _saldo = value; 

            }
        }
        // return em um metodo void, para de executar o metodo

        public bool Sacar(double valor) //função sacar, valor é 50
        {
            if (this._saldo < valor) //verifica se o saldo é menor
            {
                return false;
            }
            else
            {
                this._saldo -= valor; //executa se for menor que 50
                return true;
            }

        }

        public void Depositar(double valor) //usamos void pois a função não tem retorno
        {
        this._saldo += valor;
        }
        public bool Transferir (double valor,ContaCorrente contaDestino) //usamos void pois a função não tem retorno
        {
            if(this._saldo < valor)
            {
                return false;
            }
            else
            {   
                this._saldo -= valor; //this verifica se há saldo
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

    
}

