using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        //Le agrego la propiedad (De composicion)TIPO de tipo Elemento
        public Elemento Tipo { get; set; }

        //Le agrego la propiedad (tambien de Composicion)DEBILIDAD de tipo elemento 
        public Elemento Debilidad { get; set; }
    }
}
