using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class Elemento
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        //Voy a sobreescribir el metodo ToString() para que me retorne el objeto de tipo descripcion en texto,
        //porque sino muestra la palabra "Elemento" por lo que no sabe el compilados cual de las dos propiedades mostrar
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
