using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupoGit
{
    public class EmpleadoPermanente : Empleado
    {
        public double Bono { get; set; }

        public override double CalcularSueldo()
        {
            return SueldoBase + Bono;
        }
    }
}
