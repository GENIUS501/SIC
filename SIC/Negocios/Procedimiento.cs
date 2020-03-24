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

        #region Constructor sin parametros
        public Procedimiento()
        {
            Id_Procedimiento = 0;
            Nombre_Procedimiento = "";
            Descripcion_Procedimiento = "";
        }
        #endregion

        #region Constructos con parametros
        public Funcionarios(int cedula, string nombre, string apellido1, string apellido2, string genero)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Genero = genero;
        }
        #endregion
    }
}
