using ProyectoPokemon.Interfaces;
namespace ProyectoPokemon.Items;

public class Revivir : IItems
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno

    private string nombre = "Revivir";
    public void Usar(Pokemon pokemon)
    {
        if (pokemon.Hp <= 0)//si esta muerto el pokemon
        {
            pokemon.Hp = pokemon.VidaMaxima / 2; //recargamos la vida del pokemon a su 50% de la vida original
        }
    }
}