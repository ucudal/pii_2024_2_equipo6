namespace ProyectoPokemon.Interfaces;

public interface IEfecto
{
    public string Nombre { get; set; }
    
    public void AplicarEfecto(Jugador receptor);
    
}