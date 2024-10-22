using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Paralisis : IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Paralisis";
    public void AplicarEfecto( Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaParalizado)
        {
            receptor.Pokemonelegido.EstaParalizado = true;
            receptor.Pokemonelegido.TieneEstadoEspecial = true;
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido Paralizado");
        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya esta paralizado.");
        }
    }
}