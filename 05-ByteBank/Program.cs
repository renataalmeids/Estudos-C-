using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente(); //criando um obj do tipo cliente (referencia)

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela; //referencia apontando para nada, pois conta.titular ainda não existe
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878-20";
            //conta.titular.profissao = "Desenvolvedora C#";
               

            conta.saldo = 500;
            conta.numeroAgencia = 563;
            conta.numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em cont. titular é NULL"); //comentando tudo o que vem após conta.titular
            }
            //Console.WriteLine(gabriela.nome);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}
