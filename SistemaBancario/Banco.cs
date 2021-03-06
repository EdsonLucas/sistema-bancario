﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBancario
{
    [Serializable]
    public class Banco
    {
        int NDC = 0;
        double Armazenado;
        double Emprestado;
        double Receber;
        List<ContaCorrente> ContaCorrente = new List<ContaCorrente>();
        List<ContaPoupanca> ContaPoupanca = new List<ContaPoupanca>();
        List<Cartao> Cartao = new List<Cartao>();
        List<Funcionario> Funcionario = new List<Funcionario>();

        public void AdicionaFuncionario(string Nome, int Cpf)
        {
            this.Funcionario.Add(new Funcionario(Nome, this.NDC, Cpf));
            Console.WriteLine("Funcionário cadastrado com sucesso!");
            NDC++;
        }

        public void AdicionaContaCorrente(double valor, Cliente Titular)
        {
            this.ContaCorrente.Add(new ContaCorrente(this.NDC, valor, Titular));
            Console.WriteLine("Conta Corrente criada com sucesso!");
            NDC++;
        }

        public void AdicionaContaPoupanca(double valor, Cliente Titular)
        {
            this.ContaPoupanca.Add(new ContaPoupanca(this.NDC, valor, Titular));
            Console.WriteLine("Conta Poupança criada com sucesso!");
            NDC++;
        }

        public void AdicionaContaCorrente(double valor, Cliente Titular, Cliente Titular2)
        {
            this.ContaCorrente.Add(new ContaCorrente(this.NDC, valor, Titular, Titular2));
            Console.WriteLine("Conta Corrente criada com sucesso!");
            NDC++;
        }

        public void AdicionaContaPoupanca(double valor, Cliente Titular, Cliente Titular2)
        {
            this.ContaPoupanca.Add(new ContaPoupanca(this.NDC, valor, Titular, Titular2));
            Console.WriteLine("Conta Poupança criada com sucesso!");
            NDC++;
        }

        public void RemoveConta(int procurada)
        {
            foreach(ContaCorrente conta in ContaCorrente.ToList())
            {
                if(conta.Numero == procurada)
                {
                    ContaCorrente.Remove(conta);
                    Console.WriteLine("Conta deletada com sucesso!");
                }
            }

            foreach (ContaPoupanca conta in ContaPoupanca.ToList())
            {
                if (conta.Numero == procurada)
                {
                    ContaPoupanca.Remove(conta);
                    Console.WriteLine("Conta deletada com sucesso!");
                }
            }
        }

        public void RemoveFuncionario(int procurado)
        {
            foreach (Funcionario func in Funcionario.ToList())
            {
                if (func.Codigo == procurado)
                {
                    Funcionario.Remove(func);
                    Console.WriteLine("Funcionário deletado com sucesso!");
                }
            }
        }

        public bool AdicionaTitular(Cliente Titular, ContaCorrente conta)
        {
            if(conta.TipoConta == 1)
            {
                conta.Titular2 = Titular;
                conta.TipoConta = 2;
                return true;
            }
            return false;
        }

        public bool AdicionaTitular(Cliente Titular, ContaPoupanca conta)
        {
            if (conta.TipoConta == 1)
            {
                conta.Titular2 = Titular;
                conta.TipoConta = 2;
                return true;
            }
            return false;
        }

        public void ListaContas()
        {

            Console.WriteLine("Conta Corrente:");
            foreach (ContaCorrente conta in ContaCorrente)
            {
                if(conta.TipoConta == 2)
                {
                    Console.WriteLine(conta.Numero + " - " + conta.Titular1.Nome + " / " + conta.Titular2.Nome);
                } else
                {
                    Console.WriteLine(conta.Numero + " - " + conta.Titular1.Nome);
                }

                Console.WriteLine("Saldo: " + conta.Saldo);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Conta Poupança:");
            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                if (conta.TipoConta == 2)
                {
                    Console.WriteLine(conta.Numero + " - " + conta.Titular1.Nome + " / " + conta.Titular2.Nome);
                }
                else
                {
                    Console.WriteLine(conta.Numero + " - " + conta.Titular1.Nome);
                }

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
        }

        public void ListaFuncionarios()
        {
            foreach (Funcionario func in Funcionario)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("CÓDIGO : " + func.Codigo);
                Console.WriteLine("NOME : " + func.Nome);
                Console.WriteLine("CPF: " + func.Cpf);
                Console.WriteLine("-------------------------");
            }

        }

        public void ListaCliente()
        {
            foreach (ContaCorrente conta in ContaCorrente)
            {
                if (conta.TipoConta == 1)
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular1.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular1.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular1.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular1.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular1.Data_Nascimento);
                    Console.WriteLine("-------------------------");
                } else
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular1.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular1.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular1.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular1.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular1.Data_Nascimento);
                    Console.WriteLine("-------------------------");

                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular2.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular2.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular2.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular2.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular2.Data_Nascimento);
                    Console.WriteLine("-------------------------");
                }
            }

            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                if (conta.TipoConta == 1)
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular1.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular1.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular1.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular1.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular1.Data_Nascimento);
                    Console.WriteLine("-------------------------");
                } else
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular1.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular1.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular1.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular1.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular1.Data_Nascimento);
                    Console.WriteLine("-------------------------");

                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("NOME : " + conta.Titular2.Nome);
                    Console.WriteLine("NOME SUJO? " + conta.Titular2.NomeSujo);
                    Console.WriteLine("CPF: " + conta.Titular2.Cpf);
                    Console.WriteLine("E-MAIL: " + conta.Titular2.Email);
                    Console.WriteLine("DATA DE NASCIMENTO: " + conta.Titular2.Data_Nascimento);
                    Console.WriteLine("-------------------------");
                }
            }
        }

        public ContaCorrente procuraContaCorrente(int numero)
        {
            foreach (ContaCorrente conta in ContaCorrente)
            {
                if (conta.Numero == numero)
                {
                    return conta;
                }
            }

            return null;
        }

        public ContaPoupanca procuraContaPoupanca(int numero)
        {
            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                if (conta.Numero == numero)
                {
                    return conta;
                }
            }

            return null;
        }

        public bool procuraCartao(Cliente Titular)
        {
            foreach(Cartao cartao in Cartao)
            {
                if(cartao.Titular == Titular)
                {
                    cartao.Limite = 1000;
                    return true;
                }
            }

            return false;
        }

        public Cartao procuraCartao(int numCartao)
        {
            foreach (Cartao cartao in Cartao)
            {
                if (cartao.Numero == numCartao)
                {
                    return cartao;
                }
            }

            return null;
        }

        public void VinculaCartao(int numero)
        {

            foreach(ContaCorrente conta in ContaCorrente)
            {
                if(conta.Numero == numero)
                {
                    if (conta.TipoConta == 2)
                    {
                        int read = -1;
                        while (read != 0)
                        {
                            Console.WriteLine("Qual cliente será associado ao cartão?");
                            Console.WriteLine("[1] " + conta.Titular1.Nome);
                            Console.WriteLine("[2] " + conta.Titular2.Nome);
                            Console.WriteLine("[0] Voltar");
                            read = Convert.ToInt32(Console.ReadLine());

                            switch (read)
                            {
                                case 1:
                                    if (!procuraCartao(conta.Titular1))
                                    {
                                        if (procuraCartao(conta.Titular2))
                                        {
                                            this.Cartao.Add(new Cartao(this.NDC, conta.Titular1, 1000));
                                            Console.WriteLine("Cartão " + this.NDC + " vinculado ao cliente " + conta.Titular1.Nome + " com sucesso!");
                                        }
                                        else
                                        {
                                            this.Cartao.Add(new Cartao(this.NDC, conta.Titular1, 2000));
                                            Console.WriteLine("Cartão " + this.NDC + " vinculado ao cliente " + conta.Titular1.Nome + " com sucesso!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Já existe um cartão vinculado à esse cliente.");
                                    }
                                    break;
                                case 2:
                                    if (!procuraCartao(conta.Titular2))
                                    {
                                        if (procuraCartao(conta.Titular1))
                                        {
                                            this.Cartao.Add(new Cartao(this.NDC, conta.Titular2, 1000));
                                            Console.WriteLine("Cartão " + this.NDC + " vinculado ao cliente " + conta.Titular2.Nome + " com sucesso!");
                                        } else
                                        {
                                            this.Cartao.Add(new Cartao(this.NDC, conta.Titular2, 2000));
                                            Console.WriteLine("Cartão " + this.NDC + " vinculado ao cliente " + conta.Titular2.Nome + " com sucesso!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Já existe um cartão vinculado à esse cliente.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Digite uma opção válida");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if(!procuraCartao(conta.Titular1))
                        {
                            this.Cartao.Add(new Cartao(this.NDC, conta.Titular1, 2000));
                            Console.WriteLine("Cartão " + this.NDC + " vinculado ao cliente " + conta.Titular1.Nome + " com sucesso!");
                        } else
                        {
                            Console.WriteLine("Já existe um cartão vinculado à esse cliente.");
                        }
                    }
                }
            }

        }

        public void TotalArmazenado()
        {
            Armazenado = 0;
            foreach (ContaCorrente conta in ContaCorrente)
            {
                this.Armazenado += conta.Saldo;
            }

            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                this.Armazenado += conta.Saldo;
            }

            Console.WriteLine("O total armazenado é de R$" + this.Armazenado);
        }

        public void TotalEmprestado()
        {
            Emprestado = 0;
            foreach (ContaCorrente conta in ContaCorrente)
            {
                this.Emprestado += conta.Emprestimo;
            }

            Console.WriteLine("O total emprestado é de R$" + this.Emprestado);
        }

        public void TotalReceber()
        {
            Receber = 0;
            foreach (Cartao cartao in Cartao)
            {
                this.Receber += cartao.Saldo;
            }

            foreach (ContaCorrente conta in ContaCorrente)
            {
                this.Receber += conta.Emprestimo;
            }

            Console.WriteLine("O total a receber é de R$" + this.Receber);
        }

        public void PassaMes()
        {
            foreach(ContaCorrente conta in ContaCorrente)
            {
                Random random = new Random();
                int numRandom = random.Next(2);
                int saldoRandom = random.Next(101);

                if(numRandom == 0)
                {
                    conta.Saca(saldoRandom);
                } else
                {
                    conta.Deposita(saldoRandom);
                }
            }

            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                Random random = new Random();
                int numRandom = random.Next(2);
                int saldoRandom = random.Next(101);

                if (numRandom == 0)
                {
                    conta.Saca(saldoRandom);
                }
                else
                {
                    conta.Deposita(saldoRandom);
                }
            }

            foreach (ContaCorrente conta in ContaCorrente)
            {
                Random random = new Random();
                int numRandom = random.Next(2);
                int saldoRandom = random.Next(101);

                if (numRandom == 0)
                {
                    bool emp = conta.PedeEmprestimo(saldoRandom);
                }
            }

            foreach (ContaPoupanca conta in ContaPoupanca)
            {
                conta.Saldo += conta.Saldo * conta.Rendimento;
            }

            foreach (Cartao cartao in Cartao)
            {
                Random random = new Random();
                int numRandom = random.Next(2);
                int saldoRandom = random.Next(1061);

                if (numRandom == 0)
                {
                    cartao.usaCartao(saldoRandom);
                }
            }

        }

    }
}
