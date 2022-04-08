using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class NumerosEnteros
    {
        //Esta clase deberia tener una propiedad int Numero, y adentro del metodo retornar la division de esos dos datos
        public static decimal operator /(NumerosEnteros num1, NumerosEnteros num2)
        {            
            decimal ValorDecimal = num1 / num2;
            return ValorDecimal;
        }
    }
}
