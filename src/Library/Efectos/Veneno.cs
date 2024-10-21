using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Veneno: IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Veneno";
    public void AplicarEfecto( Jugador receptor)
    {
        receptor.Pokemonelegido.EstaEnvenenado = true;
        receptor.Pokemonelegido.TieneEstadoEspecial = true;
        Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido envenenado");
    }
}