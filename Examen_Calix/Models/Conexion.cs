using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Examen_Calix.Models
{
    class Conexion
    {
        private const string error = "Hay problemas para conectarse a la base de datos";
        // Creamos el string de conexion.
        private SqlConnection con;
        //Se crea una Funcion para sql y así establecer la conexion
        public SqlConnection conexion
        {
            get
            {
                return con;
            }
        }
        //Metodo Conexion donde se le dice que base de datos utilizará
        public Conexion()
        {
            this.con = new SqlConnection(@"server = (local)\SAMPSON;
            integrated security = true; database = BulletProofRecords; ");

        }
        //Creamos el metodo para abrir la conecion con la base de datos
        public void Abrir()
        {
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Creamos el metodo para cerrar la conexion con la base de datos.
        public void Cerrar()
        {
            try
            {
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
