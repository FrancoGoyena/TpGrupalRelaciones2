using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupalRelaciones2
{
    public class Clase
    {
        public string Aula { get; set; }
        public DateTime Fin { get; set; }
        public DateTime Inicio { get; set; }

        public Clase(string aula, DateTime fin, DateTime inicio)
        {
            Aula = aula;
            Fin = fin;
            Inicio = inicio;
        }
    }
}
