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
    public partial class frmEliminarCancion : Form
    {
        public frmEliminarCancion()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.Cancion cancion = new Models.Cancion();
                
        }
    }
}
