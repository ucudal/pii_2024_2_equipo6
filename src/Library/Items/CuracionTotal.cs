using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Items;

public class CuracionTotal : IItems
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno

    private string nombre = "Curacion Total";
    public void Usar(Pokemon pokemon)
    {
        pokemon.EfectoActual = null;// al usar curacion total, el efecto actual del pokemon, se anulará
    }
}