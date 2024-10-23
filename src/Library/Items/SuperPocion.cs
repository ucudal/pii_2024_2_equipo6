using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Items;

public class SuperPocion : IItems
{
    public string Nombre { get; set; }

    private string nombre = "Super Pocion";
    public void Usar(Pokemon pokemon)
    {
        if (pokemon.Hp + 70 >= pokemon.VidaMaxima)
        {
            pokemon.Hp = pokemon.VidaMaxima;
        }
        else
        {
            pokemon.Hp += 70;
        }
    }
}