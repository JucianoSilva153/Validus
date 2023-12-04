using Xunit;
using Validus;

namespace Validus.Tests;

public class Validus_ValidarNumeroTelefoneShould
{
    [Theory]
    [InlineData(923679528)]
    [InlineData(923847838)]
    [InlineData(927838898)]
    public void ValidarNumeroTelefone_Teste(int valor)
    {

        var resultado = Validus.ValidarNumeroTelefone(valor);
        Assert.True(resultado);

    }

    [Theory]
    [InlineData("jucianosilva@gmail.com")]
    [InlineData("jucianosilvasilvaa@gmail.com")]
    [InlineData("jucianosilvsa@gmail.com")]
    public void ValidarEmail_Teste(string email)
    {

        var resultado = Validus.ValidarEmail(email);
        Assert.True(resultado);

    }

    [Theory]
    [InlineData("Juc1@no123", 4)]
    [InlineData("dev@0psJucs", 4)]
    [InlineData("B4Rc3L0N", 4)]
    public void ValidarSenha_Teste(string senha, int minCarateres)
    {
        var resultado = Validus.ValidarSenha(senha, minCarateres);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("283920392LD293")]
    [InlineData("283920392MA293")]
    [InlineData("283920392AD293")]
    public void VerificarLetrasBI_Teste(string numeroBilheteIdentidade)
    {
        var resultado = Validus.ValidarBI(numeroBilheteIdentidade);
        Assert.True(resultado);
    }
}
