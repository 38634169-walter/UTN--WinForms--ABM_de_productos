using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using modelo;

namespace negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> listar()
        {
            List<Categoria> listaCat = new List<Categoria>();
            ConexionDB con = new ConexionDB();
            try
            {
                con.consultar("SELECT Id, Descripcion FROM CATEGORIAS");
                con.abrir_conexion_y_consultar();
                while(con.lector.Read())
                {
                    Categoria cat = new Categoria();
                    cat.id = Convert.ToInt32(con.lector["Id"]);
                    cat.descripcion = (string)con.lector["Descripcion"];
                    listaCat.Add(cat);
                }
                con.cerrar_conexion();
                return listaCat;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
