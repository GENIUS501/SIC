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
        #endregion

        #endregion

        #region Mostrar especifico

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
