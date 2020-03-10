using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Gestor
    {
        #region Agregar
       
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
        public Permisos Mostrar_Paquete_Unico(Int32 id_perfil,Int32 modulo)
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
        #endregion
    }
}
