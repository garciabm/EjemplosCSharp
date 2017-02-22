using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class RectanguloSinOverride : FiguraGeometrica
    {
        public string CalcularArea()
        {
            return "Soy Area de un rectángulo";
        }
    }
}
