using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Expedientes
    {
        #region Atributos
        public int Cedula { get; set; }
        public string Usuario_Generador { get; set; }
        public string Num_Expediente { get; set; }
        public string Lugar_Trabajo { get; set; }
        public string Descripcion { get; set; }
        public string Medida_Cautelar { get; set; }
        public int Id_Tipo_Procedimiento { get; set; }
        public string Organo_Director { get; set; }
        #endregion

        #region Constructor sin parametros
        public Expedientes()
        {
            Cedula = 0;
            Usuario_Generador = "";
            Num_Expediente = "";
            Lugar_Trabajo = "";
            Descripcion = "";
            Medida_Cautelar = "";
            Id_Tipo_Procedimiento = 0;
            Organo_Director = "";
        }
        #endregion

        #region Constructos con parametros
        public Usuarios(int cedula, string nombre_usuario, string nombre, string apellido1, string apellido2, string contrasena, int id_perfil, string genero)
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
