# Documentación del uso de principios/patrones SRP, Expert, Polimorfismo, LSP.

## **SRP en clase ImpresoraDePantalla.**

Decidimos utilizar la clase ImpresoraDePantalla para ir mostrando los diferentes estados de la batalla
por la pantalla (en este caso el Bot de telegram); decidimos hacerlo así en lugar de implementar esta
función en la clase Batalla ya que de hacerlo de este modo no estaríamos cumpliendo la guía de diseño 
SRP, ya que Batalla tendría más de una razón de cambio, manejaría los contadores de turnos y la forma
en que se imprime la propia batalla en el Bot.

## **Expert en clase Efectividad.**

Al implementar el método getEfectividad en Efectividad aplicamos la guía de diseño Expert, ya que le
asignamos el método a la clase que tiene la mayor cantidad de información para realizar esta acción,
es decir, efectividad tiene la tabla con todas las efectividades y es getEfectividad quien según el
tipo del atacante y el tipo del receptor devuelve que tan efectivo (multiplicador) un ataque es.

## **SRP en clase Efectividad.**

Creamos la clase Efectividad para aplicar SRP en Batalla, ya que esta última lleva los turnos (tanto
de los jugadores como de los ataques especiales) por lo que nos pareció oportuno crear la primera
clase, encargada de calcular la efectividad segun el atacante y el receptor.

## **Expert en clase Batalla.**

Esta clase es responsable de organizar los turnos y el cálculo de efectividad de los ataques.
Sabiendo esto, la convierte en la experta de la lógica del combate.

## **SRP en clase Batalla.**

La responsabilidad que tiene manejar la lógica de la batalla. Como consecuencia, no se hace
responsable de otra cosa que no sea el flujo de la batalla.

## **Expert en clase Pokemon.**

Esta es responsable de tener la información relevante del Pokémon, ya que tiene solo la información
necesaria para este; esto la convierte en la clase experta para esta información.

## **SRP en clase Pokemon.**

Como solo tiene la responsabilidad de conocer la información necesaria del Pokémon, cumple con
este principio de SOLID.

## **Expert en clase Tipo.**

Esta clase es responsable de manejar los detalles del tipo del Pokémon; sabiendo esto, podemos
decir que es la experta en gestionar estos datos, lo que cumple con este principio.

## **SRP en clase Tipo.**

Su única responsabilidad es tener los tipos del Pokemon, como no se ocupa de ninguna otra lógica
del juego, cumple con este principio, la hace sencilla y modificable.

## **Expert en clase Jugador.**

Esta clase se responsabilizia de tener la información y acciones con relación con el jugador 
(su nombre y el conjunto del Pokémon).

## **SRP en clase Jugador.**

Solo tiene una única responsabilidad, almacenar y gestionar los pokémones del jugador.

## **Expert en clase Ataque.**

Esta es responsable de gestionar los detalles de un ataque, como el nombre y valor de daño.
Esta es experta en manejar estos datos, por consiguiente, sigue el principio Expert.

**SRP en clase Ataque.**

Como su única responsabilidad es almacenar y gestionar la información relevante a un ataque, sigue 
con SRP.
