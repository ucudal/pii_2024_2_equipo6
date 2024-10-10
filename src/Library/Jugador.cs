namespace ProyectoPokemon;

public class Jugador
{
   private List<Pokemon> pokemones = new List<Pokemon>();
   private Pokemon pokemonelegido;
   private string nombre;

   public Jugador(string nombre)
   {
      this.nombre = nombre;
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