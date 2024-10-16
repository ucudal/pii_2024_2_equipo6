namespace ProyectoPokemon;

public class Ataque
{
    protected int valorataque;
    public int ValorAtaque
    {
        get{return valorataque;}
        set{valorataque = value; }
    }

    protected string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value;}
    }

    public Ataque(string nombre, int valorataque)
    {
        this.nombre = nombre;
        this.valorataque = valorataque;
    }
}