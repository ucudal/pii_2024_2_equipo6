using NUnit.Framework;
using ProyectoPokemon;
using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

namespace Tests;

public class TipoTests

{
    
        [Test]
        public void TestTipoConstructor()
        {
            string nombre = "Fuego";
            IEfecto quemadura = new Quemadura();
            AtaqueComun ataque = new AtaqueComun("Llamarada", 100);
            AtaqueEspecial ataqueEspecial = new AtaqueEspecial("Inferno", 120, quemadura);
            List<IAtaque> ataques = new List<IAtaque>();

            Tipo tipo = new Tipo(nombre, ataques);

            Assert.That(tipo.Nombre, Is.EqualTo(nombre));
            Assert.That(tipo.AtaquesComunes[0], Is.EqualTo(ataque));
            Assert.That(tipo.AtaquesEspeciales[1], Is.EqualTo(ataqueEspecial));
        }

        [Test]
        public void TestAtaque()
        {
            IEfecto somnolencia = new Somnolencia();
            AtaqueComun ataqueInicial = new AtaqueComun("Corte", 50);
            AtaqueComun nuevoAtaque = new AtaqueComun("Cuchillada", 75);
            Tipo tipo = new Tipo("Normal", [ataqueInicial, new AtaqueEspecial("Poder Oculto", 60, somnolencia)]);

            tipo.Ataques[0] = nuevoAtaque;

            Assert.That(tipo.Ataques[0], Is.EqualTo(nuevoAtaque));
        }

        [Test]
        public void TestAtaqueEspecial()
        {
            IEfecto quemadura = new Quemadura();
            IEfecto veneno = new Veneno();
            AtaqueEspecial ataqueEspecialInicial = new AtaqueEspecial("Chispa", 60, quemadura);
            AtaqueEspecial nuevoAtaqueEspecial = new AtaqueEspecial("Rayo", 90, veneno);
            Tipo tipo = new Tipo("Eléctrico", [new AtaqueComun("Impactrueno", 40), ataqueEspecialInicial]);

            tipo.Ataques[1] = nuevoAtaqueEspecial;

            Assert.That(tipo.Ataques[1], Is.EqualTo(nuevoAtaqueEspecial));
        }
    
}

