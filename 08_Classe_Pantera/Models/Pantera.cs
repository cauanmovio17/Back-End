
namespace Sesi.Model
{

  public class Pantera
  {


    public string nome { get; set; }
    public string tamanho { get; set; }
    public string peso { get; set; }
    public string cor { get; set; }
    public string especie { get; set; }
    public string alimentação { get; set; }







    public void Caracteristicas()
    {
        Console.WriteLine($"Olá, eu sou a {nome}, tenho {tamanho} de altura, peso {peso}, minha cor é {cor}, sou da especie {especie}, e me alimento de {alimentação} ");
    }
    public void Correr()
    {
      Console.WriteLine($"{nome} esta correndo");
    }
    public void Caçar()
    {
      Console.WriteLine($"{nome} esta caçando");
    }
    public void Reproduzir()
    {
      Console.WriteLine($"{nome} esta reproduzindo");
    }


  }

}