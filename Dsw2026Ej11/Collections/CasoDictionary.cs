using Dsw2026Ej11.Domain;
using System.Collections.Generic;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    Dictionary<int, Alumno> alumnosOrden = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno (int leg, Alumno alu)
    {
        alumnosOrden.Add(leg, alu);
        //Otra opción es:
        //alumnosOrden[leg] = alu;
    }

    //Incluir un método para buscar un alumno utilizando la clave

    public Alumno BuscarPorLegajo(int leg)
    {
       
            if (alumnosOrden.ContainsKey(leg))
            {
                return alumnosOrden[leg];
            }
        
        return null;
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> MostrarAlumnos()
    {
        return alumnosOrden;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int leg)
    {
        alumnosOrden.Remove(key: leg);
    }
}
