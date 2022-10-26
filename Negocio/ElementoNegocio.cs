using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {   
            //Declaramos un objeto de tipo lista que va a retornar y un
            //objeto de tipo AccesoDatos. La variable Datos es un objeto que tiene 
            //un lector, un comando y una cadena de conexion
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Creo la consulta que quiero ejecutar y la mando como parámetro
                datos.SetearQuery("select Id, Descripcion from ELEMENTOS");
                //Ejecuto la lectura 
                datos.EjecutarLectura();

                //Utilizo la property Lector para leer el atributo "lector"
                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            //En este bloque llamamos al metodo "cerrarConexion"
            finally 
            {
                datos.CerrarConexion();
            }
        }

        public void agregar(Elemento nuevoE)
        {
            AccesoDatos datosE = new AccesoDatos();

            try
            {
                datosE.SetearQuery($"insert into ELEMENTOS values('{nuevoE.Descripcion}')");
                datosE.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datosE.CerrarConexion();
            }

        }
    }
}
