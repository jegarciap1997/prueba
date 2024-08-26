using Services;

// Lista de prueba para metodo xyz
var lista = new List<List<int>>
{
    new List<int>{
        23, 13, 8, 0
    },
    new List<int>{
        5, 6, 7, 8, 33, 45 ,99
    },
    new List<int>{
        3
    }
};

// Creacion de datos
// PruebaService.CrearDatos();

PruebaService.ListarDatos();


Console.WriteLine($"Resultado punto 3: {PruebaService.xyz(lista)}");