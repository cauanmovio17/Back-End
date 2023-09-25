

using Sesi.Model;

class Program
{
    public static void Main()
    {
        var pantera = new Pantera();

        pantera.nome = "Pantera";
        pantera.tamanho = "2 metros";
        pantera.peso = "35 kg";
        pantera.cor = "rosa";
        pantera.especie = "terrestre";
        pantera.alimentação = "Carne";


        pantera.Caracteristicas();
        pantera.Correr();
        pantera.Caçar();
        pantera.Reproduzir();



    }
}