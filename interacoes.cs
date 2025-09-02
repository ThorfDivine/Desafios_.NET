/*
descrição: sistema que diz quantas interações foram tidas ao decorrer de um certo tempo
exemplos de entrada: 5 id1 id2 id3 id4 id5; 3 id1 id2 id3; 2 id1 id2
nome: Gustavo Batista
02/09/2025
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        
        
        string[] interacoes = entrada.Split(' ');

        Console.WriteLine($"{interacoes[0]} interacoes");
    }
}
