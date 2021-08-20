using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "000.000.000-00";

            //conta.titular = gabriela;
            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "000.000.000-00";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 123;
            conta.numeroDaConta = 1233455;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
