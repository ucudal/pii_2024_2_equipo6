using NUnit.Framework;
using ProyectoPokemon;

namespace Tests;

public class JugadorTest
{
    [Test]

    public void CrearJugador()
    {
        Jugador jugador = new Jugador("Ash");
        Assert.That("Ash", Is.EqualTo(jugador.Nombre));
    }

    [Test]
    public void ElegirPokemon()
    {
        Ataque ataque = new Ataque("Bombita de agua", 15);
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Pistola de agua", 25);
        Tipo agua = new Tipo("Agua", ataque, ataqueEspecial);
        Pokemon pokemon = new Pokemon("Bulbasaur", 28.5, agua);
        Jugador jugador = new Jugador("Jessie");
        jugador.ElegirPokemon(pokemon);
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemones[0]));
        
    }

    [Test]
    public void PokemonActual()
    {
        Ataque ataque = new Ataque("Velita", 15);
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Encendedor", 25);
        Tipo fuego = new Tipo("Fuego", ataque, ataqueEspecial);
        Pokemon pokemon = new Pokemon("Charmander", 28.5, fuego);
        Jugador jugador = new Jugador("Jessie");
        jugador.ElegirPokemon(pokemon);
        jugador.Pokemonelegido = pokemon;
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemones[0]));
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemonelegido));
    }
}