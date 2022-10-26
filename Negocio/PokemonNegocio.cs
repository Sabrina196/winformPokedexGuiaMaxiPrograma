using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;


namespace Negocio
{
    public class PokemonNegocio
    {
        //podria crear un atributo private de acceso a datos para no tenes
        //que declararlo en cada método y que se le asigne valor por medio
        //de un constructor
        public List<Pokemon> Listar()
        {

            List<Pokemon> Lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearQuery("select P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, P.IdTipo, P.IdDebilidad, E.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P INNER JOIN ELEMENTOS E ON P.IdTipo = E.id INNER JOIN ELEMENTOS D ON P.IdDebilidad = D.Id where P.Activo = 1");
                datos.EjecutarLectura();
               
                while (datos.Lector.Read())
                {
                    //Creo un objeto de tipo Pokemon para que almacene en cada vuelta los siguientes registros.Es decir, que esta variable
                    //se va a reutilizar.
                    Pokemon aux = new Pokemon();

                    //Al nuevo objeto "aux" lo voy a cargar con los datos del registro
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    }
                    //Instanciar primero el objeto de tipo elemento para que no nos de NULL, tanto para el TIPO como para la DEBILIDAD
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];


                    //Agrego el objeto de la vuelto a la lista
                    Lista.Add(aux);
                }
                return Lista;
            }
            //Si captura un error nos muestra el mensaje de la variable "ex"
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Agregar(Pokemon nuevo)
        {
            //No creamos una lista porque es un metodo que no devuelve nada,
            //sino que inserta datos
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Seteamos la consulta sql deseada
                datos.SetearQuery($"insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values({nuevo.Numero},'{nuevo.Nombre}', '{nuevo.Descripcion}',1, @idTipo, @IdDebilidad, '{nuevo.UrlImagen}')");
                //Con la dos variables creadas, llamamos a la siguiente función para que se carguen los
                //Id de Tipo y debilidad del Nuevo Pokemon
                datos.SetearParametros("@IdTipo", nuevo.Tipo.Id);
                datos.SetearParametros("@IdDebilidad", nuevo.Debilidad.Id);
                //Cuando se ejecuta la accion, va a reemplazar cada variable (@IdTipo y @IdDebilidad)
                //por su Id
                datos.EjecutarAccion();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void Modificar(Pokemon modificado) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery($"update POKEMONS set Numero={modificado.Numero} , Nombre='{modificado.Nombre}', Descripcion='{modificado.Descripcion}', UrlImagen='{modificado.UrlImagen}', IdTipo=@tipo , IdDebilidad=@deb , Activo=1 WHERE Id={modificado.Id}");
                datos.SetearParametros("@tipo", modificado.Tipo.Id);
                datos.SetearParametros("@deb", modificado.Debilidad.Id);
                
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        
        public void Eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.SetearQuery($"delete from POKEMONS where id={Id}");
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarLogico(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearQuery($"update POKEMONS set Activo=0 where Id={Id}");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Pokemon> Filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> listafiltroAvanzado = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string query = "select P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, P.IdTipo, P.IdDebilidad, E.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P INNER JOIN ELEMENTOS E ON P.IdTipo = E.id INNER JOIN ELEMENTOS D ON P.IdDebilidad = D.Id where P.Activo = 1 AND ";
                //Concatenamos dependiendo de la elección del usuario
                if (campo == "Número")
                {
                    switch (criterio)
                    {
                        case "Menor a":
                            query += $"Numero < {filtro}";
                            break;

                        case "Mayor a":
                            query += $"Numero > {filtro}";
                            break;

                        default:
                            query += $"Numero = {filtro}";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comience con":
                            query += $"Nombre like'{filtro}%'";
                            break;

                        case "Termine con":
                            query += $"Nombre like '%{filtro}'";
                            break;

                        default:
                            query += $"Nombre like '%{filtro}%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comience con":
                            query += $"P.Descripcion like'{filtro}%'";
                            break;

                        case "Termine con":
                            query += $"P.Descripcion like '%{filtro}'";
                            break;

                        default:
                            query += $"P.Descripcion like '%{filtro}%'";
                            break;
                    }

                }

                datos.SetearQuery(query);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    //Creo un objeto de tipo Pokemon para que almacene en cada vuelta los siguientes registros.Es decir, que esta variable
                    //se va a reutilizar.
                    Pokemon aux = new Pokemon();

                    //Al nuevo objeto "aux" lo voy a cargar con los datos del registro
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    }
                    //Instanciar primero el objeto de tipo elemento para que no nos de NULL, tanto para el TIPO como para la DEBILIDAD
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];


                    //Agrego el objeto de la vuelto a la lista
                    listafiltroAvanzado.Add(aux);
                }

                return listafiltroAvanzado;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

    
    }
}
