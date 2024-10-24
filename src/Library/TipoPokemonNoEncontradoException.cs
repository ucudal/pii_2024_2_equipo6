namespace ProyectoPokemon;

public class TipoPokemonNoEncontradoException: Exception
{
    public TipoPokemonNoEncontradoException()
    {
        
    }

    public TipoPokemonNoEncontradoException(string mensaje) : base(mensaje)
    {
        
    }

    public TipoPokemonNoEncontradoException(string mensaje, Exception inner) : base(mensaje, inner)
    {
        
    }
}