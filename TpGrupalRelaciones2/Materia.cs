using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Materia
    {
        public string Nombre { get; set; }
        public string Programa { get; set; }

        public Materia(string nombre, string programa)
        {
            Nombre = nombre;
            Programa = programa;
        }
    }
}
