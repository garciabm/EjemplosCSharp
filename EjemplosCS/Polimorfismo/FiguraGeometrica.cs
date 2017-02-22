using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class FiguraGeometrica
    {
        public virtual string CalcularArea()
        {
            return "Area de Figura Geométrica";
        }
    }
}
