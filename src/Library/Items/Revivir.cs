using ProyectoPokemon.Interfaces;
namespace ProyectoPokemon.Items;

public class Revivir : IItems
{
    public string Nombre { get; set; }

    private string nombre = "Revivir";
    public void Usar(Pokemon pokemon)
    {
        if (pokemon.Hp <= 0)
        {
            pokemon.Hp = pokemon.VidaMaxima / 2;
        }
    }
}