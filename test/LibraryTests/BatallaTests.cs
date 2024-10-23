using ProyectoPokemon;
using NUnit.Framework;
using ProyectoPokemon;
using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

namespace Tests
{
    public class BatallaTests
    {
        [Test]
        public void BatallaTest()
        {
            IEfecto somnolencia = new Somnolencia();
            IEfecto paralisis = new Paralisis();
            Jugador jugador1 = new Jugador("Diego");
            Jugador jugador2 = new Jugador("Julia");
            Batalla batalla = new Batalla(jugador2, jugador1);
            Tipo tipoElectrico = new Tipo("Electrico", [new AtaqueComun("Rayos", 5), new AtaqueEspecial("Rayos especiales", 10, somnolencia)]);
            Tipo tipoAgua = new Tipo("Agua", [new AtaqueComun("Bolas de agua", 3),
                new AtaqueEspecial("Bolas de agua con rayos", 7, paralisis)]);
            Pokemon pokemon1 = new Pokemon("Pikachu", 100, tipoElectrico, 57.9);

            Pokemon pokemon2 = new Pokemon("Luz", 100, tipoAgua, 34.9);
            jugador1.ElegirPokemon(pokemon1);
            jugador1.Pokemonelegido = pokemon1;
            jugador2.ElegirPokemon(pokemon2);
            jugador2.Pokemonelegido = pokemon2;

            batalla.Atacar(jugador1,jugador2);
            Assert.That(jugador2.Pokemonelegido.Hp, Is.EqualTo(100)); //Comparacion.

        }
    }
}

