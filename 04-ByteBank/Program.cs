using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando variavell do tipo ContaCorrente, chamada contaDoBruno astribuimos (=) como valor uma 
            //referencia para o obj. Para instanciar add o new w o tipo instanciado (ContaCorrente()) 
           ContaCorrente contaDoBruno = new ContaCorrente(); 
            
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            
            bool resultadodoSaque = contaDoBruno.Sacar(500); // acessando a função sacar no obj referenciado contaDoBruno, valor do argumento 50
            
            Console.WriteLine(resultadodoSaque); // imprimindo o retorno da função Sacar
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela " + contaDaGabriela.saldo);


            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela " + contaDaGabriela.saldo);

            Console.WriteLine("resultado transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela " + contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
