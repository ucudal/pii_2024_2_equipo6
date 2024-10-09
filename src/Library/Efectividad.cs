namespace ProyectoPokemon;

public class Efectividad
{
    // Tipos: Fuego, Agua, Planta, Eléctrico, Roca, Dragón.
    
    public Dictionary<string, Dictionary<string, double>> TablaTipos = new()
    {
        {
            "Fuego",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.75 }, { "Agua", 0.5 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 0.5 },
                { "Dragon", 1.0 }
            }
        },
        {
            "Agua",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 0.75 }, { "Planta", 0.5 }, { "Electrico", 0.5 }, { "Roca", 2.0 },
                { "Dragon", 1.0 }
            }
        },
        {
            "Planta",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.5 }, { "Agua", 2.0 }, { "Planta", 0.75 }, { "Electrico", 1.0 }, { "Roca", 2.0 },
                { "Dragon", 1.0 }
            }
        },
        {
            "Electrico",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 2.0 }, { "Planta", 2.0 }, { "Electrico", 0.75 }, { "Roca", 0.5 },
                { "Dragon", 1.0 }
            }
        },
        {
            "Roca",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 0.5 }, { "Planta", 0.5 }, { "Electrico", 1.0 }, { "Roca", 0.75 },
                { "Dragon", 1.0 }
            }
        },
        {
            "Dragon",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 2.0 }
            }
        },
    };

    public double getEfectividad(Tipo atacante, Tipo receptor)
    {
        string tipoAtacante = atacante.ToString();
        string tipoReceptor = receptor.ToString();

        if (TablaTipos.ContainsKey(tipoAtacante))
        {
            var efectividades = TablaTipos[tipoAtacante];

            if (efectividades.ContainsKey(tipoReceptor))
            {
                return efectividades[tipoReceptor];
            }
        } 
        return 1.0;
    }
}