namespace ProyectoPokemon;

public class Tipo
{
    private string nombre;
    private Ataque ataque;
    private AtaqueEspecial ataqueEspecial;
    public Tipo(string Nombre, Ataque ataque, AtaqueEspecial ataqueEspecial)
    {
        this.nombre = Nombre;
        this.ataque = ataque;
        this.ataqueEspecial = ataqueEspecial;
        
    }
    public string Nombre
    { 
        get
        {
            return nombre;
        }
    }

    public Ataque Ataque
    {
        get
        {
            return ataque;
        }
        set
        {
            ataque = value;
        }
    }
    public AtaqueEspecial AtaqueEspecial
    {
        get 	
        {
            return ataqueEspecial;
        }
        set
        {
            ataqueEspecial = value;
        }
        
    }
}