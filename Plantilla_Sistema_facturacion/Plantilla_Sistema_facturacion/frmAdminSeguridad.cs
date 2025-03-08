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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void llenar_combo_empleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();
            dt = Acceso.cargartabla("TBLEMPLEADO", "");
            
            cboEmpleado.DataSource = dt;
            cboEmpleado.DisplayMember = "strNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
            Acceso.CerrarBd();
        }

        private Boolean validar ()
        {
            Boolean errorCampos = true;
            if (txtUsuarioSistema.Text == string.Empty)
            {

                campoErrorProvider.SetError(txtUsuarioSistema, "Debe ingresar un usuario");
                txtUsuarioSistema.Focus();
                errorCampos = false;
            }
            else
            {
                campoErrorProvider.SetError(txtUsuarioSistema, "");
            }

            if (txtClaveSistema.Text == "")
            {
                campoErrorProvider.SetError(txtClaveSistema, "Debe ingresar un valor de cédula");
                txtClaveSistema.Focus();
                errorCampos = false;
            }
            else
            {
                campoErrorProvider.SetError(txtClaveSistema, "");
            }
            return errorCampos;
        }
    }
}
