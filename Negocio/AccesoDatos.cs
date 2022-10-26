using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        //Voy a declarar unos atributos de tipo objeto, es decir de
        //aquellos objetos que necesito para establecer una conexion
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        //Creamos la property de lector (ya que es un atributo privado)
        //con el método GET para tener la posibilidad de LEER a la variable
        //"lector"
        public SqlDataReader Lector
        { 
            get { return lector; }

        }

        //Creamos un constructor, donde le paso la cadena de conexion, 
        //y tambien el comando, porque voy a realizar una consulta sql.
        public AccesoDatos()  
        {
            conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }

        //Método para establecer el tipo de comando a realizar y pasar
        //por parámetro la consulta correspondiente
        public void SetearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //Método para darle al comando la conexion a los datos, abrir
        //la conexion, ejecutar el lector y lo almacena en "lector"
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //Método para insertar un nuevo Pokemon
        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Método para enlazar los valores del Select seleccionados con su Id
        public void SetearParametros(string nombre, object valor) 
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }


        //Método para cerrar la conexion
        public void CerrarConexion()
        {
            //Verifica que el lector sea distinto a Null, para poder tambien
            //cerrarlo tambien, si es que hay un lector utilizandose.De esta manera
            //cierro el lector y despues la conexion
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

    }
}
