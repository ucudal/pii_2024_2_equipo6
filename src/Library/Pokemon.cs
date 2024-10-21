using System.Reflection.Metadata;
using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon;

public class Pokemon
{
    private string nombre;
    private double hp;
    private Tipo tipo;
    private List<IAtaque> ataques = new List<IAtaque>();
    public bool EstaEnvenenado { get; set; }
    public bool EstaDormido { get; set; }
    public bool EstaQuemado { get; set; }
    public  bool EstaParalizado { get; set; }
    public bool TieneEstadoEspecial { get; set; }
    public double  TurnosDormido { get; set; }
    public IEfecto EfectoActual { get; set; }
    public double VidaMaxima { get; set; }
    public List<AtaqueComun> AtaquesComunes { get; set; } = new List<AtaqueComun>(); 
    private List<AtaqueEspecial> AtaqueEspeciales { get; set; } = new List<AtaqueEspecial>();
    public Pokemon(string nombre, double hp, Tipo tipo)
    {
        this.nombre = nombre;
        this.hp =VidaMaxima ;
        this.VidaMaxima = hp;
        this.tipo = tipo;
        this.AtaquesComunes = Tipo.AtaquesComunes;
        this.AtaqueEspeciales = Tipo.AtaquesEspeciales;
        this.Ataques.AddRange(AtaqueEspeciales);
        this.Ataques.AddRange(AtaquesComunes);
        TurnosDormido = 0;
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

    public void MostrarAtaques()
    {
        foreach (var ataque in Ataques)
        {
           Console.WriteLine($"Nombre= {ataque.Nombre}/n Valor de ataque= {ataque.ValorAtaque}"); 
        }
    }
    
}