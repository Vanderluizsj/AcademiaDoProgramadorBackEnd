namespace GestaoDeEquipamentos.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsEquipamentos;
    private static int contadorIdsChamados;
    public static int ObterIdEquipamento()
    {
        return contadorIdsEquipamentos++;
    }
    public static int ObterIdChamado()
    {
        return contadorIdsChamados++;
    }
}