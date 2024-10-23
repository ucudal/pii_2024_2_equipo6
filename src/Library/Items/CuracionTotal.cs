using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Items;

public class CuracionTotal : IItems
{
    public string Nombre { get; set; }

    private string nombre = "Curacion Total";
    public void Usar(Pokemon pokemon)
    {
        pokemon.EfectoActual = null;
    }
}