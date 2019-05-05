using System;
namespace SistemaBancario
{
    [Serializable]
    public class ContaPoupanca
    {
        public int Numero;
        public double Saldo;
        public Cliente Titular1;
        public Cliente Titular2;
        public int TipoConta;
        public double Rendimento = 0.01;

        public ContaPoupanca(int Numero, double Saldo, Cliente Titular1)
        {
            this.Saldo = Saldo;
            this.Numero = Numero++;
            this.Titular1 = Titular1;
            this.TipoConta = 1;
        }

        public ContaPoupanca(int Numero, double Saldo, Cliente Titular1, Cliente Titular2)
        {
            this.Saldo = Saldo;
            this.Numero = Numero++;
            this.Titular1 = Titular1;
            this.Titular2 = Titular2;
            this.TipoConta = 2;
        }

        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transfere(double valor, ContaPoupanca destino)
        {
            if (this.Saca(valor))
            {
                destino.Saldo += valor;
                return true;
            }
            return false;
        }

        public bool Transfere(double valor, ContaCorrente destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
