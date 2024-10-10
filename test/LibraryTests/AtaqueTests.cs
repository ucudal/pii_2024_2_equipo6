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
        Assert.That("Tacleada", Is.EqualTo(ataque.Nombre));
        Assert.That(40, Is.EqualTo(ataque.ValorAtaque));
    }
    [Test]
    public void TestAtaqueConstructor()
    {
        string nombre = "Llamarada";
        int valorataque = 100;
        Ataque ataque = new Ataque(nombre, valorataque);

        Assert.That(nombre, Is.EqualTo(ataque.Nombre));
        Assert.That(valorataque, Is.EqualTo(ataque.ValorAtaque));
    }

    [Test]
    public void TestValorAtaque()
    {
        Ataque ataque = new Ataque("Corte", 50);
        ataque.ValorAtaque = 75;
            
        Assert.That(75, Is.EqualTo(ataque.ValorAtaque));
    }

    [Test]
    public void TestNombre()
    {
        Ataque ataque = new Ataque("Corte", 50);
        ataque.Nombre = "Cuchillada";
            
        Assert.That("Cuchillada", Is.EqualTo(ataque.Nombre));
    }

    
}