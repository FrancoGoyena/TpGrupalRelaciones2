using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Alumno:Persona
    {
        public string Regular { get; set; }

        Alumno(string regular,string apellido,string nombre):base(apellido,nombre)
        {
            Regular = regular;
        }
    }
}
