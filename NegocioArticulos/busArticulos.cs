using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosArtículos;

namespace NegocioArticulos
{
    public class busArticulos
    {
        public List<Articulos> Listararticulos()
        {

            List<Articulos> Lista = new List<Articulos>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {

                accesoDatos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio,C.Descripcion,M.Descripcion from ARTICULOS as A, CATEGORIAS as C, MARCAS as M where A.IdCategoria = C.Id and A.Id = M.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    
                    aux.codigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    aux.nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.descripcionArticulos = (string)accesoDatos.Lector["Descripcion"];
                    aux.imagenURL = (string)accesoDatos.Lector["ImagenUrl"];
                    aux.precio = (decimal) accesoDatos.Lector["Precio"];
                    aux.descripcionMarca = new Marca();
                    aux.descripcionCategoria = new Categoria();
                    aux.descripcionMarca.descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.descripcionCategoria.descripcion = (string)accesoDatos.Lector["Descripcion"];
                    Console.WriteLine(accesoDatos.Lector["Descripcion"]);


                    Lista.Add(aux);
                } 
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
            }
    }
}
