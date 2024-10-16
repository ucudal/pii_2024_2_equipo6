namespace ProyectoPokemon;

public class Pokemon
{
    private string nombre;
    private double hp;
    private Tipo tipo;
    private List<Ataque> ataques;
    
    public Pokemon(string nombre, double hp, Tipo tipo)
    {
        this.nombre = nombre;
        this.hp = hp;
        this.tipo = tipo;
        this.ataques = tipo.Ataques;
    }
    
    public string Nombre
    {
        get { return nombre; }
    }

    public double Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public Tipo Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
    
    public List<Ataque> Ataques
    {
        get { return ataques; }
        set { ataques = value; }
    }
    
    
}