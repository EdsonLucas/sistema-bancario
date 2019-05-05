using System;
namespace SistemaBancario
{
    [Serializable]
    public class ContaCorrente
    {
        public int Numero;
        public double Saldo;
        public Cliente Titular1;
        public Cliente Titular2;
        public int TipoConta;
        public double Emprestimo;
        double TaxaJuros = 0.1;
        double TaxaMovimentacao = 0.01;

        public ContaCorrente(int Numero, double Saldo, Cliente Titular1)
        {
            this.Saldo = Saldo;
            this.Numero = Numero++;
            this.Titular1 = Titular1;
            this.TipoConta = 1;
        }

        public ContaCorrente(int Numero, double Saldo, Cliente Titular1, Cliente Titular2)
        {
            this.Saldo = Saldo;
            this.Numero = Numero++;
            this.Titular1 = Titular1;
            this.Titular2 = Titular2;
            this.TipoConta = 2;
        }

        public bool Saca(double valor)
        {
            if(this.Saldo >= valor)
            {
                valor -= valor * TaxaMovimentacao;
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            valor -= valor * TaxaMovimentacao;
            this.Saldo += valor;
        }

        public bool Transfere(double valor, ContaCorrente destino)
        {
            if (this.Saca(valor))
            {
                valor -= valor * TaxaMovimentacao;
                destino.Saldo += valor;
                return true;
            }
            return false;
        }

        public bool Transfere(double valor, ContaPoupanca destino)
        {
            if (this.Saca(valor + valor * TaxaMovimentacao))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }

        public bool PedeEmprestimo(double valor)
        {
            if(this.Titular1.NomeSujo)
            {
                return false;
            }
            if (this.TipoConta == 2)
            {
                if (this.Titular2.NomeSujo)
                {
                    return false;
                }
            }
            this.Emprestimo += valor;
            this.Saldo += valor;
            return true;

        }

        public bool PagarEmprestimo(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Emprestimo -= valor;
                valor += valor * TaxaJuros;
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
