using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Examen_Calix.Models
{
    class Artista
    {
        public int Id { set; get; }
        public string Nombre { set; get; }


        public Artista() { }
        public void ObtenerArtistaPorNombre(string nombreArtista)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT Id, Nombre FROM Music.Artista WHERE nombre = '" + nombreArtista + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
