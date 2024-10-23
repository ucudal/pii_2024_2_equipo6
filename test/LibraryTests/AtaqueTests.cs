using ProyectoPokemon;

namespace Tests;
using NUnit.Framework;


public class AtaqueTests
{
    [Test]
    public void TestAtaque()
    {
        AtaqueComun ataque = new AtaqueComun("Tacleada", 40);
        Assert.That("Tacleada", Is.EqualTo(ataque.Nombre));
        Assert.That(40, Is.EqualTo(ataque.ValorAtaque));
    }
    [Test]
    public void TestAtaqueConstructor()
    {
        string nombre = "Llamarada";
        int valorataque = 100;
        AtaqueComun ataque = new AtaqueComun(nombre, valorataque);

        Assert.That(nombre, Is.EqualTo(ataque.Nombre));
        Assert.That(valorataque, Is.EqualTo(ataque.ValorAtaque));
    }

    [Test]
    public void TestValorAtaque()
    {
        AtaqueComun ataque = new AtaqueComun("Corte", 50);
        ataque.ValorAtaque = 75;
            
        Assert.That(75, Is.EqualTo(ataque.ValorAtaque));
    }

    [Test]
    public void TestNombre()
    {
        AtaqueComun ataque = new AtaqueComun("Corte", 50);
        ataque.Nombre = "Cuchillada";
            
        Assert.That("Cuchillada", Is.EqualTo(ataque.Nombre));
    }

    
}