using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLoprestiConexionBD
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsConexionBDV conexion = new clsConexionBDV();
        private void frmInicio_Load(object sender, EventArgs e)
        {
            conexion.ConectarBD();
        }
    }
}
