namespace ProyectoPokemon;

public class AtaqueEspecial
{
    private int valorataqueespecial;
    public int ValorAtaqueEspecial
    {
        get{return valorataqueespecial;}
        set{valorataqueespecial = value; }
    }

    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value;}
    }

    public AtaqueEspecial(string nombre, int valorataqueespecial)
    {
        this.nombre = nombre;
        this.valorataqueespecial = valorataqueespecial;
    }
}