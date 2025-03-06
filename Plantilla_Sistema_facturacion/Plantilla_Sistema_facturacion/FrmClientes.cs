using MaterialSkin.Controls;
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
    public partial class FrmClientes : MaterialForm
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
                lblDatosCliente.Text = "INGRESO NUEVO CLIENTE";
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

        // ACTUALIZACIONES

        //Funciones que permiten el ingreso, retiro y actualizaicon de clientes en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{TxtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}'
                   ,'Javier','{DateTime.Now.ToShortDateString()}'";
                MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        // funcion que permite validar los campos del formulario
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                campoVacioErrorProvider.SetError(txtNombre, "debeingresar el nombre del Cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { campoVacioErrorProvider.SetError(txtNombre, ""); }
            if (txtDocumento.Text == "")
            {
                campoVacioErrorProvider.SetError(txtDocumento, "debe ingresar el documento");
                campoVacioErrorProvider.Focus();
                errorCampos = false;
            }
            else { campoVacioErrorProvider.SetError(txtDocumento, ""); }

            if (!esNumerico(txtDocumento.Text))
            {
                campoVacioErrorProvider.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            campoVacioErrorProvider.SetError(txtDocumento, "");
                return errorCampos;
        }

        //Funcion para validar si un numero dado es numerico

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
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
