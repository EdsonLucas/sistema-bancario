using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SistemaBancario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Opcao = "-1";

            Banco banco = new Banco();

            //Carrega de arquivo
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    banco = (Banco)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Deu ruim");
            }

            while (Opcao != "0")
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("                    MENU DE OPÇÕES (BANCO)");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] Menu Gerente");
                Console.WriteLine("[2] Menu Funcionario");
                Console.WriteLine("[3] Passagem de Tempo (1 mês)");
                Console.WriteLine("[0] Sair do Sistema");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Escolha uma das opções acima: ");
                Opcao = Console.ReadLine();
                Console.WriteLine("\n");

                switch (Opcao)
                {
                    case "1":

                        Gerente adm = new Gerente();

                        Console.WriteLine("Digite o código de gerente");
                        int cod = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a senha de gerente");
                        int pin = int.Parse(Console.ReadLine());

                        if (cod != adm.Codigo)
                        {
                            Console.WriteLine("Código incorreto");
                        }
                        else if (pin != adm.Senha)
                        {
                            Console.WriteLine("Senha incorreta");
                        }
                        else
                        {
                            string op = "-1";

                            while (op != "0")
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.WriteLine("                        MENU GERENTE");
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.WriteLine("[1] Adicionar Conta Corrente");
                                Console.WriteLine("[2] Adicionar Conta Poupança");
                                Console.WriteLine("[3] Deletar Conta");
                                Console.WriteLine("[4] Listar Contas");
                                Console.WriteLine("[5] Listar Clientes");
                                Console.WriteLine("[6] Vincular Cartão à Cliente");
                                Console.WriteLine("[7] Sacar de uma Conta");
                                Console.WriteLine("[8] Depositar em uma Conta");
                                Console.WriteLine("[9] Transferir para uma Conta");
                                Console.WriteLine("[10] Pedir Empréstimo");
                                Console.WriteLine("[11] Pagar Empréstimo");
                                Console.WriteLine("[12] Pagar Cartão");
                                Console.WriteLine("[13] Vincular Dependente à uma Conta");
                                Console.WriteLine("[14] Cadastrar Funcionário");
                                Console.WriteLine("[15] Deletar Funcionário");
                                Console.WriteLine("[16] Listar Funcionários");
                                Console.WriteLine("[17] Ver Total Armazenado");
                                Console.WriteLine("[18] Ver Total Emprestado");
                                Console.WriteLine("[19] Ver Total a Receber");
                                Console.WriteLine("[0] Voltar ao Menu Principal");
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.Write("Escolha uma das opções acima: ");
                                op = Console.ReadLine();
                                Console.WriteLine("\n");

                                switch (op)
                                {
                                    case "1":
                                        Cliente user = new Cliente();
                                        Console.WriteLine("Informe o nome do Cliente");
                                        user.Nome = Console.ReadLine();
                                        Console.WriteLine("Informe o CPF do Cliente");
                                        user.Cpf = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Informe a Data de Nascimento do Cliente");
                                        user.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Informe o E-mail do Cliente");
                                        user.Email = Console.ReadLine();
                                        Random Random = new Random();
                                        if(Random.Next(2) == 1)
                                        {
                                            user.NomeSujo = true;
                                        }
                                        else
                                        {
                                            user.NomeSujo = false;
                                        }

                                        Console.WriteLine("Qual será o valor do saldo?");
                                        double saldo = double.Parse(Console.ReadLine());

                                        int verifica = -1;

                                        while (verifica != 1 && verifica != 2)
                                        {
                                            Console.WriteLine("Deseja adicionar um dependente?");
                                            Console.WriteLine("[1] Sim");
                                            Console.WriteLine("[2] Não");
                                            verifica = int.Parse(Console.ReadLine());

                                            if (verifica == 1)
                                            {
                                                Cliente user2 = new Cliente();
                                                Console.WriteLine("Informe o nome do Cliente");
                                                user2.Nome = Console.ReadLine();
                                                Console.WriteLine("Informe o CPF do Cliente");
                                                user2.Cpf = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Informe a Data de Nascimento do Cliente");
                                                user2.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                                Console.WriteLine("Informe o E-mail do Cliente");
                                                user2.Email = Console.ReadLine();
                                                Random Random1 = new Random();
                                                if (Random1.Next(2) == 1)
                                                {
                                                    user2.NomeSujo = true;
                                                }
                                                else
                                                {
                                                    user2.NomeSujo = false;
                                                }


                                                banco.AdicionaContaCorrente(saldo, user, user2);
                                            }
                                            else if (verifica == 2)
                                            {
                                                banco.AdicionaContaCorrente(saldo, user);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção válida");
                                            }
                                        }
                                        break;
                                    case "2":
                                        Cliente usr = new Cliente();
                                        Console.WriteLine("Informe o nome do Cliente");
                                        usr.Nome = Console.ReadLine();
                                        Console.WriteLine("Informe o CPF do Cliente");
                                        usr.Cpf = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Informe a Data de Nascimento do Cliente");
                                        usr.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Informe o E-mail do Cliente");
                                        usr.Email = Console.ReadLine();
                                        Random Random2 = new Random();
                                        if (Random2.Next(2) == 1)
                                        {
                                            usr.NomeSujo = true;
                                        }
                                        else
                                        {
                                            usr.NomeSujo = false;
                                        }

                                        Console.WriteLine("Qual será o valor do saldo?");
                                        double saldo2 = double.Parse(Console.ReadLine());

                                        int verifica2 = -1;

                                        while (verifica2 != 1 && verifica2 != 2)
                                        {
                                            Console.WriteLine("Deseja adicionar um dependente?");
                                            Console.WriteLine("[1] Sim");
                                            Console.WriteLine("[2] Não");
                                            verifica2 = int.Parse(Console.ReadLine());

                                            if (verifica2 == 1)
                                            {
                                                Cliente usr2 = new Cliente();
                                                Console.WriteLine("Informe o nome do Cliente");
                                                usr2.Nome = Console.ReadLine();
                                                Console.WriteLine("Informe o CPF do Cliente");
                                                usr2.Cpf = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Informe a Data de Nascimento do Cliente");
                                                usr2.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                                Console.WriteLine("Informe o E-mail do Cliente");
                                                usr2.Email = Console.ReadLine();
                                                Random Random3 = new Random();
                                                if (Random3.Next(2) == 1)
                                                {
                                                    usr2.NomeSujo = true;
                                                }
                                                else
                                                {
                                                    usr2.NomeSujo = false;
                                                }

                                                banco.AdicionaContaPoupanca(saldo2, usr, usr2);
                                            }
                                            else if (verifica2 == 2)
                                            {
                                                banco.AdicionaContaPoupanca(saldo2, usr);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção válida");
                                            }
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("Digite o número da conta que deseja remover");
                                        int conta = int.Parse(Console.ReadLine());

                                        banco.RemoveConta(conta);
                                        break;
                                    case "4":
                                        banco.ListaContas();
                                        break;
                                    case "5":
                                        banco.ListaCliente();
                                        break;
                                    case "6":
                                        Console.WriteLine("Digite o número da conta que deseja vincular um cartão");
                                        int numConta = int.Parse(Console.ReadLine());

                                        banco.VinculaCartao(numConta);
                                        break;
                                    case "7":
                                        int tipoConta = -1;

                                        while (tipoConta != 1 && tipoConta != 2)
                                        {
                                            Console.WriteLine("Deseja sacar de qual tipo de conta?");
                                            Console.WriteLine("[1] Conta Corrente");
                                            Console.WriteLine("[2] Conta Poupança");
                                            tipoConta = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o número da conta que deseja sacar");
                                            int sacaConta = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o valor que deseja sacar");
                                            int valorSaque = int.Parse(Console.ReadLine());

                                            if (tipoConta == 1)
                                            {
                                                banco.procuraContaCorrente(sacaConta).Saca(valorSaque);
                                            }
                                            else if (tipoConta == 2)
                                            {
                                                banco.procuraContaPoupanca(sacaConta).Saca(valorSaque);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção Válida");
                                            }
                                        }
                                        break;
                                    case "8":
                                        int tipoConta2 = -1;

                                        while (tipoConta2 != 1 && tipoConta2 != 2)
                                        {
                                            Console.WriteLine("Deseja depositar em qual tipo de conta?");
                                            Console.WriteLine("[1] Conta Corrente");
                                            Console.WriteLine("[2] Conta Poupança");
                                            tipoConta2 = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o número da conta que deseja depositar");
                                            int depositaConta = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o valor que deseja depositar");
                                            int valorDeposito = int.Parse(Console.ReadLine());

                                            if (tipoConta2 == 1)
                                            {
                                                banco.procuraContaCorrente(depositaConta).Deposita(valorDeposito);
                                            }
                                            else if (tipoConta2 == 2)
                                            {
                                                banco.procuraContaPoupanca(depositaConta).Deposita(valorDeposito);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção Válida");
                                            }
                                        }
                                        break;
                                    case "9":
                                        int tipoConta3 = -1;

                                        while (tipoConta3 != 1 && tipoConta3 != 2)
                                        {
                                            Console.WriteLine("Deseja transferir de qual tipo de conta?");
                                            Console.WriteLine("[1] Conta Corrente");
                                            Console.WriteLine("[2] Conta Poupança");
                                            tipoConta3 = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o número da conta origem");
                                            int origemConta = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o número da conta destino");
                                            int destinoConta = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Digite o valor que deseja transferir");
                                            int valorTransferencia = int.Parse(Console.ReadLine());

                                            if (tipoConta3 == 1)
                                            {
                                                banco.procuraContaCorrente(origemConta).Transfere(valorTransferencia, banco.procuraContaCorrente(destinoConta));
                                            }
                                            else if (tipoConta3 == 2)
                                            {
                                                banco.procuraContaPoupanca(origemConta).Transfere(valorTransferencia, banco.procuraContaCorrente(destinoConta));
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção Válida");
                                            }
                                        }
                                        break;
                                    case "10":
                                        Console.WriteLine("Digite o número da conta que deseja pedir empréstimo");
                                        int emprestimoConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja pedir emprestado");
                                        int valorEmprestimo = int.Parse(Console.ReadLine());

                                        banco.procuraContaCorrente(emprestimoConta).PedeEmprestimo(valorEmprestimo);
                                        break;
                                    case "11":
                                        Console.WriteLine("Digite o número da conta");
                                        int contaPagaEmprestimo = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja pagar");
                                        int valorPagaEmprestimo = int.Parse(Console.ReadLine());

                                        banco.procuraContaCorrente(contaPagaEmprestimo).PagarEmprestimo(valorPagaEmprestimo);
                                        break;
                                    case "12":
                                        Console.WriteLine("Digite o número da conta corrente");
                                        int numCorrente = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o número do cartão");
                                        int numCartao = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja pagar");
                                        double valorPagaCartao = double.Parse(Console.ReadLine());


                                        if (banco.procuraCartao(numCartao).Saldo > 0)
                                        {
                                            if (valorPagaCartao > banco.procuraCartao(numCartao).Saldo)
                                            {
                                                valorPagaCartao -= banco.procuraCartao(numCartao).Saldo;
                                            }

                                            if (banco.procuraContaCorrente(numCorrente).Saca(valorPagaCartao))
                                            {
                                                banco.procuraCartao(numCartao).pagaCartao(valorPagaCartao);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Você não tem nenhum valor a ser pago");
                                        }
                                        break;
                                    case "13":
                                        int tipoConta5 = -1;

                                        while (tipoConta5 != 1 && tipoConta5 != 2)
                                        {
                                            Console.WriteLine("Digite o número da conta");
                                            int numConta2 = int.Parse(Console.ReadLine());

                                            Cliente user3 = new Cliente();
                                            Console.WriteLine("Informe o nome do Cliente");
                                            user3.Nome = Console.ReadLine();
                                            Console.WriteLine("Informe o CPF do Cliente");
                                            user3.Cpf = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Informe a Data de Nascimento do Cliente");
                                            user3.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Informe o E-mail do Cliente");
                                            user3.Email = Console.ReadLine();
                                            Random Random4 = new Random();
                                            if (Random4.Next(2) == 1)
                                            {
                                                user3.NomeSujo = true;
                                            }
                                            else
                                            {
                                                user3.NomeSujo = false;
                                            }

                                            Console.WriteLine("Deseja vincular dependente a qual tipo de conta?");
                                            Console.WriteLine("[1] Conta Corrente");
                                            Console.WriteLine("[2] Conta Poupança");
                                            tipoConta5 = int.Parse(Console.ReadLine());

                                            if (tipoConta5 == 1)
                                            {
                                                banco.AdicionaTitular(user3, banco.procuraContaCorrente(numConta2));
                                            }
                                            else if (tipoConta5 == 2)
                                            {
                                                banco.AdicionaTitular(user3, banco.procuraContaPoupanca(numConta2));
                                            }
                                            else
                                            {
                                                Console.WriteLine("Digite uma opção Válida");
                                            }
                                        }
                                        break;
                                    case "14":
                                        Console.WriteLine("Informe o nome do funcionário");
                                        string nomeFunc = Console.ReadLine();
                                        Console.WriteLine("Informe o Cpf do funcionário");
                                        int cpfFunc = int.Parse(Console.ReadLine());

                                        banco.AdicionaFuncionario(nomeFunc, cpfFunc);
                                        break;
                                    case "15":
                                        Console.WriteLine("Digite o código do funcionário que deseja remover");
                                        int func = int.Parse(Console.ReadLine());

                                        banco.RemoveFuncionario(func);
                                        break;
                                    case "16":
                                        banco.ListaFuncionarios();
                                        break;
                                    case "17":
                                        banco.TotalArmazenado();
                                        break;
                                    case "18":
                                        banco.TotalEmprestado();
                                        break;
                                    case "19":
                                        banco.TotalReceber();
                                        break;
                                    default:
                                        Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                                        break;
                                }
                            }
                        }
                        break;
                    case "2":

                        string op2 = "-1";

                        while (op2 != "0")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine("                        MENU FUNCIONÁRIO");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine("[1] Listar Contas");
                            Console.WriteLine("[2] Listar Clientes");
                            Console.WriteLine("[3] Vincular Cartão à Cliente");
                            Console.WriteLine("[4] Sacar de uma Conta");
                            Console.WriteLine("[5] Depositar em uma Conta");
                            Console.WriteLine("[6] Transferir para uma Conta");
                            Console.WriteLine("[7] Pedir Empréstimo");
                            Console.WriteLine("[8] Pagar Empréstimo");
                            Console.WriteLine("[9] Pagar Cartão");
                            Console.WriteLine("[0] Voltar ao Menu Principal");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.Write("Escolha uma das opções acima: ");
                            op2 = Console.ReadLine();
                            Console.WriteLine("\n");

                            switch (op2)
                            {
                                case "1":
                                    banco.ListaContas();
                                    break;
                                case "2":
                                    banco.ListaCliente();
                                    break;
                                case "3":
                                    Console.WriteLine("Digite o número da conta que deseja vincular um cartão");
                                    int numConta = int.Parse(Console.ReadLine());

                                    banco.VinculaCartao(numConta);
                                    break;
                                case "4":
                                    int tipoConta = -1;

                                    while (tipoConta != 0)
                                    {
                                        Console.WriteLine("Deseja sacar de qual tipo de conta?");
                                        Console.WriteLine("[1] Conta Corrente");
                                        Console.WriteLine("[2] Conta Poupança");
                                        tipoConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o número da conta que deseja sacar");
                                        int sacaConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja sacar");
                                        int valorSaque = int.Parse(Console.ReadLine());

                                        if (tipoConta == 1)
                                        {
                                            banco.procuraContaCorrente(sacaConta).Saca(valorSaque);
                                        }
                                        else if (tipoConta == 2)
                                        {
                                            banco.procuraContaPoupanca(sacaConta).Saca(valorSaque);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Digite uma opção Válida");
                                        }
                                    }
                                    break;
                                case "5":
                                    int tipoConta2 = -1;

                                    while (tipoConta2 != 0)
                                    {
                                        Console.WriteLine("Deseja depositar em qual tipo de conta?");
                                        Console.WriteLine("[1] Conta Corrente");
                                        Console.WriteLine("[2] Conta Poupança");
                                        tipoConta2 = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o número da conta que deseja depositar");
                                        int depositaConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja depositar");
                                        int valorDeposito = int.Parse(Console.ReadLine());

                                        if (tipoConta2 == 1)
                                        {
                                            banco.procuraContaCorrente(depositaConta).Deposita(valorDeposito);
                                        }
                                        else if (tipoConta2 == 2)
                                        {
                                            banco.procuraContaPoupanca(depositaConta).Deposita(valorDeposito);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Digite uma opção Válida");
                                        }
                                    }
                                    break;
                                case "6":
                                    int tipoConta3 = -1;

                                    while (tipoConta3 != 0)
                                    {
                                        Console.WriteLine("Deseja transferir de qual tipo de conta?");
                                        Console.WriteLine("[1] Conta Corrente");
                                        Console.WriteLine("[2] Conta Poupança");
                                        tipoConta3 = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o número da conta origem");
                                        int origemConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o número da conta destino");
                                        int destinoConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja transferir");
                                        int valorTransferencia = int.Parse(Console.ReadLine());

                                        if (tipoConta3 == 1)
                                        {
                                            banco.procuraContaCorrente(origemConta).Transfere(valorTransferencia, banco.procuraContaCorrente(destinoConta));
                                        }
                                        else if (tipoConta3 == 2)
                                        {
                                            banco.procuraContaPoupanca(origemConta).Transfere(valorTransferencia, banco.procuraContaCorrente(destinoConta));
                                        }
                                        else
                                        {
                                            Console.WriteLine("Digite uma opção Válida");
                                        }
                                    }
                                    break;
                                case "7":
                                    Console.WriteLine("Digite o número da conta que deseja pedir empréstimo");
                                    int emprestimoConta = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor que deseja pedir emprestado");
                                    int valorEmprestimo = int.Parse(Console.ReadLine());

                                    banco.procuraContaCorrente(emprestimoConta).PedeEmprestimo(valorEmprestimo);
                                    break;
                                case "8":
                                    Console.WriteLine("Digite o número da conta");
                                    int contaPagaEmprestimo = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor que deseja pagar");
                                    int valorPagaEmprestimo = int.Parse(Console.ReadLine());

                                    banco.procuraContaCorrente(contaPagaEmprestimo).PagarEmprestimo(valorPagaEmprestimo);
                                    break;
                                case "9":
                                    Console.WriteLine("Digite o número da conta corrente");
                                    int numCorrente = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o número do cartão");
                                    int numCartao = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor que deseja pagar");
                                    int valorPagaCartao = int.Parse(Console.ReadLine());

                                    if (banco.procuraContaCorrente(numCorrente).Saca(valorPagaCartao))
                                    {
                                        banco.procuraCartao(numCartao).pagaCartao(valorPagaCartao);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                                    break;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("A few weeks later...");
                        banco.PassaMes();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                        break;
                }
            }


            //Salva em arquivo
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, banco);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Deu ruim");
            }
        }
    }
}
