using ContaCorrente.ConsoleApp.Entidades;

namespace ContaCorrente.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente("Luiz", "Alvez", "111");
        Cliente cliente2 = new Cliente("Joao", "Alano", "222");
        contaCorrente conta1 = new contaCorrente(1, 1000, 500, cliente);
        contaCorrente conta2 = new contaCorrente(2, 1000, 1000, cliente2);

        DadosDaConta(conta1);
        DadosDaConta(conta2);

        conta1.Depositar(100);
        conta2.Saca(100);

        DadosDaConta(conta1);
        DadosDaConta(conta2);

        conta1.Transfere(conta2, 500);

        DadosDaConta(conta1);
        DadosDaConta(conta2);

        conta1.ConsultaSaldo();
    }
    public static void DadosDaConta(contaCorrente conta)
    {
        System.Console.WriteLine(conta.ToString());
    }
}

