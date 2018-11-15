using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Examen_Calix.Models
{
    class Cancion
    {
        //Se encapsulan las variables a usar
        public int Id { set; get; }
        public string Nombre{ set; get; }
        public int Artista { set; get; }
        public int Album { set; get; }
        public string Genero { set; get; }
        public string Año { set; get; }
        //Se define un constructor
        public Cancion() { }
        //Se define el destructor
        ~Cancion() { }
        //Constructor para insertar una cancion
        public Cancion(string nombre, int artista, int album, string genero, string año)
        {

            Nombre = nombre;
            Artista = artista;
            Album = album;
            Genero = genero;
            Año = año;

        }
        
        //Constructor para eliminar una cancion
        public Cancion(int id)
        {
            Id = id;
        }
        //Funcion para llamar el store Procedure y asignar los parametros que insertaremos
        public void Agregar()
        {
            Models.Conexion conexion = new Models.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarCancion", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //Se abre la conexion
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.NVarChar, 200));
                cmd.Parameters["Nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("Artista", SqlDbType.Int));
                cmd.Parameters["Artista"].Value = Artista;
                cmd.Parameters.Add(new SqlParameter("Album", SqlDbType.Int));
                cmd.Parameters["Album"].Value = Album;
                cmd.Parameters.Add(new SqlParameter("Genero", SqlDbType.NVarChar, 100));
                cmd.Parameters["Genero"].Value = Genero;
                cmd.Parameters.Add(new SqlParameter("AñoCreacion", SqlDbType.NVarChar, 25));
                cmd.Parameters["AñoCreacion"].Value = Año;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //Cuando ocurre un error 
                throw ex;
            }
            finally
            {
                //Se cierra la conexion
                conexion.Cerrar();
            }

        }

        //Funcion para llamar el store Procedure para eliminar una cancion deseada
        public void Eliminar()
        {
            Models.Conexion conexion = new Models.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarCancion", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("ID", SqlDbType.Int));
                cmd.Parameters["ID"].Value = Id;
                cmd.ExecuteNonQuery();
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
        //Funcion para Consultar los datos de cancion determinado
        public void ObtenerCancion(int id)
        {
            Models.Conexion conexion = new Models.Conexion();
            string sql = @"SELECT * FROM Music.Cancion WHERE Id = '" + Id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Artista = dr.GetInt32(2);
                    Album = dr.GetInt32(3);
                    Genero = dr.GetString(4);
                    Año = dr.GetString(5);
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
