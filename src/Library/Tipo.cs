namespace ProyectoPokemon;

public class Tipo
{
    private string nombre;
    private List<IAtaque> ataques = new List<IAtaque>();
    public List<AtaqueComun> AtaquesComunes { get; set; } = new List<AtaqueComun>();
    public List<AtaqueEspecial> AtaquesEspeciales { get; set; } = new List<AtaqueEspecial>();
    public Tipo(string Nombre, List<IAtaque> Ataques)
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
        foreach (var ataque in ataques)
        {
            if (ataque is AtaqueComun ataqueComun)
            {
                AtaquesComunes.Add(ataqueComun);
            }
            else if (ataque is AtaqueEspecial ataqueEspecial)
            {
                AtaquesEspeciales.Add(ataqueEspecial);
            }
        }

    }
    
}