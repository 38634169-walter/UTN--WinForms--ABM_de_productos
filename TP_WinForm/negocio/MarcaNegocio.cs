using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using modelo;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> listaMar = new List<Marca>();
            ConexionDB con = new ConexionDB();
            try
            {
                con.consultar("SELECT Id, Descripcion FROM MARCAS");
                con.abrir_conexion_y_consultar();
                while(con.lector.Read())
                {
                    Marca mar = new Marca();
                    mar.id = Convert.ToInt32(con.lector["Id"]);
                    mar.descripcion = (string)con.lector["Descripcion"];
                    listaMar.Add(mar);
                }
                con.cerrar_conexion();
                return listaMar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
