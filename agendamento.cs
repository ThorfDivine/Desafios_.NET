/*
descricao: sistema de agendamento e exibição de agendamento de consultas;
Gustavo Batista;
02/09/2025.
*/

using System; 
using System.Globalization; 


// Classe que representa um consultor
class Consultor
{
    public string Nome { get; set; } 
    public Agendamento Agendamento { get; set; } 

    public void ExibirInformacoes()
    {
        Console.WriteLine($"{Nome}:"); 

        if (Agendamento == null) 
        {
            Console.WriteLine("Nenhum agendamento cadastrado"); 
        }
        else
        {
            Agendamento.Exibir(); 
        }
    }
}

// TODO: Crie a Classe que representa um agendamento

class Agendamento
{
    public string NomeCliente {get; set;}
    public DateTime Data {get; set;}
    public string Descricao {get; set;}
    
    public void Exibir(){
      Console.WriteLine($"{Data.ToString("dd/MM/yyyy")} - {NomeCliente}: {Descricao}");
    }
}

class Program
{
    static void Main()
    {

        string linhaConsultor = Console.ReadLine();

        string nomeConsultor = linhaConsultor.Replace("Consultor:", "").Trim();

        Console.ReadLine(); 

        string linhaAgendamento = Console.ReadLine();
    
        var consultor = new Consultor { Nome = nomeConsultor };

        if (!string.IsNullOrWhiteSpace(linhaAgendamento))
        {
            
            string[] partes = linhaAgendamento.Split(',');

            var agendamento = new Agendamento
            {
                NomeCliente = partes[0].Trim(), 
                Data = DateTime.ParseExact(partes[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture), 
                Descricao = partes[2].Trim() 
            };

            consultor.Agendamento = agendamento;
        }

        consultor.ExibirInformacoes();
    }
}
