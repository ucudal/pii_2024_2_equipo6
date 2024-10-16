namespace ProyectoPokemon;

public class Tipo
{
    private string nombre;
    private List<Ataque> ataques;
    public Tipo(string Nombre)
    {
        ataques = new List<Ataque>();
        this.nombre = Nombre;
    }
    public string Nombre
    { 
        get
        {
            return nombre;
        }
    }

    public List<Ataque> Ataques
    {
        get { return ataques; }
    }

    public void AddAtaque(Ataque ataque)
    {
        ataques.Add(ataque);
    }
    public void RemoveAtaque(Ataque ataque)
    {
        ataques.Remove(ataque);
    }
}