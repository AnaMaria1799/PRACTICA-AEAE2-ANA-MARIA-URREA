using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_facturacion
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirForm(Form formHijo)
        {
            if (this.PnlContenedor.Controls.Count > 0) 
                this.PnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes frmListaClientes = new frmListaClientes();
            AbrirForm(frmListaClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos frmListaProductos = new frmListaProductos();
            AbrirForm(frmListaProductos);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda frmAyuda = new frmAyuda();
            AbrirForm(frmAyuda);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcercaDe = new frmAcercaDe();
            AbrirForm(frmAcercaDe);
        }
    }
}
