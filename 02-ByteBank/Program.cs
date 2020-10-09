using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200; //por ser informado por último prevalece este valor é nao o valor de saldo declarado na classe

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            
            Console.ReadLine();
        }
    }
}
