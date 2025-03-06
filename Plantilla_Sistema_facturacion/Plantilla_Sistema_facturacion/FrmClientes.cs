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

        public int IdCliente { get; set; }

        DataTable dt = new DataTable();
        Acceso_datos Acceso =  new Acceso_datos();

        private void    LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                string sentencia = $"select = from TBLCLIENTES where IdCliente = {IdCliente}";

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
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
