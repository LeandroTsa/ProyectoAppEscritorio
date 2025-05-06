using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosArtículos
{
    public class Articulos
    {

        public string codigoArticulo { get; set; }
        [DisplayName("Articulo @")]
        public string nombre { get; set; }
        [DisplayName("Descripcion @txt@")]
        public string descripcionArticulos { get; set; }
        [DisplayName("Marca &&@")]
        public Marca descripcionMarca { get; set; }
        [DisplayName("Categoria ^.^")]
        public Categoria descripcionCategoria { get; set; }
        public string imagenURL { get; set; }
        [DisplayName("Precio $$")]
        public decimal precio { get; set; }

    }
}
