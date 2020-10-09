using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public class ContaCorrente
        {
            public Cliente Titular { get; set; }

            public static int TotalDeContasCriadas { get; private set; }// static é quando a propriedade/informação pertence a classe
            //get pode ser acessado, mais set não pq é privado

            private int _agencia;
            public int Agencia
            {
                get
                {
                    return _agencia;
                }
                set
                {
                    if (value <= 0)// para não atribuir valores negativos
                    {
                        return;
                    }

                    _agencia = value;
                }
            }
            public int Numero { get; set; }

            private double _saldo = 100;// campo do saldo que está no this.saldo
                                       //saldo é um campo inteno que só pode ser alterado em ContaCorrente, foi encapsulado
            public double Saldo// Ao ter {} e adicionar get e set a primeira letra da propriedade deve ser maíusculo 
            {
                get//obtem saldo
                {
                    return _saldo; //campo interno
                }
                set//define saldo
                {
                    if (value < 0)
                    {
                        return;
                    }

                    _saldo = value;
                }
            }// return em um metodo void, para de executar o metodo


            public ContaCorrente(int agencia, int numero)// Fazendo um construtor, para que seja obrigado a informar a agência e conta
            {
                Agencia = agencia;
                Numero = numero;

                TotalDeContasCriadas++;
            }


            public bool Sacar(double valor) //função sacar, valor é 50
            {
                if (_saldo < valor)//verifica se o saldo é menor
                {
                    return false;
                }

                _saldo -= valor;//executa se for menor que 50
                return true;
            }

            public void Depositar(double valor) //usamos void pois a função não tem retorno
            {
                _saldo += valor;
            }


            public bool Transferir(double valor, ContaCorrente contaDestino)//usamos void pois a função não tem retorno
            {
                if (_saldo < valor)
                {
                    return false;
                }

                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

    
}

