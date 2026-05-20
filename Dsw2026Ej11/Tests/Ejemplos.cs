using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Alumno alu1 = new Alumno(601, "Paula Lopez", 8.20);
        Alumno alu2 = new Alumno(602, "Pedro Ortiz", 6.55);
        Alumno alu3 = new Alumno(603, "Mariana Esposito",7.12 );

        CasoList listaAlumnos = new CasoList();

        //Agregar 3 alumnos a la lista
        listaAlumnos.AgregarAlumnos(alu1);
        listaAlumnos.AgregarAlumnos(alu2);
        listaAlumnos.AgregarAlumnos(alu3);

        //Listar por consola los alumnos
        Console.WriteLine("== Listado de Alumnos ==");
        var alumnos = listaAlumnos.MostrarAlumnos();

        foreach(var alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine();
        Console.WriteLine("== Búsqueda del Alumno Pedro Ortiz ==");
        if (listaAlumnos.BuscarAlumno("Pedro Ortiz") == true)
        {
            Console.WriteLine();
            Console.WriteLine("El alumno que se buscaba fue encontrado");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("El alumno que se buscaba no existe");
        }

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine();
        Console.WriteLine("== Búsqueda del Alumno no existente ==");
        if (listaAlumnos.BuscarAlumno("Mariela Sanchez") == true)
        {
            Console.WriteLine();
            Console.WriteLine("El alumno que se buscaba fue encontrado");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("El alumno que se buscaba no existe");
        }

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine();
        Console.WriteLine("== Listado actualizado de alumnos ==");
        Console.WriteLine();
        listaAlumnos.EliminarAlumno(alu2);
      
        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine();
        Console.WriteLine("== Listado actualizado de alumnos luego de eliminar el primer elemento de la lista ==");
        Console.WriteLine();
        listaAlumnos.EliminarPorPosicion(0);
     
        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        //Agregar 3 alumnos al diccionario
        Alumno alu1 = new Alumno(601, "Paula Lopez", 8.20);
        Alumno alu2 = new Alumno(602, "Pedro Ortiz", 6.55);
        Alumno alu3 = new Alumno(603, "Mariana Esposito", 7.12);

        CasoDictionary diccionario = new CasoDictionary();

        diccionario.AgregarAlumno(alu1.Id, alu1);
        diccionario.AgregarAlumno(alu2.Id, alu2);
        diccionario.AgregarAlumno(alu3.Id, alu3);

        //Listar por consola los alumnos
        Console.WriteLine("== Listado de Alumnos ==");
        Console.WriteLine();
        var alumnos = diccionario.MostrarAlumnos();

        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno.Value); //Agrego el .Value para que no se muestre el legajo 2 veces
        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine();
        Console.WriteLine("== Alumno Buscado ==");
        Console.WriteLine();
        var buscado = diccionario.BuscarPorLegajo(603); 
        if(buscado != null)
        {
            Console.WriteLine(buscado);
        }
        else
        {
            Console.WriteLine("El alumno buscado no existe");
        }

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine();
        Console.WriteLine("== Alumno Buscado no existente ==");
        Console.WriteLine();
        var buscado2 = diccionario.BuscarPorLegajo(600);
        if (buscado2 != null)
        {
            Console.WriteLine(buscado2);
        }
        else
        {
            Console.WriteLine("El alumno buscado no existe");
        }


        //Eliminar un alumno por clave y listar por consola los alumnos
        diccionario.EliminarAlumno(603);

        //Recorro el listado actualizado
        Console.WriteLine();
        Console.WriteLine("== Listado Actualizado de Alumnos ==");
        Console.WriteLine();
        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno.Value); 
        }


    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
