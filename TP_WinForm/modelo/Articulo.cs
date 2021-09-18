using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace modelo
{
    public class Articulo
    {
        public int id { get; set; }
        [DisplayName("Codigo")]
        public string codigo { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public string imagenUrl { get; set; }
        public double precio { get; set; }
        public Articulo()
        {
            marca = new Marca();
            categoria = new Categoria();
        }
    }
}
