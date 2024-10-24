namespace ProyectoPokemon;

public interface IAtaque
//Clase abstracta que representa un ataque
{
    public string Nombre { get; set; }//inicializamos el nombre, para cuando lo llamemos, tenga uno
    public int ValorAtaque { get; set; }//inicializamos el valor del ataque del pokemon
    
}