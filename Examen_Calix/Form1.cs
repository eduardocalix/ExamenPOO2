using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Calix
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para Salir de la aplicacion
            this.Close();
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            frmAgregarCancion agregarCancion = new frmAgregarCancion();
            agregarCancion.ShowDialog();
        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            frmEliminarCancion eliminarCancion = new frmEliminarCancion();
            eliminarCancion.ShowDialog();
        }

        private void btnReporteCanciones_Click(object sender, EventArgs e)
        {
            frmVerCancion verCancion = new frmVerCancion();
            verCancion.ShowDialog();
        }
    }
}
