using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class GestorBase
    {
        string vCadenaConexion = Database.connectionString;
        #region Mostrar especifico

        #region Login
        public Usuarios Login(string User, string Pass)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuarios vRegistro = new Usuarios();

                string commandText = "SELECT * FROM [dbo].[Tab_Usuarios] WHERE [Nombre_Usuario] = '" + User + "' AND [Contrasena] = '" + Pass + "'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula = int.Parse(dtConsulta.Rows[0]["Cedula"].ToString());
                    vRegistro.Apellido1 = dtConsulta.Rows[0]["Apellido1"].ToString();
                    vRegistro.Apellido2 = dtConsulta.Rows[0]["Apellido2"].ToString();
                    vRegistro.Contrasena = dtConsulta.Rows[0]["Contrasena"].ToString();
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.Id_Perfil = int.Parse(dtConsulta.Rows[0]["Id_Perfil"].ToString());
                    vRegistro.Nombre_Usuario = dtConsulta.Rows[0]["Nombre_Usuario"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion
    }
}
