using NUnit.Framework;
using ProyectoPokemon;
using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

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
        IEfecto veneno = new Veneno();
        AtaqueComun ataque = new AtaqueComun("Bombita de agua", 15);
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Pistola de agua", 25, veneno);
        Tipo agua = new Tipo("Agua", [ataque, ataqueEspecial]);
        Pokemon pokemon = new Pokemon("Bulbasaur", 28.5, agua, 51.6);
        Jugador jugador = new Jugador("Jessie");
        jugador.ElegirPokemon(pokemon);
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemones[0]));
        
    }

    [Test]
    public void PokemonActual()
    {
        IEfecto veneno = new Veneno();
        AtaqueComun ataque = new AtaqueComun("Velita", 15);
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Encendedor", 25, veneno);
        Tipo fuego = new Tipo("Fuego", [ataque, ataqueEspecial]);
        Pokemon pokemon = new Pokemon("Charmander", 28.5, fuego, 46.8);
        Jugador jugador = new Jugador("Jessie");
        jugador.ElegirPokemon(pokemon);
        jugador.Pokemonelegido = pokemon;
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemones[0]));
        Assert.That(pokemon, Is.EqualTo(jugador.Pokemonelegido));
    }
}
