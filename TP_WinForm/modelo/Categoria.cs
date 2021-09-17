using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Categoria
    {
        public int id;
        public string descripcion;

        public override string ToString()
        {
            return descripcion;
        }
    }
}
