using ProyectoPokemon.Interfaces;

namespace ProyectoPokemon.Items;

public class SuperPocion : IItems
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno

    private string nombre = "Super Pocion";
    public void Usar(Pokemon pokemon)
    {
        if (pokemon.Hp + 70 >= pokemon.VidaMaxima) //verifica si al sumar 70 puntos de vida al pokemon, supera la vida original
        {
            pokemon.Hp = pokemon.VidaMaxima; //si pasa, la vida actual será igual a la  original(VidaMaxima)
        }
        else
        {
            pokemon.Hp += 70; //sino pasa, solo sumamos 70 puntos a la vida del pokemon
        }
    }
}