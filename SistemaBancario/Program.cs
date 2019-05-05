using System;

namespace SistemaBancario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Opcao = -1;

            Banco banco = new Banco();

            while (Opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("                    MENU DE OPÇÕES (BANCO)");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] Menu Gerente");
                Console.WriteLine("[2] Menu Funcionario");
                Console.WriteLine("[0] Sair do Sistema");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Escolha uma das opções acima: ");
                Opcao = Convert.ToInt32(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:
                        int op = -1;

                        while (op != 0)
                        {
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
                            Console.WriteLine("[0] Voltar ao Menu Principal");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.Write("Escolha uma das opções acima: ");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {
                                case 1:
                                    Cliente user = new Cliente();
                                    Console.WriteLine("Informe o nome do Cliente");
                                    user.Nome = Console.ReadLine();
                                    Console.WriteLine("Informe o CPF do Cliente");
                                    user.Cpf = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Informe a Data de Nascimento do Cliente (Ex.: Mar 03, 1993)");
                                    user.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Informe o E-mail do Cliente");
                                    user.Email = Console.ReadLine();

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
                                            Console.WriteLine("Informe a Data de Nascimento do Cliente (Ex.: Mar 03, 1993)");
                                            user2.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Informe o E-mail do Cliente");
                                            user2.Email = Console.ReadLine();

                                            banco.AdicionaContaCorrente(saldo, user, user2);
                                        }
                                        else if(verifica == 2)
                                        {
                                            banco.AdicionaContaCorrente(saldo, user);
                                        } else
                                        {
                                            Console.WriteLine("Digite uma opção válida");
                                        }
                                    }
                                    break;
                                case 2:
                                    Cliente usr = new Cliente();
                                    Console.WriteLine("Informe o nome do Cliente");
                                    usr.Nome = Console.ReadLine();
                                    Console.WriteLine("Informe o CPF do Cliente");
                                    usr.Cpf = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Informe a Data de Nascimento do Cliente (Ex.: Mar 03, 1993)");
                                    usr.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Informe o E-mail do Cliente");
                                    usr.Email = Console.ReadLine();

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
                                            Console.WriteLine("Informe a Data de Nascimento do Cliente (Ex.: Mar 03, 1993)");
                                            usr2.Data_Nascimento = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Informe o E-mail do Cliente");
                                            usr2.Email = Console.ReadLine();

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
                                case 3:
                                    Console.WriteLine("Digite o número da conta que deseja remover");
                                    int conta = int.Parse(Console.ReadLine());

                                    banco.RemoveConta(conta);
                                    break;
                                case 4:
                                    banco.ListaContas();
                                    break;
                                case 5:
                                    banco.ListaCliente();
                                    break;
                                case 6:
                                    Console.WriteLine("Digite o número da conta que deseja vincular um cartão");
                                    int numConta = int.Parse(Console.ReadLine());

                                    banco.VinculaCartao(numConta);
                                    break;
                                case 7:
                                    int tipoConta = -1;

                                    while(tipoConta != 0)
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
                                        } else if(tipoConta == 2)
                                        {
                                            banco.procuraContaPoupanca(sacaConta).Saca(valorSaque);
                                        } else
                                        {
                                            Console.WriteLine("Digite uma opção Válida");
                                        }
                                    }
                                    break;
                                case 8:
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
                                case 9:
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
                                case 10:
                                        Console.WriteLine("Digite o número da conta que deseja pedir empréstimo");
                                        int emprestimoConta = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o valor que deseja pedir emprestado");
                                        int valorEmprestimo = int.Parse(Console.ReadLine());

                                        banco.procuraContaCorrente(emprestimoConta).PedeEmprestimo(valorEmprestimo);
                                    break;
                                case 11:
                                    Console.WriteLine("Digite o número da conta");
                                    int contaPagaEmprestimo = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor que deseja pagar");
                                    int valorPagaEmprestimo = int.Parse(Console.ReadLine());

                                    banco.procuraContaCorrente(contaPagaEmprestimo).PagarEmprestimo(valorPagaEmprestimo);
                                    break;
                                case 12:
                                    Console.WriteLine("Digite o número da conta corrente");
                                    int numCorrente = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o número do cartão");
                                    int numCartao = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor que deseja pagar");
                                    int valorPagaCartao = int.Parse(Console.ReadLine());

                                    if(banco.procuraContaCorrente(numCorrente).Saca(valorPagaCartao))
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
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                        break;

                }
            }
        }
    }
}
