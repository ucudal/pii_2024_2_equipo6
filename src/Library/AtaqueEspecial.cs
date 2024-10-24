using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon;

public class AtaqueEspecial : IAtaque
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno
    public int ValorAtaque { get; set; }

    public IEfecto Efecto //genera un efecto, que será parte del ataque especial
    {
        get { return Efecto; } 
        set { Efecto = value; }
    }
    
    

    public AtaqueEspecial(string nombre, int valorataqueespecial, IEfecto efecto)//generamos un constructor al ataque especial, para poder ingresarle el nombre,  su valor de ataque y su efecto
    {
        this.Nombre = nombre + " (Especial)"; //en este lugar se guarda lo que se ingresa en el constructor
        this.ValorAtaque = valorataqueespecial;
        this.Efecto = efecto;
    }
    
}