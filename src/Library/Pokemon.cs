namespace ProyectoPokemon;

public class Pokemon
{
    private string nombre;
    private double hp;
    private Tipo tipo;
    private Ataque ataque;
    private AtaqueEspecial ataqueEspecial;
    
    public Pokemon(string nombre, double hp, Tipo tipo)
    {
        this.nombre = nombre;
        this.hp = hp;
        this.tipo = tipo;
        this.ataque = tipo.Ataque;
        this.ataqueEspecial = tipo.AtaqueEspecial;
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
    
    public Ataque Ataque
    {
        get { return ataque; }
        set { ataque = value; }
    }
    public AtaqueEspecial AtaqueEspecial
    {
        get { return ataqueEspecial; }
        set { ataqueEspecial = value; }
    }
    
}