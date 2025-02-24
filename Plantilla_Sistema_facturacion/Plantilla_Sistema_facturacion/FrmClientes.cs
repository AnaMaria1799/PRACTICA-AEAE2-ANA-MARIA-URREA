using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Sistema_facturacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                campoVacioErrorProvider.SetError(txtNombre, "El nombre no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtNombre, "");
            }


            if (txtDocumento.Text == "")
            {
                campoVacioErrorProvider.SetError(txtDocumento, "El documento no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtDocumento, "");
            }


            if (txtTelefono.Text == "")
            {
                campoVacioErrorProvider.SetError(txtTelefono, "El telefono no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtTelefono, "");
            }

        }



        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
