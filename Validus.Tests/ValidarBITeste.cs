namespace Validus.Tests;

public class ValidarBITeste
{
    [Theory]
    [InlineData("283920392LD293")]
    [InlineData("283920392MA293")]
    [InlineData("283920392AD293")]
    public void ValidarBI_Teste(string numeroBilheteIdentidade)
    {
        var resultado = Validus.ValidarBI(numeroBilheteIdentidade);
        Assert.True(resultado);
    }
}