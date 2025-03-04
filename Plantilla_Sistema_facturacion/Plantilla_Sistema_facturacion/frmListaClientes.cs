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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void LLENAR_GRID()
        {
            dgClientes.Rows.Clear();

            string sentencia = $"SELECT IdClientes, StrNombre, NumDocumento, StrTelefono FROM TBLCLIENTES";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows) 
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            Cliente.IdCliente = 0;
            dgClientes.ShowDialog();
            LLENAR_GRID():

        
            
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text !="")
            {
                dgClientes.Rows.Clear();

                string sentencia = $"select from TBLCLIENTES where strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows) { dgClientes.Rows.Add(row[0], row[1], row[2], row[3]); }
                txtBuscar.Text = "";
            }
            else
            {
                LLENAR_GRID();
            }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
