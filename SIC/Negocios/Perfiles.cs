using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Perfiles
    {
        #region Atributos
        public int Id_Perfil { get; set; }
        public string Nombre_Perfil { get; set; }
        #endregion

        #region Constructor sin parametros
        public Perfiles()
        {
            Id_Perfil = 0;
            Nombre_Perfil = "";
        }
        #endregion

        #region Constructos con parametros
        public Perfiles(int id_perfil, string nombre_perfil)
        {
            Id_Perfil = id_perfil;
            Nombre_Perfil = nombre_perfil;
        }
        #endregion
    }
}
