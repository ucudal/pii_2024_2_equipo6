namespace ProyectoPokemon;

public class Batalla
{
    private bool turno = true;
    private int contador1 = 2;
    private int contador2 = 2;
    private Jugador jugador1;
    private Jugador jugador2;
    private int contadorEfecto1 = 0;
    private int contadorEfecto2 = 0;
    

    public Batalla(Jugador jugador1, Jugador jugador2)
    {
        this.jugador1 = jugador1;
        this.jugador2 = jugador2;
    }

    public Jugador Jugador1
    {
        get {return jugador1;}
    }
    public Jugador Jugador2
    {
        get {return jugador2;}
    }
    public void Atacar( Jugador atacante, Jugador receptor)
    {
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        if (atacante == jugador1 && turno)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad;
            contador1 -= 1;
            turno = !turno;
        }

        else if (atacante == jugador2 && !turno)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad;
            contador2 -= 1;
            turno = !turno;
        }
        else
        {
            Console.WriteLine("Turno equivocado");
        }


    }

    public void AtacarConEspecial(Jugador atacante, Jugador receptor)
    {
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        if (atacante == jugador1 && turno && contador1 <= 0)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad;
            contador1 = 2;
            contadorEfecto1 -= 1;
            turno = !turno;
            //Chequeo si pasaron los turnos necesarios para poder aplicar el efecto
            if (contadorEfecto1 <= 0)
            {
            //Aplico el efecto  y reseteo el contador de efecto    
                contadorEfecto1 = atacante.Pokemonelegido.AtaqueEspecial.Efecto.contador;
                
            } 
        }

        else if (atacante == jugador2 && !turno && contador2 <= 0)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad;
            contador2 = 2;
            contadorEfecto2 -= 1;
            turno = !turno;
            //Chequeo si pasaron los turnos necesarios para poder aplicar el efecto
            if (contadorEfecto2 <= 0)
            { 
                //Aplico el efecto  y reseteo el contador de efecto
                contadorEfecto2 = atacante.Pokemonelegido.AtaqueEspecial.Efecto.contador;
            }
        }
        else
        {
            Console.WriteLine("Turno equivocado o ataque especial no disponible");
        }
      
    }
    public void CambiarPokemon(Jugador jugador, Pokemon pokemon)
    {
        // Chequear si el pokemon esta en la lista del jugador (A implementar)
        if (jugador == jugador1 && turno)
        {
            contador1 -= 1;
            jugador.Pokemonelegido = pokemon;
        }


        if (jugador == jugador2 && !turno)
        {
            contador2 -= 1;
            jugador.Pokemonelegido = pokemon;
        }
            
        
    }
}
