using System;

class CalculoFreteRapido
{
    static void Main()
    {
        // Lê o peso em quilos
        double peso = Convert.ToDouble(Console.ReadLine());

        // TODO: Leia o valor do frete por quilo
        
        double valor = Convert.ToDouble(Console.ReadLine());

        // TODO: Calcule o valor total do frete

          double resultado = peso * valor;
       

        // TODO: Exiba o valor formatado com duas casas decimais
          Console.WriteLine(resultado.ToString("F"));
    }
}
