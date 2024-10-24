using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Efectos;

public class Somnolencia : IEfecto
{
    private Random random = new Random();
    public string Nombre { get; set; }
    private string nombre = "Somnolencia";
    public void AplicarEfecto(Jugador receptor)
    {
        if (!receptor.Pokemonelegido.EstaDormido)// si el pokemon elegido del jugador receptor esta dormido
        {
            receptor.Pokemonelegido.EstaDormido = true;//ponemos en true, en verdadero, que esta dormido
            receptor.Pokemonelegido.TieneEstadoEspecial = true;//lo mismo, pero que este contiene un estado especial
            receptor.Pokemonelegido.TurnosDormido = random.Next(1, 5);//generamos la cantidad de turnos dormido entre 1 y 4
            
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ha sido dormido por su atacante");
            
        }
        else
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya esta dormido.");
        }
        
        
    }
}