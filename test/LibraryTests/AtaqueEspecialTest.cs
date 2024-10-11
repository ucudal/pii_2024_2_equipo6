using NUnit.Framework;
using ProyectoPokemon;

namespace Tests;

public class AtaqueEspecialTest
{
    [Test]
    public void TestAtaqueEspecial()
    {
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Rompe Muros", 50);
        Assert.That("Rompe Muros", Is.EqualTo(ataqueEspecial.Nombre));
        Assert.That(50, Is.EqualTo(ataqueEspecial.ValorAtaqueEspecial));
    }
    
    [Test]
    public void TestAtaqueEspecialConstructor()
    {
        string nombre = "Rompe Cabezas";
        int valorDelAtaque = 55;
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial(nombre, valorDelAtaque);
    }

    [Test]
    public void ValorAtaqueEspecial()
    {
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Patada de canguro", 50);
        ataqueEspecial.ValorAtaqueEspecial = 78;
        Assert.That(75, Is.EqualTo(ataqueEspecial.ValorAtaqueEspecial));
    }

    [Test]
    public void NombreAtaqueEspecial()
    {
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial("ValeBlanc", 65);
        ataqueEspecial.Nombre = "Valita";
        Assert.That("Valita", Is.EqualTo(ataqueEspecial.Nombre));
    }
}
