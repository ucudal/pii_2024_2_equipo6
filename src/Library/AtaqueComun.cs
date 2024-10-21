namespace ProyectoPokemon;

public class AtaqueComun : IAtaque
{
    public string Nombre { get; set; }
    public int ValorAtaque { get; set; }
    public AtaqueComun(string nombre, int valorataque)
    {
        this.Nombre = nombre;
        this.ValorAtaque = valorataque;
    }
}