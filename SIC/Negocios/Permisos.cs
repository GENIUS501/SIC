using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Permisos
    {
        #region Atributos
        public int Id_Perfil { get; set; }
        public int Modulo { get; set; }
        public string Agregar { get; set; }
        public string Consultar { get; set; }
        public string Modificar { get; set; }
        public string Eliminar { get; set; }
        #endregion

        #region Constructor sin parametros
        public Permisos()
        {
            Id_Perfil = 0;
            Modulo = 0;
            Agregar = "N";
            Consultar = "N";
            Modificar = "N";
            Eliminar = "N";
        }
        #endregion

        #region Constructos con parametros
        public Permisos(int id_perfil, int modulo, string agregar, string consultar, string modificar, string eliminar)
        {
            Id_Perfil = id_perfil;
            Modulo = modulo;
            Agregar = agregar;
            Consultar = consultar;
            Modificar = modificar;
            Eliminar = eliminar;
        }
        #endregion
    }
}
