using System;
using System.Text.RegularExpressions;

public class ValidaParametrosAPI
{
    public static void Main(string[] args)
    {
        // Solicita a entrada da URL
        string url = Console.ReadLine();

        // Chama o método para validar a URL
        string resultado = ValidarParametros(url);

        // Exibe o resultado
        Console.WriteLine(resultado);
    }

    // Método para validar os parametros da URL
    public static string ValidarParametros(string url)
    {
        // Valida se a URL começa com '?'
        if (!url.StartsWith("?"))
        {
            return "Parametros invalidos";
        }

        // Remove o '?' da URL para analisar os parametros
        url = url.Substring(1);

        // Divide a URL pelos '&' para obter cada parametro
        string[] parametros = url.Split('&');

        // TODO: Verifique cada parametro individualmente:
        foreach (string parametro in parametros)
        {
            // TODO: Divida cada parametro pelo '='
            string[] chaveValor = parametro.Split('=');

            // TODO: Verifique se há exatamente um '='
            if (chaveValor.Length != 2)
            {
                return "Parametros invalidos";
            }

            // TODO: Valide o nome do parametro (alfanumerico)
            if (!Regex.IsMatch(chaveValor[0], @"^[a-zA-Z0-9]+$"))
            {
                return "Parametros invalidos";
            }

            // Valida o valor do parametro (alfanumerico ou numero, ou valores como e-mail)
            // Permite caracteres especiais como @ e . para casos como email
            if (!Regex.IsMatch(chaveValor[1], @"^[a-zA-Z0-9@.]+$") && !Regex.IsMatch(chaveValor[1], @"^\d+$"))
            {
                return "Parametros invalidos";
            }
        }

        // Se passar em todas as validacoes, os parametros são validos
        return "Parametros validos";
    }
}
