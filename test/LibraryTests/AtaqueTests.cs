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

    
}