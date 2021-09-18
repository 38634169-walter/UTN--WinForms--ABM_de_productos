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
                con.consultar("SELECT a.Id AS IdArticulo,Codigo, Nombre, a.Descripcion AS Descripcion, ImagenUrl, m.Id AS IdMarca, m.Descripcion AS Marca, c.Id AS IdCategoria, c.Descripcion AS Categoria, Precio FROM ARTICULOS AS a, CATEGORIAS AS c, MARCAS AS m WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id");
                con.abrir_conexion_y_consultar();

                while (con.lector.Read())
                {
                    Articulo art = new Articulo();
                    art.id = Convert.ToInt32(con.lector["IdArticulo"]);
                    art.codigo = (string)con.lector["Codigo"];
                    art.nombre = (string)con.lector["Nombre"];
                    art.descripcion = (string)con.lector["Descripcion"];
                    if (!(con.lector["imagenUrl"] is DBNull))
                    {
                        art.imagenUrl = (string)con.lector["ImagenUrl"];
                    }
                    art.precio = Convert.ToDouble(con.lector["Precio"]);
                    art.categoria = new Categoria();
                    art.categoria.id = Convert.ToInt32(con.lector["IdCategoria"]);
                    art.categoria.descripcion = (string)con.lector["Categoria"];
                    art.marca = new Marca();
                    art.marca.id = Convert.ToInt32(con.lector["IdMarca"]);
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
                datos.consultar("INSERT into ARTICULOS (Codigo, Nombre, Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES ('"+ nuevo.codigo +"', '"+ nuevo.nombre +"', '"+ nuevo.descripcion +"',@IdMarca,@IdCategoria,'" + nuevo.imagenUrl + "', '" + nuevo.precio + "' )");
                datos.setear("@IdMarca",nuevo.marca.id);
                datos.setear("@IdCategoria",nuevo.categoria.id);
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
        public void modificar(Articulo mod)
        {
            ConexionDB con = new ConexionDB();
            try
            {
                con.consultar("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagen, Precio = @precio WHERE Id = @id ");
                con.setear("@codigo",mod.codigo);
                con.setear("@nombre", mod.nombre);
                con.setear("@descripcion", mod.descripcion);
                con.setear("@idmarca", mod.marca.id);
                con.setear("@idcategoria", mod.categoria.id);
                con.setear("@imagen", mod.imagenUrl);
                con.setear("@precio", mod.precio);
                con.setear("@id", mod.id);
                con.abrir_conexion_y_ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.cerrar_conexion();
            }
        }
    }
}
