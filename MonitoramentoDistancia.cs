using System;

class Bicicleta
{
    static void Main()
    {
        // Leitura do modelo
        string modelo = Console.ReadLine();

        // Leitura do nível de bateria
        string nivelStr = Console.ReadLine();
        int nivelBateria = int.Parse(nivelStr);

        // Criação do objeto BicicletaInterna
        BicicletaInterna bicicleta = new BicicletaInterna(modelo, nivelBateria);

        // Exibição da mensagem
        Console.WriteLine(bicicleta.ObterMensagem());
    }
}

// Classe interna para representar a bicicleta
class BicicletaInterna
{
    private string Mdl;
    private int NivelBateria;

    // TODO: Crie o construtor da classe BicicletaInterna que inicializa os atributos com os valores recebidos.
    
    public BicicletaInterna(string mdl,int nvlBateria){
      Mdl = mdl;
      NivelBateria = nvlBateria;
    }
    
    
    // TODO: Implemente o método que calcula a distância estimada com base no nível da bateria.
    public float CalcularDistancia(){
      return NivelBateria/2;
    }

    public string ObterMensagem()
    {
        return $"{Mdl}: Distancia estimada = {CalcularDistancia():F1} km";
    }
}
