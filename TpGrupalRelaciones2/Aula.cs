using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Aula
    {
        public int Capacidad { get; set; }
        public int Codigo { get; set; }

        Aula(int capacidad, int codigo)
        {
            Capacidad = capacidad;
            Codigo = codigo;
        }
    }
}
