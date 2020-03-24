using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Procedimiento
    {
        #region Atributos
        public int Id_Procedimiento { get; set; }
        public string Nombre_Procedimiento { get; set; }
        public string Descripcion_Procedimiento { get; set; }
        #endregion

        #region Constructor sin parametros
        public Procedimiento()
        {
            Id_Procedimiento = 0;
            Nombre_Procedimiento = "";
            Descripcion_Procedimiento = "";
        }
        #endregion

        #region Constructos con parametros
        public Procedimiento(int id_procedimiento, string nombre_procedimiento, string descripcion_procedimiento)
        {
            Id_Procedimiento = id_procedimiento;
            Nombre_Procedimiento = nombre_procedimiento;
            Descripcion_Procedimiento = descripcion_procedimiento;
        }
        #endregion
    }
}
