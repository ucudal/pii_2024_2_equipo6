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

   public void CambiarPokemon(Pokemon pokemonelegido, Pokemon pokemonnuevo)
   {
         pokemones.Remove(pokemonelegido);
         pokemones.Add(pokemonnuevo);
   }

   public void Atacar(Ataque ataque, Pokemon pokemonrival)
   {
      pokemonrival.Hp -= ataque;
   }

   public bool AtacarConEspecial(AtaqueEspecial ataqueEspecial, Pokemon pokemonrival)
   {
      if (ManejadorDeTurno.ContadorAtaqueEspecial = 0)
      {
         pokemonrival.Hp -= ataqueEspecial;
         return true;
      }
      else
      {
         return false;
      }
   }
}