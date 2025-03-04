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
        SqlConnection conexion;  // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd;  // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;  // data reader , consulta de solo lectura de informacion
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd()  // método para abrir la base de datos
        {
            try  // permite captura de un error en caso que se presente
            {
                conexion = new SqlConnection("Data Source=TECNOLOGIA2016;InitialCatalog=[DBFACTURAS];Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló conexión" + ex);
            }
        }
        public void CerrarBd()  // método para cerrar conexion a la base de datos
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
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
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

        // recibe una sentencia de para realizar acciones de actualizar, retirar y nuevo

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON CON EXITO";

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); // UTILIZADO PARA UPDATE, INSERT y DELETE
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "falló inserción: " + ex;
            }
            return salida;
        }

        // Método que permite consultar una tabla y recuperar un conjunto de datos permite filtrar la información requerida
        public DataTable cargartabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string Sql = "Select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        // Método que permite consultar con una sentencia (select) o invocar un procedimiento almacenado
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }

    }
}
