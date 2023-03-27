
using ByteBank;

ContaCorrente contaDoWeslley = new ContaCorrente();
contaDoWeslley.titular = "Weslley G. da Cruz";
contaDoWeslley.numeroAgencia = 15;
contaDoWeslley.conta = "1010-X";
contaDoWeslley.saldo = 100;

Console.WriteLine("Saldo da Conta do Weslley: R$ "+contaDoWeslley.saldo);

//contaDoWeslley.Depositar(100);
//Console.WriteLine("Deposito efetuado no valor de: R$ 100");

//Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);

//if (contaDoWeslley.Sacar(300))
//{
//    Console.WriteLine("Saque efetuado no valor de: R$ 300");
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para sacar R$ 300");
//}

//Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numeroAgencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da Conta do Maria: R$ " + contaDoWeslley.saldo);

contaDoWeslley.Transferir(50, contaDaMaria);
Console.WriteLine("Transferência de R$50 realizada para conta da Maria.");

Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);
Console.WriteLine("Saldo da Conta do Maria: R$ " + contaDaMaria.saldo);

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = "Pedro Silva";
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numeroAgencia);
Console.WriteLine(contaDoPedro.conta);