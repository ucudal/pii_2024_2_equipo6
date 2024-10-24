namespace ProyectoPokemon.Interfaces;

public interface IEfecto
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno
    
    public void AplicarEfecto(Jugador receptor);//este metodo aplica el efecto del pokemon del jugador receptor
    
}