using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon;

public class AtaqueEspecial : IAtaque
{
    public string Nombre { get; set; }
    public int ValorAtaque { get; set; }

    public IEfecto Efecto
    {
        get { return Efecto; }
        set { Efecto = value; }
    }
    
    

    public AtaqueEspecial(string nombre, int valorataqueespecial, IEfecto efecto)
    {
        this.Nombre = nombre + " (Especial)";
        this.ValorAtaque = valorataqueespecial;
        this.Efecto = efecto;
    }
    
}