using Xunit;

public class OperacoesTests
{
    [Fact]
    public void Somar_DeveRetornarSomaCorreta()
    {
        int resultado = Program.Somar(2, 3, 5);
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void Subtrair_DeveRetornarSubtracaoCorreta()
    {
        int resultado = Program.Subtrair(10, 3, 2);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Multiplicar_DeveRetornarMultiplicacaoCorreta()
    {
        int resultado = Program.Multiplicar(2, 3, 4);
        Assert.Equal(24, resultado);
    }

    [Fact]
    public void Somar_ComZero_DeveRetornarValorCorreto()
    {
        int resultado = Program.Somar(0, 5, 7);
        Assert.Equal(12, resultado);
    }

    [Fact]
    public void Multiplicar_ComZero_DeveRetornarZero()
    {
        int resultado = Program.Multiplicar(10, 5, 0);
        Assert.Equal(0, resultado);
    }
}
