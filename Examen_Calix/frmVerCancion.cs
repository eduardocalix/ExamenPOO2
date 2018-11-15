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
    public partial class frmVerCancion : Form
    {
        public frmVerCancion()
        {
            InitializeComponent();
        }

        private void frmVerCancion_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Models.Cancion cancion = new Models.Cancion();
            Models.Conexion conexion = new Models.Conexion();
            string sql = "select * FROM Music.Cancion";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCanciones.DataSource = dt;
        }


        private void dgvCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
