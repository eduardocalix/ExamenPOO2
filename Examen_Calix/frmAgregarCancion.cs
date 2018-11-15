using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examen_Calix
{
    public partial class frmAgregarCancion : Form
    {
        public frmAgregarCancion()
        {
            InitializeComponent();
        }

        private void CargarCBArtista()
        {
            DataTable dt = new DataTable();
            Models.Conexion conexion = new Models.Conexion();
            string sql = "select * FROM Music.Artista";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbArtista.DisplayMember = "nombre";
            cbArtista.ValueMember = "nombre";
            cbArtista.DataSource = dt;
        }
        private void CargarCBAlbum()
        {
            DataTable dt = new DataTable();
            Models.Conexion conexion = new Models.Conexion();
            string sql = "select * FROM Music.Album";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbAlbum.DisplayMember = "nombre";
            cbAlbum.ValueMember = "nombre";
            cbAlbum.DataSource = dt;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
            Models.Album album = new Models.Album();
            album.ObtenerAlbumPorNombre(cbAlbum.SelectedValue.ToString());
            Models.Artista artista = new Models.Artista();
            artista.ObtenerArtistaPorNombre(cbArtista.SelectedValue.ToString());
            Models.Cancion cancion = new Models.Cancion(
                txtNombre.Text,
                artista.Id,
                album.Id,
                txtGenero.Text,
                txtAño.Text);
            cancion.Agregar();
                MessageBox.Show("Agregado");
            }
            catch
            {
                MessageBox.Show("No Agregado");
            }
        }

        private void frmAgregarCancion_Load(object sender, EventArgs e)
        {
            CargarCBAlbum();
            CargarCBArtista();
        }
    }
}
