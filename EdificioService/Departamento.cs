using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdificioService
{
    public class Departamento
    {
        public int NroDepartamento { get; set; }
        public string NombreDueño { get; set; }
        public string ApellidoDueño { get; set; }

        public string ObtenerNombreCompletoDueño()
        {
            return $"{NombreDueño} {ApellidoDueño}";
        }
    }
}
