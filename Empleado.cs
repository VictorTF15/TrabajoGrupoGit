using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupoGit
{
  public class Empleado
  {
    public string Nombre { get; set; }
    public double SueldoBase { get; set; }
    public virtual double CalcularSueldo()
    {
      return SueldoBase;
    }
  }
    public class EmpleadoTemporal : Empleado
    {
        public int HorasExtra { get; set; }
        public override double CalcularSueldo()
        {
            return SueldoBase + (HorasExtra * 100);
        }
    }
    public class EmpleadoPermanente : Empleado
    {
        public double Bono { get; set; }
        public override double CalcularSueldo()
        {
            return SueldoBase + Bono;
        }
    }
}
