namespace Validus.Tests;

public class ValidarEmailTeste
{
    [Theory]
    [InlineData("jucianosilva@gmail.com")]
    [InlineData("jucianosilvasilvaa@gmail.com")]
    [InlineData("jucianosilvsa@gmail.com")]
    public void ValidarEmail_Teste(string email)
    {

        var resultado = Validus.ValidarEmail(email);
        Assert.True(resultado);

    }
}
