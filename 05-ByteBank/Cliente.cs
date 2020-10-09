using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    //public class Cliente
    //{
    //public string Nome { get; set; } // digito prop(propriedades) + tab 2x, altero o int e Propietery
    //public string CPF { get; set; } 
    //public string Profissao { get; set; }

    //}

    public class Cliente // Caso eu queira validar o CPF
    {
        private string _cpf;
        
        public string Nome { get; set; } //rever pq está dando erro no program em Nome CPF e Numero de Agencia
        public string CPF 
        {
            get 
            {
                return _cpf;
            }
            set
            {
                //Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        } 
        public string Profissao { get; set; }

    }
}
