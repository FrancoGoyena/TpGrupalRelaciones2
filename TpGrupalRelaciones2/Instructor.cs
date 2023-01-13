using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Instructor:Persona
    {
        public string Materias { get; set; }

        Instructor(string materias, string apellido, string nombre) : base(apellido, nombre)
        {
            Materias = materias;
        }
    }
}
