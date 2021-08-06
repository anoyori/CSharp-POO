using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAmanda = new ContaCorrente();
            contaDaAmanda.titular = "Amanda";
            contaDaAmanda.agencia = 123;
            contaDaAmanda.numeroDaConta = 123321;

            ContaCorrente contaDaBruna = new ContaCorrente();
            contaDaBruna.titular = "Bruna";
            contaDaBruna.agencia = 123;
            contaDaBruna.numeroDaConta = 123321;

            Console.WriteLine(contaDaAmanda.numeroDaConta == contaDaBruna.numeroDaConta);

            contaDaAmanda.saldo = 300;
            Console.WriteLine(contaDaAmanda.saldo);
            Console.WriteLine(contaDaBruna.saldo);

            if(contaDaAmanda.saldo >= 100)
            {
                contaDaAmanda.saldo -=100;
            }
            
            Console.ReadLine();
        }
    }
}
