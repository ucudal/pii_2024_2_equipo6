namespace ProyectoPokemon;

public class Jugador
{
   private List<Pokemon> pokemones = new List<Pokemon>();
   private Pokemon pokemonelegido;
   private string nombre;

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
   

   public Pokemon Pokemonelegido
   {
      get { return pokemonelegido; }
      set { pokemonelegido = value; }
   }
}