
using ByteBank;

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


Cliente cliente = new Cliente();
cliente.nome = "Weslley G. da Cruz";
cliente.cpf = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numeroAgencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular: "+conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("Profissão: " + conta.titular.profissao);
Console.WriteLine("Nº Conta: " + conta.conta);
Console.WriteLine("Agência: " + conta.numeroAgencia);
Console.WriteLine("Saldo: " + conta.saldo);



