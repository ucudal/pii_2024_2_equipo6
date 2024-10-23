using ProyectoPokemon.Efectos;
using ProyectoPokemon.Interfaces;

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
    private Random random = new Random();
    private int contadorSuperPocion = 4;
    private int contadorRevivir = 1;
    private int contadorCuraTotal = 2;
    


    public Batalla(Jugador jugador1, Jugador jugador2)
    {
        this.jugador1 = jugador1;
        this.jugador2 = jugador2;
    }

    public Jugador Jugador1
    {
        get { return jugador1; }
    }

    public Jugador Jugador2
    {
        get { return jugador2; }
    }

   

    public void Atacar(Jugador atacante, Jugador receptor, AtaqueComun ataque)
    {
        double precisionPokemon = atacante.Pokemonelegido.Precision;
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        int indiceAtaque = atacante.Pokemonelegido.Ataques.IndexOf(ataque);
        if (atacante == jugador1 && turno)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                if (random.NextDouble() <0.10)
                {

                    receptor.Pokemonelegido.Hp -= (atacante.Pokemonelegido.Ataques[indiceAtaque].ValorAtaque * efectividad) * 1.2;
                    contador1 -= 1;
                    turno = !turno;
                }
                else
                {

                    receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataques[indiceAtaque].ValorAtaque * efectividad;
                    contador1 -= 1;
                    turno = !turno;
                }

            }
            else                                                                
            {                                                                   
                Console.WriteLine("Su precision falló, turno perdido.");        
            }                                                                   
        }
        
        else if (atacante == jugador2 && !turno)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                if (random.NextDouble() <0.10)
                {
                    receptor.Pokemonelegido.Hp -= (atacante.Pokemonelegido.Ataques[indiceAtaque].ValorAtaque * efectividad) * 1.2;

                    contador2 -= 1;
                    turno = !turno;
                }
                else
                {
                    receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataques[indiceAtaque].ValorAtaque * efectividad;

                    contador2 -= 1;
                    turno = !turno;
                }

            }
            else
            {
                Console.WriteLine("Su precision falló, turno perdido.");
            }
        }
        else
        {
            Console.WriteLine("Turno equivocado");
        }


    }

    public void AtacarConEspecial(Jugador atacante, Jugador receptor, AtaqueEspecial ataqueEspecial)
    {
        atacante.Pokemonelegido.MostrarAtaques();
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        if (atacante == jugador1 && turno && contador1 <= 0)
        {
            receptor.Pokemonelegido.Hp -= ataqueEspecial.ValorAtaque * efectividad;
            contador1 = 2;
            AplicarEfectoEspecial(receptor, ataqueEspecial.Efecto);
            turno = !turno;
            //Chequeo si el pokemon que va a ser atacado, ya tenga un efecto sobre él
            if (receptor.Pokemonelegido.EfectoActual == null)
            {
                //Aplico el efecto
                AplicarEfectoEspecial(receptor, ataqueEspecial.Efecto);

            }
        }

        else if (atacante == jugador2 && !turno && contador2 <= 0)
        {
            receptor.Pokemonelegido.Hp -= ataqueEspecial.ValorAtaque * efectividad;
            contador2 = 2;
            contadorEfecto2 -= 1;
            AplicarEfectoEspecial(receptor, ataqueEspecial.Efecto );
            turno = !turno;
            //Chequeo si el pokemon que va a ser atacado, ya tenga un efecto sobre él
            if (receptor.Pokemonelegido.EfectoActual == null)
            {
                //Aplico el efecto
                AplicarEfectoEspecial(receptor, ataqueEspecial.Efecto);

            }
        }
        else
        {
            Console.WriteLine("Turno equivocado o ataque especial no disponible");
        }

    }

    private void AplicarEfectoEspecial( Jugador receptor, IEfecto efectoEspecial)
    {
        
        if (!receptor.Pokemonelegido.TieneEstadoEspecial)
        {
            receptor.Pokemonelegido.TieneEstadoEspecial = true;
            efectoEspecial.AplicarEfecto(receptor);
            receptor.Pokemonelegido.EfectoActual = efectoEspecial;
        }
        else 
        {
            Console.WriteLine($"{receptor.Pokemonelegido.Nombre} ya ha sido afectado por un ataque especial");
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

    public void ProcesarEfectosJugador(Jugador jugador, Jugador atacante, AtaqueEspecial ataqueEspecial)

    {
        double precisionPokemon = atacante.Pokemonelegido.Precision;
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, jugador.Pokemonelegido.Tipo);
        if (jugador.Pokemonelegido.TieneEstadoEspecial && jugador.Pokemonelegido.EstaDormido &&
            jugador.Pokemonelegido.TurnosDormido > 0)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                if (random.NextDouble() <0.10)
                {
                    jugador.Pokemonelegido.TurnosDormido += 0.2;
                    Console.WriteLine(
                        $"{jugador.Pokemonelegido.Nombre} esta dormido. Turnos restantes:{jugador.Pokemonelegido.TurnosDormido}");
                    jugador.Pokemonelegido.TurnosDormido--;
                    if (jugador.Pokemonelegido.TurnosDormido == 0)
                    {
                        jugador.Pokemonelegido.EstaDormido = false;
                        jugador.Pokemonelegido.TieneEstadoEspecial = false;
                        Console.WriteLine($"{jugador.Pokemonelegido.Nombre} despertó");
                    }
                }
            }
            else                                                                
            {                                                                   
                Console.WriteLine("Su precision falló, turno perdido.");        
            }                                                                   

        }
        else if (jugador.Pokemonelegido.EstaEnvenenado)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                if (random.NextDouble() <0.10)
                {
                    double danoVeneno = (ataqueEspecial.ValorAtaque * efectividad) * 1.25;
                    jugador.Pokemonelegido.Hp -= danoVeneno;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido envenenado y perdió {danoVeneno} Hp");
                }
                else
                {
                    double danoVeneno = (ataqueEspecial.ValorAtaque * efectividad) * 0.05;
                    jugador.Pokemonelegido.Hp -= danoVeneno;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido envenenado y perdió {danoVeneno} Hp");
                }

            }
            else                                                                
            {                                                                   
                Console.WriteLine("Su precision falló, turno perdido.");        
            }                                                                   
        }
        else if (jugador.Pokemonelegido.EstaQuemado)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                if (random.NextDouble() <0.10)
                {
                    double danoQuemadura = (ataqueEspecial.ValorAtaque * efectividad) * 1.30;
                    jugador.Pokemonelegido.Hp -= danoQuemadura;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido quemado y perdió {danoQuemadura} Hp");
                }
                else
                {
                    double danoQuemadura = (ataqueEspecial.ValorAtaque * efectividad) * 0.10;
                    jugador.Pokemonelegido.Hp -= danoQuemadura;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido quemado y perdió {danoQuemadura} Hp");

                }
            }
            else                                                                
            {                                                                   
                Console.WriteLine("Su precision falló, turno perdido.");        
            }                                                                   
        }
        //Revisar EstaParalizado
        else if (jugador.Pokemonelegido.EstaParalizado)
        {
            if (random.NextDouble() * 100 <=precisionPokemon)
            {
                turno = false;
                Console.WriteLine($"{jugador.Pokemonelegido.Nombre} esta paralizado y no puede atacar"); 
              
            }
            else
            {
                if (random.NextDouble() <0.10)
                {
                    double danoParalisis = (ataqueEspecial.ValorAtaque * efectividad) * 1.20;
                    atacante.Pokemonelegido.Hp -= danoParalisis;
                    Console.WriteLine(
                        $"{atacante.Pokemonelegido.Nombre}, ha sido atacado por {jugador.Pokemonelegido.Nombre}");
                }

                else
                
                {
                    double danoParalisis = (ataqueEspecial.ValorAtaque * efectividad);
                    atacante.Pokemonelegido.Hp -= danoParalisis;                                                    
                    Console.WriteLine($"{atacante.Pokemonelegido.Nombre}, ha sido atacado por {jugador.Pokemonelegido.Nombre}");  
                    
                }

            }

        }
    }


   /* public void Turno()
    {
        ProcesarEfectosJugador(jugador1,jugador2);
        ProcesarEfectosJugador(jugador2,jugador1);
    }
    */

   public bool UtilizarItems(Jugador jugador, IItems items)
   {
       if (jugador.Pokemonelegido != null)
       {
           items.Usar(jugador.Pokemonelegido);
           return true;
       }
       else
       {
           return false;
       }
   }
}
