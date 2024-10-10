using System.Data.Common;
using System;
using System.Collections.Generic;
namespace ProyectoPokemon;

public class FACHADA
{
    private List<Pokemon> catalogo = new List<Pokemon>();
    public FACHADA()
    {
        Tipo tipoFuego = new Tipo("Fuego", new Ataque("Llamarada", 100), new AtaqueEspecial("Inferno", 120));
        Tipo tipoVolador = new Tipo("Volador", new Ataque("Tornado", 80), new AtaqueEspecial("Huracán", 110));
        Tipo tipoAgua = new Tipo("Agua", new Ataque("Aqua Jet", 60), new AtaqueEspecial("Hidrobomba", 130));
        Tipo tipoElectrico = new Tipo("Electrico",
            new Ataque("Electric bombard", 50), new AtaqueEspecial("Eelctrico con filos", 100));
        
        catalogo.Add(new Pokemon("Charizard",266,tipoFuego));
        catalogo.Add(new Pokemon("Blastoise", 268, tipoAgua));
        catalogo.Add(new Pokemon("Gyarados",267, tipoVolador ));   
        catalogo.Add(new Pokemon("Pikachu",300,tipoElectrico));
        catalogo.Add(new Pokemon("Luz",250,tipoVolador));
        catalogo.Add(new Pokemon("Mardin",290,tipoFuego));
        catalogo.Add(new Pokemon("Blastoise",230,tipoAgua));
        catalogo.Add(new Pokemon("Drag",270,tipoFuego));
        catalogo.Add(new Pokemon("Floid",265,tipoVolador));
        catalogo.Add(new Pokemon("Blan",273,tipoAgua));
    }

    public List<Pokemon> ObtenerCatalogo()
    {
        return catalogo;
    }

    public void  CrearBatalla(string jugador1, List<Pokemon> pokemonsJugador1, string jugador2, List<Pokemon>pokemonsJugador2)
    {
        Console.WriteLine($"{jugador1} ha desafiado a {jugador2} a una batalla Pokemon.");
        Console.WriteLine($"{jugador1} elige los siguientes Pokemón:");
        foreach (var pokemon in pokemonsJugador1)
        {
            Console.WriteLine($"{pokemon.Nombre}-{pokemon.Tipo.Nombre}-{pokemon.Hp} puntos de vida");
            
        }
        Console.WriteLine($"{jugador2}elige los siguientes Pokemón:");
        foreach (var pokemon in pokemonsJugador1)
        {
            Console.WriteLine($"{pokemon.Nombre}-{pokemon.Tipo.Nombre}-{pokemon.Hp} puntos de vida");
            
        }
    }

    public static void ElegirPokemonParaJugar(Jugador jugador, List<Pokemon> catalogo)
    {
        for (int i = 0; i < 6; i++)
        {
            bool eleccionValida = false;
            while (!eleccionValida)
            {
                Console.WriteLine($"Elige el Pokemon{i + 1}:");
                if (int.TryParse(Console.ReadLine(), out int numeroElegido) && numeroElegido >= 1 &&
                    numeroElegido <= catalogo.Count)
                {
                    Pokemon pokemonElegido = catalogo[numeroElegido - 1];
                    jugador.ElegirPokemon(pokemonElegido);
                    Console.WriteLine($"Has elegido a {pokemonElegido.Nombre}");
                    eleccionValida = true;
                }
                else
                {
                    Console.WriteLine("Eleccion invalida, intente de nuevo.");
                }
            }
        }
    }

    public static void ElegirOrdenInicial(Jugador jugador)
    {
        bool ordenValido = false;
        while (!ordenValido)
        {
            if (int.TryParse(Console.ReadLine(), out int ordenElegido) && ordenElegido >= 1 &&
                ordenElegido <= 3)
            {
                jugador.Pokemonelegido = jugador.Pokemones[ordenElegido - 1];
                Console.WriteLine($"Usaras a {jugador.Pokemonelegido.Nombre} primero");
                ordenValido = true;
            }
            else
            {
                Console.WriteLine("Eleccion invalida, intente de nuevo.");
            }
        }
    }

    public static void MostrarPokemonElegidos(Jugador jugador)
    {
        for (int i=0;i<jugador.Pokemones.Count;i++)
        {
            Console.WriteLine($"{i+1}.{jugador.Pokemones[i].Nombre}(HP:{jugador.Pokemones[i].Hp},Tipo:{jugador.Pokemones[i].Tipo}");
            
        }
    }

    public static void IniciarBatalla(Jugador jugador1, Jugador jugador2)
    {
        Batalla batalla = new Batalla(jugador1,jugador2);
        while (jugador1.TienePokemonVivos() && jugador2.TienePokemonVivos())
        {
            if (batalla.Jugador1 == jugador1)
            {
                if (jugador1.TienePokemonVivos())
                {
                    Console.WriteLine($"{jugador1.Nombre}, es tu turno de atacar");
                    batalla.Atacar(jugador1,jugador2);
                    Console.WriteLine($"{jugador2.Pokemonelegido},HP:{jugador2.Pokemonelegido.Hp}");
                }
            }

            if (batalla.Jugador2 == jugador2)
            {
                if (jugador2.TienePokemonVivos())
                {
                    Console.WriteLine($"{jugador2.Nombre}, es tu turno de atacar");
                    batalla.Atacar(jugador2,jugador1);
                    Console.WriteLine($"{jugador1.Pokemonelegido},HP:{jugador1.Pokemonelegido.Hp}");
                }
                
            }
            if (!jugador1.TienePokemonVivos())
            {
                Console.WriteLine($"{jugador1.Nombre} ha perdido la batalla");
            }
            else
            {
                Console.WriteLine($"{jugador2.Nombre} ha perdido la batalla ");
            }
        }

        
    }
}
    
    