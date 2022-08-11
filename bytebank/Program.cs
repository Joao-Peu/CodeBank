using bytebank;
using bytebank.Titular;


Console.WriteLine("******* boas vindas ao seu banco, Codebank! *******\n");


Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Cpf = "589.365.254-36";
sarah.Profissao = "Professora";

ContaCorrente conta4 = new ContaCorrente(523, "128568-N");
conta4.Saldo = 100;

Console.WriteLine("++ Informações do Titular ++\n ");
conta4.Titular = sarah;
Console.WriteLine("Nome: " + conta4.Titular.Nome);
Console.WriteLine("Profissão: " + conta4.Titular.Profissao);
Console.WriteLine("CPF: " + conta4.Titular.Cpf);

Console.WriteLine("\n++ Informações do Conta ++\n ");
Console.WriteLine("Saldo: R$ " + conta4.Saldo);
Console.WriteLine("Agencia: " + conta4.Numero_agencia);


ContaCorrente ester = new ContaCorrente(265, "568746-A");
ester.Titular = new Cliente();
ester.Titular.Nome = "Ester Pereira";
ester.Titular.Cpf = "497.265.487-21";
ester.Titular.Profissao = "Advogada Trabalhista";
ester.Saldo = 3566.26;

ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + ContaCorrente.TotalDeContasCriadas);




Console.ReadKey();