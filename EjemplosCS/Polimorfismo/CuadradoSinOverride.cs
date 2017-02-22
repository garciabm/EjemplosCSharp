using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class CuadradoSinOverride : FiguraGeometrica
    {
        public string CalcularArea()
        {
            return "Soy Area de un cuadrado";
        }
    }
}
