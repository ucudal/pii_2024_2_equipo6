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

    public void Atacar(Jugador atacante, Jugador receptor)
    {
        atacante.Pokemonelegido.MostrarAtaques();
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        if (atacante == jugador1 && turno)
        {
            if (random.NextDouble() * 100 > 49)
            {
                if (random.NextDouble() * 100 > 9)
                {

                    receptor.Pokemonelegido.Hp -= (atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad) * 0.2;
                    contador1 -= 1;
                    turno = !turno;
                }
                else
                {

                    receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad;
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
            if (random.NextDouble() * 100 > 49)
            {
                if (random.NextDouble() * 100 > 9)
                {
                    receptor.Pokemonelegido.Hp -= (atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad) * 0.20;

                    contador2 -= 1;
                    turno = !turno;
                }
                else
                {
                    receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.Ataque.ValorAtaque * efectividad;

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

    public void AtacarConEspecial(Jugador atacante, Jugador receptor)
    {
        atacante.Pokemonelegido.MostrarAtaques();
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, receptor.Pokemonelegido.Tipo);
        if (atacante == jugador1 && turno && contador1 <= 0)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad;
            contador1 = 2;
            contadorEfecto1 -= 1;
            AplicarEfectoEspecial(receptor, atacante.Pokemonelegido.AtaqueEspecial.Efecto);
            turno = !turno;
            //Chequeo si pasaron los turnos necesarios para poder aplicar el efecto
            if (contadorEfecto1 <= 0)
            {
                //Aplico el efecto  y reseteo el contador de efecto    
                contadorEfecto1 = atacante.Pokemonelegido.AtaqueEspecial.Efecto.contador;
                AplicarEfectoEspecial(receptor, atacante.Pokemonelegido.AtaqueEspecial.Efecto);

            }
        }

        else if (atacante == jugador2 && !turno && contador2 <= 0)
        {
            receptor.Pokemonelegido.Hp -= atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad;
            contador2 = 2;
            contadorEfecto2 -= 1;
            AplicarEfectoEspecial(receptor, atacante.Pokemonelegido.AtaqueEspecial.Efecto );
            turno = !turno;
            //Chequeo si pasaron los turnos necesarios para poder aplicar el efecto
            if (contadorEfecto2 <= 0)
            {
                //Aplico el efecto  y reseteo el contador de efecto
                contadorEfecto2 = atacante.Pokemonelegido.AtaqueEspecial.Efecto.contador;
                AplicarEfectoEspecial(receptor, atacante.Pokemonelegido.AtaqueEspecial.Efecto);
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

    public void ProcesarEfectosJugador(Jugador jugador, Jugador atacante)

    {
        Efectividad efec = new Efectividad();
        double efectividad = efec.getEfectividad(atacante.Pokemonelegido.Tipo, jugador.Pokemonelegido.Tipo);
        if (jugador.Pokemonelegido.TieneEstadoEspecial && jugador.Pokemonelegido.EstaDormido &&
            jugador.Pokemonelegido.TurnosDormido > 0)
        {
            if (random.NextDouble() * 100 > 49)
            {
                if (random.NextDouble() * 100 > 9)
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
            if (random.NextDouble() * 100 > 49)
            {
                if (random.NextDouble() * 100 > 9)
                {
                    double danoVeneno = (atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad) * 0.25;
                    jugador.Pokemonelegido.Hp -= danoVeneno;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido envenenado y perdió {danoVeneno} Hp");
                }
                else
                {
                    double danoVeneno = (atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad) * 0.05;
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
            if (random.NextDouble() * 100 > 49)
            {
                if (random.NextDouble() * 100 > 9)
                {
                    double danoQuemadura = (atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad) * 0.30;
                    jugador.Pokemonelegido.Hp -= danoQuemadura;
                    Console.WriteLine($"{jugador.Pokemonelegido.Nombre} ha sido quemado y perdió {danoQuemadura} Hp");
                }
                else
                {
                    double danoQuemadura = (atacante.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad) * 0.10;
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
            if (random.NextDouble() * 100 > 49)
            {
                turno = false;
                Console.WriteLine($"{jugador.Pokemonelegido.Nombre} esta paralizado y no puede atacar"); 
              
            }
            else
            {
                if (random.NextDouble() * 100 > 9)
                {
                    double danoParalisis = (jugador.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad) * 0.20;
                    atacante.Pokemonelegido.Hp -= danoParalisis;
                    Console.WriteLine(
                        $"{atacante.Pokemonelegido.Nombre}, ha sido atacado por {jugador.Pokemonelegido.Nombre}");
                }

                else
                
                {
                    double danoParalisis = (jugador.Pokemonelegido.AtaqueEspecial.ValorAtaque * efectividad);
                    atacante.Pokemonelegido.Hp -= danoParalisis;                                                    
                    Console.WriteLine($"{atacante.Pokemonelegido.Nombre}, ha sido atacado por {jugador.Pokemonelegido.Nombre}");  
                    
                }

            }

        }
    }


    public void Turno()
    {
        ProcesarEfectosJugador(jugador1,jugador2);
        ProcesarEfectosJugador(jugador2,jugador1);
    }

   public bool UtilizarItems(Jugador jugador)
   {
       Console.WriteLine($"DESEA USAR ALGUNO DE ESTOS ITEMS PARA{jugador.Pokemonelegido.Nombre}, su Hp es: {jugador.Pokemonelegido.Hp}:");       
       Console.WriteLine("");                                                                                                                    
       Console.WriteLine("1:SuperPocion:Recupera 70 puntos de HP");                                                                              
       Console.WriteLine("");                                                                                                                    
       Console.WriteLine("2.Revivir:Revive un Pokmeon con el 50% de su HP total");                                                               
       Console.WriteLine("");                                                                                                                    
       Console.WriteLine("3.CuraTotal:Cura a un pokemones");
       Console.WriteLine(
           "Si desea usar alguno de estos items, solo presione su numero correspondiente, de lo contrario, escriba NO:");
       string respuesta = Console.ReadLine();
       while (respuesta.ToUpper() != "NO")
       {
           if (respuesta == "1")
           {
               if (contadorSuperPocion > 0)
               {
                   jugador.Pokemonelegido.Hp += 70;
                   if (jugador.Pokemonelegido.Hp > jugador.Pokemonelegido.VidaMaxima)
                   {
                       jugador.Pokemonelegido.Hp = jugador.Pokemonelegido.VidaMaxima;
                   }
                   contadorSuperPocion--;
                   turno = false;
                   Console.WriteLine(                                                                                                                                
                       $"Se recupero 70 puntos de la vida de {jugador.Pokemonelegido.Nombre}, podrá usar en adelante la SuperPocion: {contadorSuperPocion} veces");  
               }
               else
               {
                   Console.WriteLine(
                       "No puede usar SuperPocion ya que agotó las posibilidades, porfavor intente de nuevo ");
               }

           }

           else if (respuesta == "2")
           {
               if (contadorRevivir > 0)
               {
                   if (jugador.Pokemonelegido.Hp == 0)
                   {
                       jugador.Pokemonelegido.Hp = jugador.Pokemonelegido.Hp * 0.50;
                       if (jugador.Pokemonelegido.Hp > jugador.Pokemonelegido.VidaMaxima)
                       {
                           jugador.Pokemonelegido.Hp = jugador.Pokemonelegido.VidaMaxima;
                       }
                       contadorRevivir--;
                       turno = false;
                       Console.WriteLine(                                                                                                                        
                           $"Aumento la vida de {jugador.Pokemonelegido.Nombre} un 50%, ahora tendrá {contadorRevivir} veces para usar el Revivir. "); 
                   }
                   else
                   {
                       Console.WriteLine("No puede usarlo, no tiene pokemones debilitados.");
                   }
                             
               }
               else
               {
                   Console.WriteLine(
                       "No puede usar Revivir ya que agotó las posibilidades, porfavor intente de nuevo ");

               }
           }

           if (respuesta == "3")
           {
               if (contadorCuraTotal > 0)
               {
                   jugador.Pokemonelegido.EstaDormido = false;
                   jugador.Pokemonelegido.EstaEnvenenado = false;
                   jugador.Pokemonelegido.TurnosDormido = 0;
                   jugador.Pokemonelegido.EstaParalizado = false;
                   jugador.Pokemonelegido.EstaQuemado = false;
                   contadorCuraTotal--;
                   turno = false;
                   Console.WriteLine(
                       $"Su pokemon se curo de: {jugador.Pokemonelegido.EfectoActual}, ahora tendra {contadorCuraTotal} veces para usar la Cura Total.");
               }
               else
               {
                   Console.WriteLine(
                       "No puede usar Cura Total ya que agotó las posibilidades, porfavor intente de nuevo.");
               }
           }
           else
           {
               Console.WriteLine("Caracter no valido, intente de nuevo.");
           }

           if (!turno)
           {
               return false;
           }

           Console.WriteLine(
               $"DESEA USAR ALGUNO DE ESTOS ITEMS PARA{jugador.Pokemonelegido.Nombre}, su Hp es: {jugador.Pokemonelegido.Hp}");
           respuesta = Console.ReadLine();
       }

       return true;
   }                                                                                                                                         
       

}
