namespace Validus.Tests;


public class ValidarSenhaTeste
{
    [Theory]
    [InlineData("Juc1@no123", 4)]
    [InlineData("dev@0psJucs", 4)]
    [InlineData("B4Rc3L0N$", 4)]
    public void ValidarSenha_Teste(string senha, int minCarateres)
    {
        var resultado = Validus.ValidarSenha(senha, minCarateres);
        Assert.True(resultado);
    }
}