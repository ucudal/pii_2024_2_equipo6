namespace ProyectoPokemon;

public class Batalla
{
    private bool turno = ManejoDeJugadores.Turno;
    private int contador1 = 2;
    private int contador2 = 2;
    private Jugador jugador1;
    private Jugador jugador2;
    

    public Batalla(Jugador jugador1, Jugador jugador2)
    {
        this.jugador1 = jugador1;
        this.jugador2 = jugador2;
    }

    public Jugador Jugador1
    {
        get {return jugador1;}
    }
    public Jugador Jugador2
    {
        get {return jugador2;}
    }
    
}