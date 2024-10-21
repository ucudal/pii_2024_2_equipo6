using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Quemadura : IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Quemadura";
    public void AplicarEfecto(Jugador receptor)
    {
        receptor.Pokemonelegido.EstaQuemado = true;
        receptor.Pokemonelegido.TieneEstadoEspecial = true;
        Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido quemado");
    }
}