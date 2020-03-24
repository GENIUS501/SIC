using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Gestor
    {
        #region Agregar

        #region Procedimiento
        public Int32 AgregarProcedimiento(Procedimiento obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Procedimiento(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Funcionarios
        public Int32 AgregarFuncionario(Funcionarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Funcionario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuarios
        public Int32 AgregarUsuarios(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Usuario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region rol
        public Int32 AgregarRol(Perfiles rol, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Rol(rol, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region permisos
        public Int32 AgregarPermisos(Permisos permi/*, string usuario*/)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Permisos(permi/*, usuario*/);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Actualizar

        #region Funcionario

        public Int32 Modificar_Funcionario(Funcionarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Funcionario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuario
        public Int32 Modificar_Usuario_pass(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Usuario_pass(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }

        public Int32 Modificar_Usuario(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Usuario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Rol
        public Int32 ModificarRol(Perfiles rol, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Rol(rol, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Eliminar

        #region Funcionario
        public Int32 Eliminar_Funcionario(int cedula, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarFuncionario(cedula, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuario
        public Int32 Eliminar_Usuario(string Usuario, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarUsuario(Usuario, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Rol
        public Int32 EliminarRol(Int32 id_perfil, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarRol(id_perfil, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Permisos
        public Int32 EliminarPermisos(Int32 id_perfil)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarPermisos(id_perfil);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Mostrar varios

        #region Rol
        public DataTable llenar_Roles()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Roles();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Funcionario
        public DataTable llenar_Funcionarios()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Funcionarios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Funcionarios(int cedula)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Funcionarios(cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Funcionarios(string nombre, string apellido)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Funcionarios(nombre, apellido);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Usuario
        public DataTable llenar_Usuarios()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Usuarios(int cedula)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios(cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Usuarios(string nombre,string apellido)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios(nombre,apellido);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Rol
        public DataTable llenar_Procedimientos()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Procedimientos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #endregion

        #region Mostrar especifico

        #region Usuario
        public Usuarios Mostrar_Usuario_Unico(Int32 pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Usuario_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Funcionario
        public Funcionarios Mostrar_Funcionario_Unico(Int32 pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Funcionario_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Login
        public Usuarios Login(string User, string Pass)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Login(User, Pass);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Permisos
        public Permisos Mostrar_Permisos_Unico(Int32 id_perfil,Int32 modulo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Permisos_Unico(id_perfil,modulo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Rol
        public Perfiles Mostrar_Rol(Int32 pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_rol(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #endregion
    }
}
