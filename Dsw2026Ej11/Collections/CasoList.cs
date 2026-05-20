using Dsw2026Ej11.Domain;
using System.Collections.Generic;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    List<Alumno> alumnos = new List<Alumno>();

    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumnos(Alumno alum)
    {
        alumnos.Add(alum);
    }

    //Incluir un método para retornar la lista
    public List<Alumno> MostrarAlumnos()
    {
        return alumnos;
    }

    //Incluir un método para buscar un alumno por nombre
    public bool BuscarAlumno (string nombre)
    {

        foreach(Alumno alu in alumnos)
        {
            if (alu.Nombre == nombre)
            {
                return true;
            }
        }

        return false;
    }

    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno (Alumno alum)
    {
         alumnos.Remove(alum);
    }

    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarPorPosicion (int index)
    {
        if(index >= 0 && index < alumnos.Count)
           alumnos.RemoveAt(index);  
    }
}
