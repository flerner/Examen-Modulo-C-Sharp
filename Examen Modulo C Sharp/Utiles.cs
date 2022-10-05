using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp
{
    static class Utiles
    {
        public static Boolean Validar(string dato, string tipo)
        {
            switch (tipo)
            {              
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (FormatException ex)
                    {
                        return false;
                    }
                default: return false;

            }
        }
    }
}
