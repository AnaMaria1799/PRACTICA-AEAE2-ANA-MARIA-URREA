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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                campoVacioErrorProvider.SetError(txtNombreProducto, "El nombre no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtNombreProducto, "");
            }


            if (txtCodigoRef.Text == "")
            {
                campoVacioErrorProvider.SetError(txtCodigoRef, "El codigo de referencia no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtCodigoRef, "");
            }


            if (txtCantidadStock.Text == "")
            {
                campoVacioErrorProvider.SetError(txtCantidadStock, "Cantidad Stock no puede ser vacío");
            }
            else
            {
                campoVacioErrorProvider.SetError(txtCantidadStock, "");
            }
        }
    }
}
