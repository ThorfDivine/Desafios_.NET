/*
verifica a autenticidade do token, necessario: O token deve ter exatamente 10 caracteres, Deve começar com a letra "A" maiúscula e Deve conter pelo menos um dígito numérico
Gustavo Batista 
02/09/2025
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
      
        string token = Console.ReadLine();
        bool autorizacao = true;
        
        string[] tk = token.Select(c => c.ToString()).ToArray();
        
        autorizacao = tk.Length == 10 && tk[0] == "A" && tk.Any(s => decimal.TryParse(s, out _));
        
        string r = autorizacao? "Acesso permitido" : "Acesso negado";
        Console.WriteLine(r);
        
    }
}
