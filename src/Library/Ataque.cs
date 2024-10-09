namespace ProyectoPokemon;

public class Ataque
{
    private int valorataque;
    public int ValorAtaque
    {
        get{return valorataque;}
        set{valorataque = value; }
    }

    private string nombre;

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