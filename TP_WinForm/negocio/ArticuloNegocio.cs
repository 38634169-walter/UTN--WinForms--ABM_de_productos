using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using modelo;
using negocio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            ConexionDB con = new ConexionDB();

            try
            {
                con.consultar("SELECT Codigo, Nombre, a.Descripcion AS Descripcion, ImagenUrl, m.Descripcion AS Marca, c.Descripcion AS Categoria, Precio FROM ARTICULOS AS a, CATEGORIAS AS c, MARCAS AS m WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id");
                con.abrir_conexion_y_consultar();

                while (con.lector.Read())
                {
                    Articulo art = new Articulo();
                    art.codigo = (string)con.lector["Codigo"];
                    art.nombre = (string)con.lector["Nombre"];
                    art.descripcion = (string)con.lector["Descripcion"];
                    art.imagenUrl = (string)con.lector["ImagenUrl"];
                    art.precio = Convert.ToDouble(con.lector["Precio"]);
                    art.categoria = new Categoria();
                    art.categoria.descripcion = (string)con.lector["Categoria"];
                    art.marca = new Marca();
                    art.marca.descripcion = (string)con.lector["Marca"];
                    listaArticulo.Add(art);
                }
                con.cerrar_conexion();
                return listaArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar (Articulo nuevo)
        {
            ConexionDB datos = new ConexionDB();
            try
            {
                datos.consultar("INSERT into ARTICULOS (Codigo, Nombre, Descripcion) VALUES ('"+ nuevo.codigo +"', '"+ nuevo.nombre +"', '"+ nuevo.descripcion +"')");
                datos.abrir_conexion_y_ejecutar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrar_conexion();
            }
        }
    }
}
