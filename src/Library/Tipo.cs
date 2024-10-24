namespace ProyectoPokemon;

public class Tipo
{
    private string nombre;
    private List<IAtaque> ataques = new List<IAtaque>();
    public List<AtaqueComun> AtaquesComunes { get; set; } = new List<AtaqueComun>();
    public List<AtaqueEspecial> AtaquesEspeciales { get; set; } = new List<AtaqueEspecial>();
    public Tipo(string Nombre, List<IAtaque> Ataques) //agrego constructor para que tipo tenga un nombre y un ataque
    {
        AgregarAtaques(Ataques);
        this.nombre = Nombre;
    }
    public string Nombre
    { 
        get
        {
            return nombre;
        }
    }

    public List<IAtaque> Ataques
    {
        get { return ataques; }
    }

    private void AgregarAtaques(List<IAtaque> ataques)
    {
        foreach (var ataque in ataques) //para cada ataque en ataques)
        {
            if (ataque is AtaqueComun ataqueComun) //verifica si es un ataque comun
            {
                AtaquesComunes.Add(ataqueComun); //se agrega 
            }
            else if (ataque is AtaqueEspecial ataqueEspecial) // sino verifica si era especial
            {
                AtaquesEspeciales.Add(ataqueEspecial); //se agrega
            }
        }

    }
    
}