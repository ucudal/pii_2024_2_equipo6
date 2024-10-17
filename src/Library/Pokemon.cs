namespace ProyectoPokemon;

public class Pokemon
{
    private string nombre;
    private double hp;
    private Tipo tipo;
    private List<IAtaque> ataques = new List<IAtaque>();
    public List<AtaqueComun> AtaquesComunes { get; set; } = new List<AtaqueComun>(); 
    private List<AtaqueEspecial> AtaqueEspeciales { get; set; } = new List<AtaqueEspecial>();
    public Pokemon(string nombre, double hp, Tipo tipo)
    {
        this.nombre = nombre;
        this.hp = hp;
        this.tipo = tipo;
        this.AtaquesComunes = Tipo.AtaquesComunes;
        this.AtaqueEspeciales = Tipo.AtaquesEspeciales;
        this.Ataques.AddRange(AtaqueEspeciales);
        this.Ataques.AddRange(AtaquesComunes);
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