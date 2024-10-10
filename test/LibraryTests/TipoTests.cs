using NUnit.Framework;
using ProyectoPokemon;

namespace Tests;

public class TipoTests

{
    
        [Test]
        public void TestTipoConstructor()
        {
            string nombre = "Fuego";
            Ataque ataque = new Ataque("Llamarada", 100);
            AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Inferno", 120);

            Tipo tipo = new Tipo(nombre, ataque, ataqueEspecial);

            Assert.That(tipo.Nombre, Is.EqualTo(nombre));
            Assert.That(tipo.Ataque, Is.EqualTo(ataque));
            Assert.That(tipo.AtaqueEspecial, Is.EqualTo(ataqueEspecial));
        }

        [Test]
        public void TestAtaque()
        {
            Ataque ataqueInicial = new Ataque("Corte", 50);
            Ataque nuevoAtaque = new Ataque("Cuchillada", 75);
            Tipo tipo = new Tipo("Normal", ataqueInicial, new AtaqueEspecial("Poder Oculto", 60));

            tipo.Ataque = nuevoAtaque;

            Assert.That(tipo.Ataque, Is.EqualTo(nuevoAtaque));
        }

        [Test]
        public void TestAtaqueEspecial()
        {
            AtaqueEspecial ataqueEspecialInicial = new AtaqueEspecial("Chispa", 60);
            AtaqueEspecial nuevoAtaqueEspecial = new AtaqueEspecial("Rayo", 90);
            Tipo tipo = new Tipo("Eléctrico", new Ataque("Impactrueno", 40), ataqueEspecialInicial);

            tipo.AtaqueEspecial = nuevoAtaqueEspecial;

            Assert.That(tipo.AtaqueEspecial, Is.EqualTo(nuevoAtaqueEspecial));
        }
    
}

