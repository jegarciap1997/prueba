
using Microsoft.EntityFrameworkCore;
using Contexts;
using Models;

namespace Services;

public class PruebaService
{

    /*

        Faltaba ; al final de la variable sumS
        no se esta controlando la longitud de los arreglos, esto puede llevar a un desbordamiento, o referencia a posicion nula

        ciclos anidados primer ciclo recorre la lista partiendo de su longitud,
        segundo clico hace referencia a los valores de cada una de las listas (este ciclo se itera segun el la longitud de la lista que llega como argumento)

        sumaP solo tomara su valor sumado por la posicion de la lista cuando el index i sea igual a j osea que se cumplira solo una vez dentro de cada iteración si no ocurre un desbordamiento

        sumaS solo tomara su valor sumado por la posicion de la lista cuando el resultado de la longitud de la lista - 1 - indice i sea igual a la posición actual del ciclo con la 
        variable j

        al final se devuelve el valor absoluto de la resta de las variables sumaP - sumaS

        listas de diferentes longitudes producen error

        Se agrega validacion para controlar la longitud de la lista a iterar y no permitir desbordamientos

    */

    public static int xyz(List<List<int>> arr)
    {
        int sumP = 0;
        int sumS = 0;

        for (int i = 0; i < arr.Count; i++)
            for (int j = 0; j < arr.Count; j++)
            {
                int longitudLista = arr[i].Count - 1;

                if (j <= longitudLista)
                {
                    if (i == j)
                    {
                        if (j <= arr[i].Count - 1)
                            sumP += (arr[i][j]);
                    }
                    if (((arr.Count - 1) - i) == j)
                    {
                        sumS += (arr[i][j]);
                    }
                }

            }

        return Math.Abs(sumP - sumS);
    }

    public static void CrearDatos()
    {
        using (var context = new PruebaContext())
        {
            context.Database.EnsureCreated();

            var ciudad = new Ciudades
            {
                CiudadId = Guid.NewGuid(),
                Nombre = "Bogota"
            };

            context.Ciudades.Add(ciudad);
            context.SaveChanges();

            var autor = new AutorLibro
            {
                AutorId = Guid.NewGuid(),
                Nombre = "Garcia Marquez",
                CiudadId = ciudad.CiudadId
            };

            context.AutorLibro.Add(autor);
            context.SaveChanges();

            var libro = new Libro
            {
                LibroId = Guid.NewGuid(),
                Nombre = "Cien años de soledad",
                AnioPublicacion = DateTime.Now,
                AutorId = autor.AutorId
            };

            context.Libro.Add(libro);
            context.SaveChanges();
            
        }
    }

    public static void ListarDatos()
    {
        using (var context = new PruebaContext())
        {

            context.Database.EnsureCreated();

            Console.WriteLine("Ciudades:");
            var ciudades = context.Ciudades.ToList();

            foreach (var ciudad in ciudades)
            {
                Console.WriteLine($"CiudadId: {ciudad.CiudadId}, Nombre: {ciudad.Nombre}");
            }

            Console.WriteLine("\nAutores:");
            var autores = context.AutorLibro.Include(a => a.Ciudad).ToList();

            foreach (var autor in autores)
            {
                Console.WriteLine($"AutorId: {autor.AutorId}, Nombre: {autor.Nombre}, Ciudad: {autor.Ciudad?.Nombre}");
            }

            Console.WriteLine("\nLibros:");

            var libros = context.Libro.Include(l => l.Autor).ToList();

            foreach (var libro in libros)
            {
                Console.WriteLine($"LibroId: {libro.LibroId}, Nombre: {libro.Nombre}, Año de Publicación: {libro.AnioPublicacion}, Autor: {libro.Autor?.Nombre}");
            }
        }
    }


}