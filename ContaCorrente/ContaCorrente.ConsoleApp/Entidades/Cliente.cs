namespace ContaCorrente.ConsoleApp.Entidades;

public class Cliente
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }


    public Cliente(string nome, string sobrenome, string cpf)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Cpf = cpf;
    }
   
    public string Completo
        {
            get
            {
                return Nome + " " + Sobrenome + ", cpf: " + Cpf;
            }
        }
}
