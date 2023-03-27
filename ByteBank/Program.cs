using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaDoWeslley = new ContaCorrente();
//contaDoWeslley.titular = "Weslley G. da Cruz";
//contaDoWeslley.numeroAgencia = 15;
//contaDoWeslley.conta = "1010-X";
//contaDoWeslley.saldo = 100;

//ContaCorrente contaDoWeslley2 = new ContaCorrente();
//contaDoWeslley2.titular = "Weslley G. da Cruz";
//contaDoWeslley2.numeroAgencia = 15;
//contaDoWeslley2.conta = "1010-X";
//contaDoWeslley2.saldo = 100;

//contaDoWeslley = contaDoWeslley2;

//Console.WriteLine(contaDoWeslley==contaDoWeslley2);

//Console.WriteLine("Saldo da Conta do Weslley: R$ "+contaDoWeslley.saldo);

////contaDoWeslley.Depositar(100);
////Console.WriteLine("Deposito efetuado no valor de: R$ 100");

////Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);

////if (contaDoWeslley.Sacar(300))
////{
////    Console.WriteLine("Saque efetuado no valor de: R$ 300");
////}
////else
////{
////    Console.WriteLine("Saldo insuficiente para sacar R$ 300");
////}

////Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da Conta do Maria: R$ " + contaDoWeslley.saldo);

//contaDoWeslley.Transferir(50, contaDaMaria);
//Console.WriteLine("Transferência de R$50 realizada para conta da Maria.");

//Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);
//Console.WriteLine("Saldo da Conta do Maria: R$ " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);


//Cliente cliente = new Cliente();
//cliente.nome = "Weslley G. da Cruz";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular: "+conta.titular.nome);
//Console.WriteLine("CPF: " + conta.titular.cpf);
//Console.WriteLine("Profissão: " + conta.titular.profissao);
//Console.WriteLine("Nº Conta: " + conta.conta);
//Console.WriteLine("Agência: " + conta.numeroAgencia);
//Console.WriteLine("Saldo: " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.NumeroAgencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);

ContaCorrente conta5 = new ContaCorrente(283,"1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284,"9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(284, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
