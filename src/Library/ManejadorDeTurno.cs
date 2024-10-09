namespace ProyectoPokemon;

public class ManejadorDeTurno
{
    private Jugador jugador1;
    private Jugador jugador2;
    private int contadorTurnos=0;
    private int contadorAtaqueEspecial = 0;
    public ManejadorDeTurno(Jugador j1, Jugador j2)
    {
        jugador1 = j1;
        jugador2 = j2;
        
    }

    public void SeleccionarJugadorActual()
    {
        Jugador jugadorActual;
        if (contadorTurnos == 0)
        {
            Random random = new Random();
            int Jugador = random.Next(1, 3);
            if (Jugador == 1)
            {
                jugadorActual = jugador1;
                Console.WriteLine("El jugador 1 ha sido seleccionado");

            }
            else
            {
                jugadorActual = jugador2;
                Console.WriteLine("El jugador 2 ha sido seleccionado");
            }
        }

        else
        {
            if (contadorTurnos % 2 == 0)
            {
                jugadorActual = jugador2;
                Console.WriteLine("Es el turno de el jugador 2 ");
            }
            else
            {
                jugadorActual = jugador1;
                Console.WriteLine("Es el turno del jugador 1");
            }
        }

        if (contadorAtaqueEspecial == 0)
        {
            Console.WriteLine($"{jugadorActual.Nombre} puede usar el ataque especial0");
            
        }
        else
        {
            Console.WriteLine($"{jugadorActual.Nombre} no puede usar el ataque especial");
            contadorAtaqueEspecial--;
        }

        contadorTurnos += 1;
    }
    


    public void ContadorAtaqueEspecial(Jugador jugador, AtaqueEspecial ataqueEspecial, Pokemon pokemonrival)
    {
        if (jugador.AtacarConEspecial(ataqueEspecial,pokemonrival))
        {
            Console.WriteLine($"{jugador.Nombre} usa su ataque especial.");
            contadorAtaqueEspecial = 2;
        }
    }
}