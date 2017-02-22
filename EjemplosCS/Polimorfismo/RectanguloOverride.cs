using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class RectanguloOverride : FiguraGeometrica
    {
        public override string CalcularArea()
        {
            return "Soy Area de un Rectangulo";
        }
    }
}
