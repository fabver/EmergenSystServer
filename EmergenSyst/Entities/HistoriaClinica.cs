using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HistoriaClinica
    {
        public Persona persona { get; set; }
        public List<DatosClinicos> datosClinicos { get; set; }
    }
}
