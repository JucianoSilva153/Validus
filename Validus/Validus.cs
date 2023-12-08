using System.Text.RegularExpressions;

namespace Validus;

public static class Validus
{
    public static bool ValidarNumeroTelefone(int numeroTelefone)
    {
        try
        {
            if (numeroTelefone.ToString().Length == 9 && numeroTelefone.ToString()[0] == '9')
            {
                return true;
            }
        }
        catch (Exception)
        {
            throw new Exception("Erro ao Validar o Numero de Telefone Inserido!!");
        }

        return false;
    }

    public static bool ValidarEmail(string mail)
    {
        var mailDividido = DivideEmail(mail);
        if (!(mailDividido is null))
        {
            if (ValidarParteLocalEmail(mailDividido[0]) && ValidarParteDominioEmail(mailDividido[1]))
                return true;
        }
        return false;
    }
    private static string[] DivideEmail(string email)
    {
        if (email.Contains("@"))
        {
            var componentesMail = email.Split('@');
            return componentesMail;
        }

        return new string[0];
    }
    private static bool ValidarParteLocalEmail(string parteEmail)
    {
        string padraoEmailParteLoacal = @"^[a-zA-Z0-9._%+-]+$";
        if (Regex.IsMatch(parteEmail, padraoEmailParteLoacal))
            return true;
        return false;
    }
    private static bool ValidarParteDominioEmail(string dominioEmail)
    {
        string padraoEmailDominio = @"^[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        if (Regex.IsMatch(dominioEmail, padraoEmailDominio))
            return true;
        return false;
    }
    public static bool ValidarSenha(string senha, int minCarateres)
    {
        if (senha.Length >= minCarateres && VerificarSenhaSegura(senha, minCarateres))
            return true;
        return false;
    }
    private static bool VerificarSenhaSegura(string senha, int minChar)
    {
        //B4Rc3L0N$
        string padraoSenha = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{" + minChar + ",}$";
        if (Regex.IsMatch(senha, padraoSenha))
        {
            return true;
        }
        return false;
    }
    public static bool ValidarBI(string BI)
    {
        if (BI.Length == 14
        && VerificarLetrasBI(BI))
            return true;
        return false;
    }
    private static bool VerificarLetrasBI(string BI)
    {
        string padraoBI = @"^\d{9}[A-Z]{2}\d{3}$";
        if (Regex.IsMatch(BI, padraoBI))
            return true;
        return false;
    }


}
