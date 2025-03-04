using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Sistema_facturacion
{
    class Acceso_datos
        
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd()
        {
            try
            {
                conexion = new SqlConnection("Data Source=TECNOLOGIA2016;InitialCatalog=[DBFACTURAS];Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló conexión" + ex);
            }
        }
        public void CerrarBd() 
        {
            try 
            {
                conexion.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("falló cerrar conexión" + ex);
            }
        }

        //Metodo para validar el ingreso del usuario la sistema
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();
                while (LectorDatos.Read())
                {
                    strEmpleado = Convert.ToString(LectorDatos.GEtValue(0));
                }
                if (LectorDatos != null)
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }

        }

    }
}
