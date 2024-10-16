using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon;

public class AtaqueEspecial : Ataque
{
    private IEfecto efecto;
    public IEfecto Efecto
    {
        get { return efecto; }
        set { efecto = value; }
    }
    
    

    public AtaqueEspecial(string nombre, int valorataqueespecial, IEfecto efecto)
    : base(nombre, valorataqueespecial)
    {
        this.efecto = efecto;
    }
}