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

        #region Agregar

        #region Expedientes
        public Int32 Agregar_Expediente(Expedientes obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Expedientes (Num_Expediente,Usuario_Generador,Cedula,Descripcion,Id_Tipo_Procedimiento,Lugar_Trabajo,Medida_Cautelar,Organo_Director,Parte_Procesal,Estado) values(@Num_Expediente,@Usuario_Generador,@Cedula,@Descripcion,@Id_Tipo_Procedimiento,@Lugar_Trabajo,@Medida_Cautelar,@Organo_Director,@Parte_Procesal,@Estado)";
                Parameter[] parametros = {
                                                     new Parameter("@Num_Expediente",obj.Num_Expediente),
                                                     new Parameter("@Usuario_Generador",obj.Usuario_Generador),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Descripcion",obj.Descripcion),
                                                     new Parameter("@Id_Tipo_Procedimiento",obj.Id_Tipo_Procedimiento),
                                                     new Parameter("@Lugar_Trabajo",obj.Lugar_Trabajo),
                                                     new Parameter("@Medida_Cautelar",obj.Medida_Cautelar),
                                                     new Parameter("@Organo_Director",obj.Organo_Director),
                                                     new Parameter("@Parte_Procesal",obj.Parte_Procesal),
                                                     new Parameter("@Estado",obj.Estado),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Casos", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Procedimientos
        public Int32 Agregar_Procedimiento(Procedimiento obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Procedimiento (Nombre_Procedimiento,Descripcion_Procedimiento) values(@Nombre_Procedimiento,@Descripcion_Procedimiento)";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre_Procedimiento",obj.Nombre_Procedimiento),
                                                     new Parameter("@Descripcion_Procedimiento",obj.Descripcion_Procedimiento),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Procedimientos", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Funcionarios
        public Int32 Agregar_Funcionario(Funcionarios obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Funcionarios (Nombre,Cedula,Apellido1,Apellido2,Genero) values(@Nombre,@Cedula,@Apellido1,@Apellido2,@Genero)";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Apellido1",obj.Apellido1),
                                                     new Parameter("@Apellido2",obj.Apellido2),
                                                     new Parameter("@Genero",obj.Genero),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Funcionarios", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Usuarios
        public Int32 Agregar_Usuario(Usuarios obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Usuarios (Nombre,Cedula,Nombre_Usuario,Apellido1,Apellido2,Contrasena,Id_Perfil,Genero) values(@Nombre,@Cedula,@Nombre_Usuario,@Apellido1,@Apellido2,@Contrasena,@Id_Perfil,@Genero)";
                Parameter[] parametros = {
                                                     new Parameter("@Id_Perfil",obj.Id_Perfil),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Apellido1",obj.Apellido1),
                                                     new Parameter("@Apellido2",obj.Apellido2),
                                                     new Parameter("@Contrasena",obj.Contrasena),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                                     new Parameter("@Genero",obj.Genero),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region rol
        public Int32 Agregar_Rol(Perfiles obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Perfiles (Id_Perfil,Nombre_Perfil) values(@Id_Perfil,@Nombre_Perfil)";
                Parameter[] parametros = {
                                                     new Parameter("@Id_Perfil",obj.Id_Perfil),
                                                     new Parameter("@Nombre_Perfil",obj.Nombre_Perfil),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Roles y permisos", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region permisos
        public Int32 Agregar_Permisos(Permisos obj/*, string usuario*/)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Tab_Permisos (Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(@Id_Perfil,@Modulo,@Agregar,@Modificar,@Consultar,@Eliminar)";
                Parameter[] parametros = {
                                                     new Parameter("@Id_Perfil",obj.Id_Perfil),
                                                     new Parameter("@Modulo",obj.Modulo),
                                                     new Parameter("@Agregar",obj.Agregar),
                                                     new Parameter("@Modificar",obj.Modificar),
                                                     new Parameter("@Consultar",obj.Consultar),
                                                     new Parameter("@Eliminar",obj.Eliminar),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return FilasAfectadas;
                //return Registrar(FilasAfectadas, usuario, "Rol", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #endregion

        #region Modificar

        #region Expedientes
        public Int32 Modificar_Expediente(Expedientes obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "UPDATE Tab_Expedientes SET Cedula = @Cedula, Nombre_Usuario = @Nombre_Usuario,Apellido1 = @Apellido1,Apellido2 = @Apellido2,Id_Perfil = @Id_Perfil,Cedula = @Cedula,Genero = @Genero,Contrasena = @Contrasena WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                                     new Parameter("@Num_Expediente",obj.Num_Expediente),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Descripcion",obj.Descripcion),
                                                     new Parameter("@Id_Tipo_Procedimiento",obj.Id_Tipo_Procedimiento),
                                                     new Parameter("@Lugar_Trabajo",obj.Lugar_Trabajo),
                                                     new Parameter("@Medida_Cautelar",obj.Medida_Cautelar),
                                                     new Parameter("@Organo_Director",obj.Organo_Director),
                                                     new Parameter("@Parte_Procesal",obj.Parte_Procesal),
                                                     new Parameter("@Estado",obj.Estado),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Casos", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Procedimiento
        public Int32 Actualizar_Procedimiento(Procedimiento uRegistro, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Procedimiento SET Nombre_Procedimiento = @Nombre_Procedimiento,Descripcion_Procedimiento=@Descripcion_Procedimiento WHERE Id_Procedimiento = @Id_Procedimiento";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Procedimiento",uRegistro.Nombre_Procedimiento),
                                         new Parameter("@Id_Procedimiento",uRegistro.Id_Procedimiento),
                                         new Parameter("@Descripcion_Procedimiento",uRegistro.Descripcion_Procedimiento),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Procedimientos", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Rol
        public Int32 Actualizar_Rol(Perfiles uRegistro, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Perfiles SET Nombre_Perfil = @Nombre_Perfil WHERE Id_Perfil = @Id_Perfil";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Perfil",uRegistro.Nombre_Perfil),
                                         new Parameter("@Id_Perfil",uRegistro.Id_Perfil),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Roles y permisos", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Usuarios
        public Int32 Actualizar_Usuario_pass(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Usuarios SET Nombre = @Nombre, Nombre_Usuario = @Nombre_Usuario,Apellido1 = @Apellido1,Apellido2 = @Apellido2,Id_Perfil = @Id_Perfil,Cedula = @Cedula,Genero = @Genero,Contrasena = @Contrasena WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                                     new Parameter("@Apellido1",obj.Apellido1),
                                                     new Parameter("@Apellido2",obj.Apellido2),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Contrasena",obj.Contrasena),
                                                     new Parameter("@Genero",obj.Genero),
                                                     new Parameter("@Id_Perfil",obj.Id_Perfil),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 Actualizar_Usuario(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Usuarios SET Nombre = @Nombre, Nombre_Usuario = @Nombre_Usuario,Apellido1 = @Apellido1,Apellido2 = @Apellido2,Id_Perfil = @Id_Perfil,Cedula = @Cedula,Genero = @Genero WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                                     new Parameter("@Apellido1",obj.Apellido1),
                                                     new Parameter("@Apellido2",obj.Apellido2),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Contrasena",obj.Contrasena),
                                                     new Parameter("@Genero",obj.Genero),
                                                     new Parameter("@Id_Perfil",obj.Id_Perfil),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Expedientes

        public Int32 Actualizar_Expendiente(Expedientes obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Expedientes SET Usuario_Generador = @Usuario_Generador,Cedula=@Cedula,Descripcion = @Descripcion,Id_Tipo_Procedimiento= @Id_Tipo_Procedimiento,Lugar_Trabajo=@Lugar_Trabajo,Medida_Cautelar=@Medida_Cautelar,Organo_Director=@Organo_Director,Parte_Procesal=@Parte_Procesal,Estado=@Estado WHERE Num_Expediente = @Num_Expediente";
                Parameter[] parametros = {
                                                     new Parameter("@Num_Expediente",obj.Num_Expediente),
                                                     new Parameter("@Usuario_Generador",obj.Usuario_Generador),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Descripcion",obj.Descripcion),
                                                     new Parameter("@Id_Tipo_Procedimiento",obj.Id_Tipo_Procedimiento),
                                                     new Parameter("@Lugar_Trabajo",obj.Lugar_Trabajo),
                                                     new Parameter("@Medida_Cautelar",obj.Medida_Cautelar),
                                                     new Parameter("@Organo_Director",obj.Organo_Director),
                                                     new Parameter("@Parte_Procesal",obj.Parte_Procesal),
                                                     new Parameter("@Estado",obj.Estado),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Expedientes", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Funcionarios

        public Int32 Actualizar_Funcionario(Funcionarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Funcionarios SET Nombre = @Nombre,Apellido1 = @Apellido1,Apellido2 = @Apellido2,Genero = @Genero WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                                     new Parameter("@Apellido1",obj.Apellido1),
                                                     new Parameter("@Apellido2",obj.Apellido2),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Genero",obj.Genero),
                                                     new Parameter("@Nombre",obj.Nombre),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Funcionarios", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #endregion

        #region Eliminar

        #region Expediente
        public Int32 EliminarExpediente(string num_expediente, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Expedientes WHERE Num_Expediente = @Num_Expediente";
                Parameter[] parametros = {
                                         new Parameter("@Num_Expediente",num_expediente),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Expedientes", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Procedimiento
        public Int32 EliminarProcedimiento(Int32 Id_Procedimiento, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Procedimiento WHERE Id_Procedimiento = @Id_Procedimiento";
                Parameter[] parametros = {
                                         new Parameter("@Id_Procedimiento",Id_Procedimiento),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Procedimientos", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Eliminar Movimientos
        public Int32 EliminarMovimientos(string User)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Bitacora_Movimientos WHERE Usuario = @Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Usuario",User),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

        #region Eliminar Sessiones
        public Int32 EliminarSessiones(string User)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Bitacora_Sesiones WHERE Usuario = @Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Usuario",User),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

        #region Usuario
        public Int32 EliminarUsuario(string Usuario, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Usuarios WHERE Nombre_Usuario = @Nombre_Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Usuario",Usuario),
                                       };
                EliminarMovimientos(Usuario);
                EliminarSessiones(Usuario);
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Funcionario
        public Int32 EliminarFuncionario(int cedula, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Funcionarios WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",cedula),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Funcionarios", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Rol
        public Int32 EliminarRol(Int32 Id_Perfil, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Perfiles WHERE Id_Perfil = @Id_Perfil";
                Parameter[] parametros = {
                                         new Parameter("@Id_Perfil",Id_Perfil),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Roles y permmisos", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Permisos
        public Int32 EliminarPermisos(Int32 Id_Perfil)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Tab_Permisos WHERE Id_Perfil = @Id_Perfil";
                Parameter[] parametros = {
                                         new Parameter("@Id_Perfil",Id_Perfil),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return FilasAfectadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #endregion

        #region Mostrar varios

        #region Mostrar_Expedientes
        public DataTable llenar_Expedientes()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Expedientes";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public DataTable llenar_Expedientes(int cedula)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Expedientes WHERE Cedula LIKE '%" + cedula + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataTable llenar_Expedientes(string num_expediente)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Expedientes WHERE Num_Expediente LIKE '%" + num_expediente + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Roles
        public DataTable llenar_Roles()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Perfiles";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Usuarios
        public DataTable llenar_Usuarios()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Usuarios";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Usuarios(int cedula)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Usuarios WHERE Cedula LIKE '%" + cedula + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Usuarios(string nombre,string apellido)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Usuarios WHERE Nombre LIKE '%" + nombre + "%' AND Apellido1 LIKE '%"+ apellido +"%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Funcionarios
        public DataTable llenar_Funcionarios()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Funcionarios";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Funcionarios(int cedula)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Funcionarios WHERE Cedula LIKE '%" + cedula + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Funcionarios(string nombre, string apellido)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Funcionarios WHERE Nombre LIKE '%" + nombre + "%' AND Apellido1 LIKE '%" + apellido + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Procedimientos
       
        public DataTable llenar_Procedimientos()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Procedimiento";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Sesiones
        public DataTable llenar_Sesiones(string Nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Bitacora_Sesiones WHERE Usuario LIKE '%" + Nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Sesiones()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Bitacora_Sesiones";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Sesiones(DateTime fecha_ini,DateTime fecha_fin)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT*FROM Tab_Bitacora_Sesiones WHERE Fecha_inicio BETWEEN '"+fecha_ini.ToString()+"' AND '"+fecha_fin.ToString()+ "'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Movimientos
        public DataTable llenar_Movimientos(string Nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Bitacora_Movimientos WHERE Usuario LIKE '%" + Nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Movimientos()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Tab_Bitacora_Movimientos";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Movimientos(DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT*FROM Tab_Bitacora_Movimientos WHERE Fecha_Hora BETWEEN '" + fecha_ini.ToString() + "' AND '" + fecha_fin.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Mostrar especifico

        #region Usuario
        public Usuarios Mostrar_Usuario_Unico(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuarios vRegistro = new Usuarios();

                string commandText = "SELECT * FROM [dbo].[Tab_Usuarios] WHERE [Cedula] =  " + pCodigo;
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
                    vRegistro.Genero = dtConsulta.Rows[0]["Genero"].ToString();
                    vRegistro.Id_Perfil = int.Parse(dtConsulta.Rows[0]["Id_Perfil"].ToString());
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
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

        #region Funcionario
        public Funcionarios Mostrar_Funcionario_Unico(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Funcionarios vRegistro = new Funcionarios();

                string commandText = "SELECT * FROM [dbo].[Tab_Funcionarios] WHERE [Cedula] =  " + pCodigo;
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
                    vRegistro.Genero = dtConsulta.Rows[0]["Genero"].ToString();
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

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

        #region Permisos
        public Permisos Mostrar_Permisos_Unico(Int32 id_perfil,Int32 modulo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Permisos vRegistro = new Permisos();

                string commandText = "SELECT * FROM [dbo].[Tab_Permisos] WHERE [Id_Perfil] =  " + id_perfil+" and [Modulo] = "+modulo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Id_Perfil = int.Parse(dtConsulta.Rows[0]["Id_Perfil"].ToString());
                    vRegistro.Modulo = int.Parse(dtConsulta.Rows[0]["Modulo"].ToString());
                    vRegistro.Agregar = dtConsulta.Rows[0]["Agregar"].ToString();
                    vRegistro.Modificar = dtConsulta.Rows[0]["Modificar"].ToString();
                    vRegistro.Consultar = dtConsulta.Rows[0]["Consultar"].ToString();
                    vRegistro.Eliminar = dtConsulta.Rows[0]["Eliminar"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Rol
        public Perfiles Mostrar_rol(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Perfiles vRegistro = new Perfiles();

                string commandText = "SELECT * FROM [dbo].[Tab_Perfiles] WHERE [Id_Perfil] =  " + pCodigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Nombre_Perfil = dtConsulta.Rows[0]["Nombre_Perfil"].ToString();
                    vRegistro.Id_Perfil = Convert.ToInt32(dtConsulta.Rows[0]["Id_Perfil"]);

                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Procedimiento
        public Procedimiento Mostrar_procedimiento(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Procedimiento vRegistro = new Procedimiento();

                string commandText = "SELECT * FROM [dbo].[Tab_Procedimiento] WHERE [Id_Procedimiento] =  " + pCodigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Nombre_Procedimiento = dtConsulta.Rows[0]["Nombre_Procedimiento"].ToString();
                    vRegistro.Descripcion_Procedimiento = dtConsulta.Rows[0]["Descripcion_Procedimiento"].ToString();
                    vRegistro.Id_Procedimiento = Convert.ToInt32(dtConsulta.Rows[0]["Id_Procedimiento"]);

                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Expediente
        public Expedientes Mostrar_Expediente_Unico(string pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Expedientes vRegistro = new Expedientes();

                string commandText = "SELECT * FROM [dbo].[Tab_Expedientes] WHERE [Num_Expediente] =  '" + pCodigo+"'";
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
                    vRegistro.Descripcion = dtConsulta.Rows[0]["Descripcion"].ToString();
                    vRegistro.Id_Tipo_Procedimiento = int.Parse(dtConsulta.Rows[0]["Id_Tipo_Procedimiento"].ToString());
                    vRegistro.Lugar_Trabajo = dtConsulta.Rows[0]["Lugar_Trabajo"].ToString();
                    vRegistro.Medida_Cautelar = dtConsulta.Rows[0]["Medida_Cautelar"].ToString();
                    vRegistro.Num_Expediente = dtConsulta.Rows[0]["Num_Expediente"].ToString();
                    vRegistro.Organo_Director = dtConsulta.Rows[0]["Organo_Director"].ToString();
                    vRegistro.Parte_Procesal = dtConsulta.Rows[0]["Parte_Procesal"].ToString();
                    vRegistro.Usuario_Generador = dtConsulta.Rows[0]["Usuario_Generador"].ToString();
                    vRegistro.Estado = dtConsulta.Rows[0]["Estado"].ToString();
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

        #region Registrar
        public Int32 Registrar(Int32 FilasAfectadas, string usuario, string Tabla, string Accion)
        {
            if (FilasAfectadas > 0)
            {
                Int32 f2 = 0;
                string sentencia;
                sentencia = "INSERT INTO Tab_Bitacora_Movimientos (Accion,Fecha_Hora,Modulo,Usuario) VALUES(@Accion,getdate(),@modulo,@Usuario);";
                Parameter[] parametrosa = {
                                                     new Parameter("@Usuario",usuario),
                                                     new Parameter("@Accion",Accion),
                                                     new Parameter("@modulo",Tabla),
                                              };
                f2 = Database.exectuteNonQuery(sentencia, parametrosa);
                if (f2 > 0)
                {

                }
                else
                {
                    FilasAfectadas = -1;
                }
            }
            else
            {
                FilasAfectadas = 0;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Metodo Ingresar Sesion
        public Int32 Ingresar(Sesiones obj)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                Int32 Id_Session = 0;
                string sentencia;
                sentencia = "insert into Tab_Bitacora_Sesiones (Usuario,Fecha_inicio,Direccion_Ip) values(@Usuario,@Ingreso,@Dip)";
                Parameter[] parametros = {
                                                     new Parameter("@Usuario",obj.Usuario),
                                                     new Parameter("@Ingreso",obj.Fecha_inicio),
                                                    // new Parameter("@Salida",obj.Salida),
                                                     new Parameter("@Dip",obj.Direccion_Ip),
                };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                if (FilasAfectadas > 0)
                {
                    Id_Session = Obtenerid();
                }
                return Id_Session;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Int32 Obtenerid()
        {
            Int32 Respuesta = 0;

            string sentencia;
            DataSet data = null;
            sentencia = "SELECT TOP 1 * FROM Tab_Bitacora_Sesiones ORDER BY Id_Sesion DESC";
            Parameter[] parametros = { new Parameter("",0)
                                         };
            data = Database.executeDataset(sentencia, parametros);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                Respuesta = (Int32)row["Id_Sesion"];
            }
            return Respuesta;
        }

        #endregion

        #region Salida Sesion
        public Int32 Salir(Sesiones obj)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Tab_Bitacora_Sesiones SET fecha_Salio=@Salida WHERE Id_Sesion = @Id_Sesion";
                Parameter[] parametros = {
                                                     new Parameter("@Salida",obj.fecha_Salio),
                                                     new Parameter("@Id_Sesion",obj.Id_Sesion),
                };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion
    }
}
