using System;

class CarroMonitoramento
{
     // TODO: Crie o método estático que verifica se o carro está apto
        public static string verificar(string mdl, int anoF, int anoA){
            int idade = anoA - anoF;
            return $"{mdl}: { idade <= 10 ? "Apto" : "Nao apto" }";
        }
        // TODO: Calcule a idade do carro

        // TODO: Verifique se o carro tem até 10 anos

    static void Main()
    {
        // Lendo os dados de entrada
        string modelo = Console.ReadLine();
        int anoFabricacao = int.Parse(Console.ReadLine());
        int anoAtual = int.Parse(Console.ReadLine());

        //  TODO: Implemente a chamada do método para verificar se o carro está apto
        string resultado = verificar(modelo,anoFabricacao,anoAtual);

        // Exibindo o resultado
        Console.WriteLine(resultado);
    }
}
