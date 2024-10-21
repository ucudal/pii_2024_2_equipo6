using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Somnolencia : IEfecto
{
    private Random random = new Random();
    public string Nombre { get; set; }
    private string nombre = "Somnolencia";
    public void AplicarEfecto(Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaDormido)
        {
            receptor.Pokemonelegido.EstaDormido = true;
            receptor.Pokemonelegido.TieneEstadoEspecial = true;
            receptor.Pokemonelegido.TurnosDormido = random.Next(1, 5);
            
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido dormido por su atacante");
            
        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya esta dormido.");
        }
        
        
    }
}