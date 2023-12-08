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

}
