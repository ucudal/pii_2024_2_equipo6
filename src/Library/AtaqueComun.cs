namespace ProyectoPokemon;

public class AtaqueComun : IAtaque
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno
    public int ValorAtaque { get; set; }
    public AtaqueComun(string nombre, int valorataque) //generamos un constructor al ataque comun, para poder ingresarle el nombre, y su valor de ataque
    {
        this.Nombre = nombre; //en este lugar se guarda lo que se ingresa en el constructor
        this.ValorAtaque = valorataque;
    }
}