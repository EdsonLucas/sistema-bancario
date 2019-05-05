using System;
namespace SistemaBancario
{
    public class Cartao
    {
        public int Numero;
        public Cliente Titular;
        public double Saldo;
        public DateTime Vencimento;
        public double Limite;
        public double ChequeEspecial;

        public Cartao(int Numero, Cliente Titular, double Limite)
        {
            this.Numero = Numero++;
            this.Titular = Titular;
            this.Vencimento = DateTime.Parse("04/20");
            this.ChequeEspecial = 100;
        }

        public bool pagaCartao(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

    }
}
