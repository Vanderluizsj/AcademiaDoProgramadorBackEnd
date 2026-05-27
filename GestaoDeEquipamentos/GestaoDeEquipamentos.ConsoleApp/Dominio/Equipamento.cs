using GestaoDeEquipamentos.ConsoleApp.Utilidades;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

/*
    • Deve ter identificador único (id)
    • Deve ter um nome com no mínimo 6 caracteres;
    • Deve ter um preço de aquisição;
    • Deve ter uma fabricante; [X]
    • Deve ter uma data de fabricação;
*/
public class Equipamento
{
    public int Id { get; private set; }
    public string? Nome { get; private set; }
    public decimal PrecoAquisicao { get; private set; }
    public DateTime DataFabricacao { get; private set; }

    public Equipamento(string nome, decimal preco, DateTime data)
    {
        Id = GeradorIds.ObterIdEquipamento();
        Nome = nome;
        PrecoAquisicao = preco;
        DataFabricacao = data;
    }
    public void Atualizar(Equipamento equipamentoAtualizado)
    {
        Nome = equipamentoAtualizado.Nome;
        PrecoAquisicao = equipamentoAtualizado.PrecoAquisicao;
        DataFabricacao = equipamentoAtualizado.DataFabricacao;
    }
}
