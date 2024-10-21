using ProyectoPokemon;

namespace Proagugram;
using System;
using System.Collections.Generic;
public class Program
{
   public static void Main(string[] args)
   {
      FACHADA fachada = new FACHADA();
      List<Pokemon> catalogo = fachada.ObtenerCatalogo();
      Jugador jugador1 = new Jugador("");
      Jugador jugador2 = new Jugador("");
      Console.WriteLine("\nJugador1, Ingresa su nombre");
      jugador1.Nombre = Console.ReadLine();
      Console.WriteLine("Catalogo de Pokemon:");
      for(int i=0;i<catalogo.Count;i++)
      {
         Console.WriteLine($"{i+1}.{catalogo[i].Nombre}(HP:{catalogo[i].Hp},Tipo:{catalogo[i].Tipo.Nombre})");
      }

      Console.WriteLine($"\n{jugador1.Nombre},elige tus 6 pokemones.Introduce el numero correspondiente del catálogo:");
      FACHADA.ElegirPokemonParaJugar(jugador1,catalogo);
      Console.WriteLine("\nJugador2, ingresa tu nombre: ");
      jugador2.Nombre = Console.ReadLine();
      Console.WriteLine($"\n{jugador2.Nombre},elige tus 6 pokemones.Introduce el numero correspondiente del catálogo:");
      FACHADA.ElegirPokemonParaJugar(jugador2,catalogo);
      FACHADA.ElegirPokemonInicial(jugador1);
      FACHADA.ElegirPokemonInicial(jugador2);
      FACHADA.IniciarBatalla(jugador1,jugador2);
   }
}
