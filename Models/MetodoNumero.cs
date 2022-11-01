using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    public class MetodoNumero
    {
        public bool EsNumero(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }              
            }
            return true;
        }
    }    
}
