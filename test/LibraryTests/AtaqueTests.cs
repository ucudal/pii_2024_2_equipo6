using ProyectoPokemon;

namespace Tests;
using ClassLibrary;
using NUnit.Framework;

public class AtaqueTests
{
    [Test]
    public void TestAtaque()
    {
        Ataque ataque = new Ataque("Tacleada", 40);
        Assert.Equals("Tacleada", ataque.Nombre);
        Assert.Equals(40, ataque.ValorAtaque);
    }
    [Test]
    public void TestAtaqueConstructor()
    {
        string nombre = "Llamarada";
        int valorataque = 100;
        Ataque ataque = new Ataque(nombre, valorataque);

        Assert.Equals(nombre, ataque.Nombre);
        Assert.Equals(valorataque, ataque.ValorAtaque);
    }

    [Test]
    public void TestValorAtaque()
    {
        Ataque ataque = new Ataque("Corte", 50);
        ataque.ValorAtaque = 75;
            
        Assert.Equals(75, ataque.ValorAtaque);
    }

    [Test]
    public void TestNombre()
    {
        Ataque ataque = new Ataque("Corte", 50);
        ataque.Nombre = "Cuchillada";
            
        Assert.Equals("Cuchillada", ataque.Nombre);
    }

    
}