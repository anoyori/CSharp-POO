namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private int _agencia;
        public Cliente Titular { get; set; }
        public static int  TotalDeContasCriadas { get; private set; } //Static: propriedade pertence à classe
        public int Agencia { get; set; }
        public int NumeroDaConta
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            NumeroDaConta = numero;

            TotalDeContasCriadas++;
        }
        
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
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

    