namespace ProyectoPokemon;

public class Efectividad
{
    // Tipos: Fuego, Agua, Planta, Eléctrico, Roca, Dragón, Bicho, Fantasma, Hielo,
    // Lucha, Normal, Psiquico, Tierra, Veneno, Volador, 
    
    public static Dictionary<string, Dictionary<string, double>> TablaTipos = new()
    {
        {
            "Fuego", //tipo
            new Dictionary<string, double>() //efectividad contra otros tipos
            {
                { "Fuego", 0.5 }, { "Agua", 0.5 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 0.5 },
                { "Dragon", 0.5 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 2.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Agua",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 0.5 }, { "Planta", 0.5 }, { "Electrico", 1.0 }, { "Roca", 2.0 },
                { "Dragon", 0.5 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 2.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        },
        {
            "Planta",
            new Dictionary<string, double>()
            {
                { "Fuego", 0.5 }, { "Agua", 1.0 }, { "Planta", 0.5 }, { "Electrico", 1.0 }, { "Roca", 2.0 },
                { "Dragon", 0.5 }, {"Bicho", 0.5}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 2.0}, {"Veneno", 0.5}, {"Volador", 0.5}
                
            }
        },
        {
            "Electrico",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 2.0 }, { "Planta", 0.5 }, { "Electrico", 0.0 }, { "Roca", 1.0 },
                { "Dragon", 0.5 }, {"Bicho", 1.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 0.5}, {"Veneno", 1.0}, {"Volador", 2.0}
            }
        },
        {
            "Roca",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 1.0 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 2.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 2.0}, {"Veneno", 1.0}, {"Volador", 2.0}
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
                {"Pisquico", 2.0}, {"Tierra", 1.0}, {"Veneno", 2.0}, {"Volador", 0.5}
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
                {"Pisquico", 1.0}, {"Tierra", 2.0}, {"Veneno", 1.0}, {"Volador", 2.0}
            }
        },
        {
            "Lucha",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 2.0 },
                { "Dragon", 1.0 }, {"Bicho", 0.5}, {"Fantasma", 0.5}, {"Hielo", 2.0}, {"Lucha", 1.0}, {"Normal", 2.0},
                {"Pisquico", 2.0}, {"Tierra", 1.0}, {"Veneno", 2.0}, {"Volador", 0.5}
            }
        },
        {
            "Normal",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 1.0 }, { "Electrico", 1.0 }, { "Roca", 0.5 },
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
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 2.0}, {"Volador", 1.0}
            }
        },
        {
            "Tierra",
            new Dictionary<string, double>()
            {
                { "Fuego", 2.0 }, { "Agua", 1.0 }, { "Planta", 0.5 }, { "Electrico", 2.0 }, { "Roca", 2.0 },
                { "Dragon", 1.0 }, {"Bicho", 0.5}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 2.0}, {"Volador", 0.5}
            }
        },
        {
            "Veneno",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 2.0 }, { "Electrico", 1.0 }, { "Roca", 0.5 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 0.5}, {"Hielo", 1.0}, {"Lucha", 1.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 2.0}, {"Veneno", 0.5}, {"Volador", 1.0}
            }
        },
        {
            "Volador",
            new Dictionary<string, double>()
            {
                { "Fuego", 1.0 }, { "Agua", 1.0 }, { "Planta", 2.0 }, { "Electrico", 0.5 }, { "Roca", 0.5 },
                { "Dragon", 1.0 }, {"Bicho", 2.0}, {"Fantasma", 1.0}, {"Hielo", 1.0}, {"Lucha", 2.0}, {"Normal", 1.0},
                {"Pisquico", 1.0}, {"Tierra", 1.0}, {"Veneno", 1.0}, {"Volador", 1.0}
            }
        }
    };
    
    public static double getEfectividad(Tipo atacante, Tipo receptor)
    {
        if (TablaTipos.ContainsKey(atacante.Nombre)) //si el tipo atacante esta en la tabla tipos
        {
            var efectividades = TablaTipos[atacante.Nombre];//obtiene el diccionario de efectividades del tipo

            if (efectividades.ContainsKey(receptor.Nombre)) //verifica si el receptor está en las efectividades del atacante
            {
                return efectividades[receptor.Nombre]; //devuelve el valor correspondiente
            }
        } 
        return 1.0; //sino se encuentra, devuelve 1.0, efectividad normal.
    }
}