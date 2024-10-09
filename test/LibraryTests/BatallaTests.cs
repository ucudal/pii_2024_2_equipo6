using NUnit.Framework;
using ProyectoPokemon;

namespace Tests;

[TestFixture]
public class BatallaTests
{


    public void BatallaTest()
    {
        Efectividad efectividad = new Efectividad();
        Jugador jugador1 = new Jugador();
        Jugador jugador2 = new Jugador();
        Batalla batalla = new Batalla(jugador2, jugador1);
        var tipoElectrico = new Tipo("Electrico", new Ataque("Rayos", 5), new AtaqueEspecial("Rayos especiales", 10));
        var tipoAgua = new Tipo("Agua", new Ataque("Bolas de agua", 3),
            new AtaqueEspecial("Bolas de agua con rayos", 7));
        Pokemon pokemon1 = new Pokemon("Pikachu", 100, tipoElectrico);

        Pokemon pokemon2 = new Pokemon("Luz", 100, tipoAgua);
        jugador1.ElegirPokemon(pokemon1);
        jugador1.Pokemonelegido = pokemon1;
        jugador2.ElegirPokemon(pokemon2);
        jugador2.Pokemonelegido = pokemon2;

        var ataque = jugador1.Pokemonelegido.Ataque;
        var tipoAtacante = jugador1.Pokemonelegido.Tipo;
        var tipoReceptor = jugador2.Pokemonelegido.Tipo;
        double efectividadValor = efectividad.getEfectividad(tipoAtacante, tipoReceptor);
        batalla.Atacar(jugador1,jugador2);
        double damage = ataque.ValorAtaque * efectividadValor;
        Assert.Equals(100 - damage, jugador2.Pokemonelegido.Hp);
    }
}