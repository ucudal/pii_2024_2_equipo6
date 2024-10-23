using NUnit.Framework;
using ProyectoPokemon;
using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

namespace Tests;

public class AtaqueEspecialTest
{
    [Test]
    public void TestAtaqueEspecial()
    {
        IEfecto paralisis = new Paralisis();
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Rompe Muros", 50, paralisis);
        Assert.That("Rompe Muros", Is.EqualTo(ataqueEspecial.Nombre));
        Assert.That(50, Is.EqualTo(ataqueEspecial.ValorAtaque));
    }
    
    [Test]
    public void TestAtaqueEspecialConstructor()
    {
        IEfecto somnolencia = new Somnolencia();
        string nombre = "Rompe Cabezas";
        int valorDelAtaque = 55;
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial(nombre, valorDelAtaque, somnolencia);
        Assert.That("Rompe Cabezas", Is.EqualTo(ataqueEspecial.Nombre));
        Assert.That(valorDelAtaque, Is.EqualTo(ataqueEspecial.ValorAtaque));
        Assert.That(somnolencia, Is.EqualTo(ataqueEspecial.Efecto));
    }

    [Test]
    public void ValorAtaqueEspecial()
    {
        IEfecto paralisis = new Paralisis();
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Patada de canguro", 50, paralisis);
        ataqueEspecial.ValorAtaque = 78;
        Assert.That(75, Is.EqualTo(ataqueEspecial.ValorAtaque));
    }

    [Test]
    public void NombreAtaqueEspecial()
    {
        IEfecto quemadura = new Quemadura();
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("ValeBlanc", 65, quemadura);
        ataqueEspecial.Nombre = "Valita";
        Assert.That("Valita", Is.EqualTo(ataqueEspecial.Nombre));
    }
}
