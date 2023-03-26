
using ByteBank;

ContaCorrente contaDoWeslley = new ContaCorrente();
contaDoWeslley.titular = "Weslley G. da Cruz";
contaDoWeslley.numeroAgencia = 15;
contaDoWeslley.conta = "1010-X";
contaDoWeslley.saldo = 100;

Console.WriteLine("Saldo da Conta do Weslley: R$ "+contaDoWeslley.saldo);

contaDoWeslley.Depositar(100);
Console.WriteLine("Deposito efetuado no valor de: R$ 100");

Console.WriteLine("Saldo da Conta do Weslley: R$ " + contaDoWeslley.saldo);
