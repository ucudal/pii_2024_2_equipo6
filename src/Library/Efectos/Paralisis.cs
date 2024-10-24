using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Paralisis : IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Paralisis";
    public void AplicarEfecto( Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaParalizado)// si el pokemon elegido del jugador receptor esta paralizado
        {
            receptor.Pokemonelegido.EstaParalizado = true;//ponemos en true, en verdadero, que esta paralizado
            receptor.Pokemonelegido.TieneEstadoEspecial = true;//lo mismo, pero que este contiene un estado especial
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido Paralizado");
        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya esta paralizado.");
        }
    }
}