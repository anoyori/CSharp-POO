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
            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "João";
            Console.WriteLine(contaDoJoao.saldo);

            bool resultadoSaque = contaDoJoao.Sacar(500);
            Console.WriteLine(contaDoJoao.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoJoao.Depositar(500);
            Console.WriteLine(contaDoJoao.saldo);

            ContaCorrente contaDaAmanda = new ContaCorrente();
            contaDaAmanda.titular = "Amanda";

            contaDoJoao.Transferir(200, contaDaAmanda);
            Console.WriteLine("Saldo da Conta do João é R$ " + contaDoJoao.saldo);
            Console.WriteLine("Saldo da Conta do Amanda é R$ " + contaDaAmanda.saldo);

            Console.ReadLine();
        }
    }
}
