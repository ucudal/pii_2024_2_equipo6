using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Quemadura : IEfecto
{
    public string Nombre { get; set; }

    private string nombre = "Quemadura";

    public void AplicarEfecto(Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaQuemado)// si el pokemon elegido del jugador receptor esta quemado
        {
            receptor.Pokemonelegido.EstaQuemado = true;//ponemos en true, en verdadero, que esta quemado
            receptor.Pokemonelegido.TieneEstadoEspecial = true;//lo mismo, pero que este contiene un estado especial
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido quemado");

        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya esta quemado.");
        }

    }
}