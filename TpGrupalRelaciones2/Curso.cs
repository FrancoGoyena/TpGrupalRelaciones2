using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Curso
    {
        public string Alumnos { get; set; }
        public string Clases { get; set; }
        public string Instructor { get; set; }
        public string Materia { get; set; }

        public Curso(string alumnos, string clases, string instructor, string materia)
        {
            Alumnos = alumnos;
            Clases = clases;
            Instructor = instructor;
            Materia = materia;
        }
    }
}
