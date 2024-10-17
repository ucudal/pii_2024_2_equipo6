namespace ProyectoPokemon;

public class Pokemon
{
    private string nombre;
    private double hp;
    private Tipo tipo;
    private List<IAtaque> ataques = new List<IAtaque>();
    private List<AtaqueComun> AtaquesComunes = new List<AtaqueComun>();
    private List<AtaqueEspecial> AtaqueEspeciales = new List<AtaqueEspecial>();
    public Pokemon(string nombre, double hp, Tipo tipo)
    {
        this.nombre = nombre;
        this.hp = hp;
        this.tipo = tipo;
        this.ataquesComunes = Tipo.AtaquesComunes;
        this.ataqueEspeciales = Tipo.AtaquesEspeciales;
        this.Ataques.Add(AtaqueEspeciales[0]);
        this.Ataques.Add(AtaquesComunes[0]);
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
    
    public List<IAtaque> Ataques
    {
        get { return ataques; }
        set { ataques = value; }
    }
    
    
}