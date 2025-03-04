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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";

            if(TxtUsuario.Text != "" && TxtPasword.Text != string.Empty)
            {
                Acceso_datos acceso = new Acceso_datos();
                Respuesta = acceso.ValidarUsuario(TxtUsuario.Text, TxtPasword.Text);

                if(Respuesta !="")
                {
                    MessageBox.Show("Bienvenido: " + Respuesta);
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    this.Hide();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPasword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }

            FrmPrincipal frmppal = new FrmPrincipal();
            this.Hide();
                    frmppal.Show();
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
