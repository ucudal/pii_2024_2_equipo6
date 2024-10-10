using ProyectoPokemon;

namespace Program;

public class Fachada
{
    public static void Main(string[] args)
    {
        //Creo Algunos ejemplos de pokemones con sus tipos y ataques
        Tipo tipoFuego = new Tipo("Fuego", new Ataque("Llamarada", 100), new AtaqueEspecial("Inferno", 120));
        Tipo tipoVolador = new Tipo("Volador", new Ataque("Tornado", 80), new AtaqueEspecial("Huracán", 110));
        Tipo tipoAgua = new Tipo("Agua", new Ataque("Aqua Jet", 60), new AtaqueEspecial("Hidrobomba", 130));
            
        Pokemon charizard = new Pokemon("Charizard", 266, tipoFuego);
        Pokemon blastoise = new Pokemon("Blastoise", 268, tipoAgua );
        Pokemon gyarados = new Pokemon("Gyarados",267, tipoVolador );

        //Creo 2 jugaddores y selecciono un pokemon para cada jugador
        Jugador jugador1 = new Jugador();
        Jugador jugador2 = new Jugador();
        jugador1.Nombre = "Ash";
        jugador2.Nombre = "Sha";
        
        jugador1.ElegirPokemon(charizard);
        jugador2.ElegirPokemon(blastoise);
        
        //Comienzo una batalla y realizo ataques
        Batalla batalla = new Batalla(jugador1, jugador2);
        jugador1.Pokemonelegido = charizard;
        jugador2.Pokemonelegido = blastoise;
        batalla.Atacar(jugador1,jugador2);
        batalla.Atacar(jugador2,jugador1);

        //Muestro los resultados de la batalla
        Console.WriteLine(jugador1.Pokemonelegido.Hp);
        Console.WriteLine(jugador2.Pokemonelegido.Hp);
    }
}