using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Veneno: IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Veneno";
    public void AplicarEfecto( Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaEnvenenado)// si el pokemon elegido del jugador receptor esta envenenado
        {
            receptor.Pokemonelegido.EstaEnvenenado = true;//ponemos en true, en verdadero, que esta envenenado
            receptor.Pokemonelegido.TieneEstadoEspecial = true;//lo mismo, pero que este contiene un estado especial
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido envenenado");
        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya está envenenado.");
        }
    }
}