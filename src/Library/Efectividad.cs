namespace ProyectoPokemon;

public class Efectividad
{
    // Tipos: Fuego, Agua, Planta, Eléctrico, Roca, Dragón, Bicho, Fantasma, Hielo,
    // Lucha, Normal, Psiquico, Tierra, Veneno, Volador, 
    
    public Dictionary<string, Dictionary<string, double>> TablaTipos = new()
    {
        {
            "Fuego",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.5 }, { "Agua", 0.5 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 0.5 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 2.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Agua",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 0.5 }, { "Planta", 0.5 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 0.5 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Planta",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.5 }, { "Agua", 1.0 }, { "Planta", 0.5 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 0.5 }, {"Bicho", 0.5}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}          }
        },
        {
            "Electrico",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 2.0 }, { "Planta", 0.5 }, { "Electrico", 0.0 }, { "Roca", 1.0 },
                { "Dragon", 0.5 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Roca",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 2.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Dragon",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 2.0 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Bicho",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.5 }, { "Agua", 1.0 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 2.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Fantasma",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 1.0}, {"Fantasma", 2.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 0.0},
                {"Pisquico", 2.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Hielo",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 0.5 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 2.0 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 0.5}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Lucha",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 0.5}, {"Fantasma", 0.5}, {"Hielo", 2.0}, {"Lucha", 1.0}, {"Normal", 2.0},
                {"Pisquico", 2.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Normal",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 1.0}, {"Fantasma", 0.5}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Pisquico",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Tierra",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 1.0 }, { "Planta", 0.5 }, { "Electrico", 2.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 0.5}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Veneno",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 0.5}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Volador",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 2.0 }, { "Electrico", 0.5 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        }
    };
    
    //queda tipo roca, tierra, veneno, volador
    
    public double getEfectividad(Tipo atacante, Tipo receptor)
    {
        if (TablaTipos.ContainsKey(atacante.Nombre))
        {
            var efectividades = TablaTipos[atacante.Nombre];

            if (efectividades.ContainsKey(receptor.Nombre))
            {
                return efectividades[receptor.Nombre];
            }
        } 
        return 1.0;
    }
}