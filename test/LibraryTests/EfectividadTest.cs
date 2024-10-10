using NUnit.Framework;
using ProyectoPokemon;

namespace Tests;

public class EfectividadTest
{
    [Test]
    public void ObtenerEficiencia()
    {
        Tipo tipoAgua = new Tipo("Agua", new Ataque("Pistola Agua", 20), new AtaqueEspecial("Hidrobomba", 120));
        Tipo tipoPlanta = new Tipo("Planta", new Ataque("Látigo Cepa", 20), new AtaqueEspecial("Gigadrenado", 130));
        Tipo tipoFuego = new Tipo("Fuego", new Ataque("Ascuas", 10), new AtaqueEspecial("Lanzallamas", 140));
        Tipo tipoDragon = new Tipo("Dragón", new Ataque("Cola dragón", 20), new AtaqueEspecial("Cometa draco", 150));

        Efectividad efectividad = new Efectividad();

        Assert.That(efectividad.getEfectividad(tipoAgua, tipoPlanta), Is.EqualTo(0.5));
        Assert.That(efectividad.getEfectividad(tipoAgua, tipoFuego), Is.EqualTo(2.0));
        Assert.That(efectividad.getEfectividad(tipoAgua, tipoDragon), Is.EqualTo(1.0));
        Assert.That(efectividad.getEfectividad(tipoAgua, tipoAgua), Is.EqualTo(0.75));
    }
}