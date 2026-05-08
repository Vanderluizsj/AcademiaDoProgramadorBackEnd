namespace ContaCorrente.ConsoleApp.Entidades;

public class contaCorrente
{
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double LimiteDaConta { get; set; }
    public Cliente Titular { get; set; }
    


    public contaCorrente(int numeroDaConta, double saldo, double limiteDaConta, Cliente titular)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        LimiteDaConta = limiteDaConta;
        Titular = titular;
    }

    public bool Saca(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }
        else
        {
            this.Saldo = this.Saldo - valor;
            return true;
        }
    }
    public void Depositar(double quantidade)
    {
        this.Saldo += quantidade;
    }
    public void ConsultaSaldo()
    {
        System.Console.WriteLine($"O saldo atual da conta é {Saldo}");
    }
    public bool Transfere(contaCorrente destino, double valor)
    {
        bool retirou = this.Saca(valor);
        if (retirou == false)
        {
            return false;
        }
        else
        {
            destino.Depositar(valor);
            return true;
        }
    }

    public override  string ToString()
        {
            return "Cliente {" + "\nNumeroDaConta: " 
            + NumeroDaConta + ", \nSaldo: " + Saldo + ", \nLimite: " 
            + LimiteDaConta + ", \nTitular: " + Titular.Completo + "}\n";
        }
}
