/*
descrição: recebe um pedido e de acordo com ele indica o melhor plano
nome: Gustavo Batista
02/09/2025
*/

using System; 

class Programa 
{
    static void Main() 
    {
        string entrada = Console.ReadLine(); 
        string planoRecomendado = "";
        
        planoRecomendado = entrada=="basico"? "plano basico" : entrada=="intermediario"? "plano intermediario" :  "plano avancado";
        
        Console.WriteLine($"Recomendado: {planoRecomendado}"); 
        
    }
}
