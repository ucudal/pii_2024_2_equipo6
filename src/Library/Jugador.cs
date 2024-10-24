using ProyectoPokemon.Interfaces;
using ProyectoPokemon.Items;

namespace ProyectoPokemon;

public class Jugador
{
   private List<Pokemon> pokemones = new List<Pokemon>();
   private Pokemon pokemonelegido;
   private string nombre;
   private List<IItems> items = new List<IItems>();
   public Jugador(string nombre, List<IItems> mochila=null) //agrego un constructor con el nombre del jugador, y los items que podrá tener
   {
      this.nombre = nombre;
      items.Add(new Revivir());//agregamos las instancias de items a items (que luego se llamará mochila)
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new SuperPocion());
      items.Add(new CuracionTotal());
      items.Add(new CuracionTotal());
      items = mochila;
   }
   public string Nombre
   {
      get { return nombre; }
      set { nombre = value; }
   }
   
   public void ElegirPokemon(Pokemon pokemon) //contamos cuantos pokemones va a tener cada jugador(maximo 6)
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
   
   public List<IItems> Items
   {
      get { return items; }
   }

   public Pokemon Pokemonelegido
   {
      get { return pokemonelegido; }
      set { pokemonelegido = value; }
   }

   public bool TienePokemonVivos() //verifica si tiene pokemones vivos el jugador
   {
      return Pokemonelegido != null && Pokemonelegido.Hp > 0;
   }
   
}