namespace ProyectoPokemon.Interfaces;

public interface IItems
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno
    public void Usar(Pokemon pokemon);//usar este metodo aplica el item al pokemon elegido
}