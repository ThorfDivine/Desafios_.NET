/*
simulador de Endpoint 
Gustavo Batista
02/09/2025
*/
using System; 

class Program
{

    static void Main()
    {
        string endpoint = Console.ReadLine();

        Console.WriteLine(endpoint=="/clientes"? "Listando clientes...":endpoint=="/produtos"? "Exibindo produtos disponiveis..." : endpoint=="/relatorios"? "Gerando relatorio de desempenho..." : "Endpoint nao reconhecido.");
    }
}
