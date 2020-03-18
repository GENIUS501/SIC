using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Usuarios
    {
        #region Atributos
        public int Cedula { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Contrasena { get; set; }
        public int Id_Perfil { get; set; }
        public string Genero { get; set; }
        #endregion

        #region Constructor sin parametros
        public Usuarios()
        {
            Cedula = 0;
            Nombre_Usuario = "";
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Contrasena = "";
            Id_Perfil = 0;
            Genero = "";
        }
        #endregion

        #region Constructos con parametros
        public Usuarios(int cedula, string nombre_usuario, string nombre, string apellido1, string apellido2, string contrasena,int id_perfil,string genero)
        {
            Cedula = cedula;
            Nombre_Usuario = nombre_usuario;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Contrasena = contrasena;
            Id_Perfil = id_perfil;
            Genero = genero;
        }
        #endregion
    }
}
