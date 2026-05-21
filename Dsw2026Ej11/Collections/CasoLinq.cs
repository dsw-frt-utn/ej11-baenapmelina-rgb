using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    //Fuente de Datos
    List<Libro> listaLibros = Libro.CrearLista();

    //1. Obtener el primer libro (GetPrimero)
    public void GetPrimero()
    {
        var primerLibro = listaLibros.FirstOrDefault();

        Console.WriteLine($"Primer libro: {primerLibro?.Titulo}\n");
    }

    //2. Obtener el último libro (GetUltimo)

    public void GetUltimo()
    {
        var ultimoLibro = listaLibros.LastOrDefault();
        Console.WriteLine($"Ultimo libro: {ultimoLibro?.Titulo}\n");
    }

    //3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios()
    {
        decimal total = listaLibros.Sum(lib => lib.Precio);
        return total;
    }

    //4. Obtener el promedio de precios (GetPromedioPrecios)

    public decimal GetPromedioPrecios()
    {
        decimal totalPrecios = GetTotalPrecios();

        int numeroLibros = listaLibros.Count();

        decimal promedio = 0;

        promedio = totalPrecios / numeroLibros;

        return promedio;
    }

    // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)

    public void GetListById()
    {
        IEnumerable<Libro> listaId = from lib in listaLibros
                                     where lib.Id > 15 select lib;
        foreach(Libro lib in listaId)
        {
            Console.WriteLine($"{lib.Id} - {lib.Titulo}");
        }
    }
    //6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        CultureInfo argentina = new CultureInfo("es-AR");

        return listaLibros
                .Select(l => $"{l.Titulo} - {l.Precio.ToString("C", argentina)}")
                .ToList();

    }



    // 7. Obtener el libro con el precio más alto (GetMayorPrecio)

    public void GetMayorPrecio()
    {
       decimal mayorPrecio = listaLibros.Max(lib => lib.Precio);
        var libroMasCaro = listaLibros.FirstOrDefault(lib => lib.Precio == mayorPrecio);
        Console.WriteLine($"El libro con el precio más alto es: {libroMasCaro?.Titulo} - ${libroMasCaro?.Precio}\n");
    }

    //8. Obtener el libro con el precio más bajo (GetMenorPrecio)

    public void GetMenorPrecio()
    {
        decimal precioMin = (from lib in listaLibros select lib.Precio).Min();
        var libroMasBarato = listaLibros.FirstOrDefault(lib => lib.Precio == precioMin);
        Console.WriteLine($"El libro con el precio más enocómico es: {libroMasBarato?.Titulo} - ${libroMasBarato?.Precio}\n");
    }  
    //9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)

    public IEnumerable<Libro> GetMayorPromedio()
    {
        decimal prom = GetPromedioPrecios();

        IEnumerable<Libro> librosMayorProm = from lib in listaLibros where (lib.Precio > prom) select lib;

        return librosMayorProm;
    }
    //10. Obtener los libros ordenados por título de forma descendente
    public void getLibrosOrdenados()
    {
        IEnumerable<Libro> librosOrdenados = from lib in listaLibros orderby lib.Titulo descending select lib;

        foreach (Libro libro in librosOrdenados)
        {
            Console.WriteLine($"Libro: {libro.Titulo} - Precio: {libro.Precio}");
        }
    }
}
