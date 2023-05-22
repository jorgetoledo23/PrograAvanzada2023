using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Model
{
    public class Usuario
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Pass { get; set; }
        
    }

    public class Sede
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public List<CarreraSede> CarrerasSede { get; set; }

    }

    public class Carrera
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duracion { get; set; }
        public List<CarreraAsignatura> AsignaturasCarrera{ get; set; }

    }

    public class CarreraSede
    {
        public int Id { get; set; }

        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }

        public int SedeId { get; set; }
        public Sede Sede { get; set; }

    }


    public class Asignatura
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Codigo { get; set; }
        public int Horas { get; set; }

    }

    public class CarreraAsignatura
    {
        public int Id { get; set; }

        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }


        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }

    }



    public class Docente
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Rut { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }

    public class Alumno
    {
        public string Name { get; set; }
        public string Rut { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }

    public class Seccion
    {
        public string Name { get; set; }
        public int Id { get; set; }

        //Claves Foraneas
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }

        public int DocenteId { get; set; }
        public Docente Docente { get; set; }

        public List<SeccionAlumnos> AlumnosSeccion { get; set; }
    }

    public class SeccionAlumnos
    {
        public int Id{ get; set; }

        public int SeccionId { get; set; }
        public Seccion Seccion { get; set; }


        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }




}
