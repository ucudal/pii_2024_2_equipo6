using System.Data.Common;
using System;
using System.Collections.Generic;
using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon;

public class FACHADA
{
    private List<Pokemon> catalogo = new List<Pokemon>();

    public FACHADA()
    {
        IEfecto quemadura = new Quemadura();
        IEfecto veneno = new Veneno();
        IEfecto somnolencia = new Somnolencia();
        IEfecto paralisis = new Paralisis();
        Tipo tipoFuego = new Tipo("Fuego", [new AtaqueComun("Llamarada", 100), new AtaqueEspecial("Inferno", 120,quemadura)]);
        Tipo tipoVolador = new Tipo("Volador", [new AtaqueComun("Tornado", 80), new AtaqueEspecial("Huracán", 110,somnolencia)]);
        Tipo tipoAgua = new Tipo("Agua", [new AtaqueComun("Aqua Jet", 60), new AtaqueEspecial("Hidrobomba", 130,paralisis)]);
        Tipo tipoElectrico = new Tipo("Electrico",
            [new AtaqueComun("Electric bombard", 50), new AtaqueEspecial("Eelctrico con filos", 100,veneno)]);

        catalogo.Add(new Pokemon("Charizard", 266, tipoFuego,50));
        catalogo.Add(new Pokemon("Blastoise", 268, tipoAgua,80));
        catalogo.Add(new Pokemon("Gyarados", 267, tipoVolador,40));
        catalogo.Add(new Pokemon("Pikachu", 300, tipoElectrico,65));
        catalogo.Add(new Pokemon("Luz", 250, tipoVolador,39));
        catalogo.Add(new Pokemon("Mardin", 290, tipoFuego,77));
        catalogo.Add(new Pokemon("Blastoise", 230, tipoAgua,49));
        catalogo.Add(new Pokemon("Drag", 270, tipoFuego,83));
        catalogo.Add(new Pokemon("Floid", 265, tipoVolador,23));
        catalogo.Add(new Pokemon("Blan", 273, tipoAgua,92));
    }

    public List<Pokemon> ObtenerCatalogo()
    {
        return catalogo;
    }

    public void CrearBatalla(string jugador1, List<Pokemon> pokemonsJugador1, string jugador2,
        List<Pokemon> pokemonsJugador2)
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
        for (int i = 0; i < jugador.Pokemones.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}.{jugador.Pokemones[i].Nombre}(HP:{jugador.Pokemones[i].Hp},Tipo:{jugador.Pokemones[i].Tipo}");

        }
    }

    public static void IniciarBatalla(Jugador jugador1, Jugador jugador2)
    {

        Batalla batalla = new Batalla(jugador1, jugador2);
        Efectividad efectividad = new Efectividad();
        while (jugador1.TienePokemonVivos() && jugador2.TienePokemonVivos())
        {
            if (batalla.Jugador1 == jugador1)
            {
                if (jugador1.TienePokemonVivos())
                {
                    Console.WriteLine($"{jugador1.Nombre}, es tu turno de atacar");
                    batalla.Atacar(jugador1, jugador2);
                    Console.WriteLine($"{jugador2.Pokemonelegido.Nombre},HP:{jugador2.Pokemonelegido.Hp}");
                    if (jugador2.Pokemonelegido.Hp <= 0)
                    {
                        Console.WriteLine($"{jugador2.Pokemonelegido.Nombre} fue derrotado");
                    }
                }
            }

            if (batalla.Jugador2 == jugador2)
            {
                if (jugador2.TienePokemonVivos())
                {
                    Console.WriteLine($"{jugador2.Nombre}, es tu turno de atacar");
                    batalla.Atacar(jugador2, jugador1);
                    Console.WriteLine($"{jugador1.Pokemonelegido.Nombre},HP:{jugador1.Pokemonelegido.Hp}");
                    if (jugador1.Pokemonelegido.Hp <= 0)
                    {
                        Console.WriteLine($"{jugador1.Pokemonelegido.Nombre} fue derrotado");
                    }
                }
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
    public static void ElegirPokemonInicial(Jugador jugador)
    {
        for(int i=0;i<jugador.Pokemones.Count;i++)
        {
            Console.WriteLine($"{i+1}.{jugador.Pokemones[i].Nombre}(HP:{jugador.Pokemones[i].Hp},Tipo:{jugador.Pokemones[i].Tipo.Nombre})");
        }
        Console.WriteLine($"\n{jugador.Nombre}, elige tu pokemon para la batalla. Introduce el numero correspondiente");
        int eleccion = int.Parse(Console.ReadLine());
        jugador.Pokemonelegido =jugador.Pokemones[eleccion-1] ;
    }
}   
    
    