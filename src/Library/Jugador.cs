using ProyectoPokemon.Interfaces;
using ProyectoPokemon.Items;

namespace ProyectoPokemon;

public class Jugador
{
   private List<Pokemon> pokemones = new List<Pokemon>();
   private Pokemon pokemonelegido;
   private string nombre;
   private List<IItems> items = new List<IItems>();

   public Jugador(string nombre)
   {
      this.nombre = nombre;
      items.Add(new Revivir());
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new CuracionTotal());
      items.Add(new CuracionTotal());
   }
   public string Nombre
   {
      get { return nombre; }
      set { nombre = value; }
   }
   
   public void ElegirPokemon(Pokemon pokemon)
   {
      if (pokemones.Count < 6)
      {
         pokemones.Add(pokemon);
      }
   }

   public List<Pokemon> Pokemones
   {
      get { return pokemones; }
   }

   public Pokemon Pokemonelegido
   {
      get { return pokemonelegido; }
      set { pokemonelegido = value; }
   }

   public bool TienePokemonVivos()
   {
      return Pokemonelegido != null && Pokemonelegido.Hp > 0;
   }
}