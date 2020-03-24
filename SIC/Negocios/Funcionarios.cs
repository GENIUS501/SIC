using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Funcionarios
    {
        #region Atributos
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Genero { get; set; }
        #endregion

        #region Constructor sin parametros
        public Funcionarios()
        {
            Cedula = 0;
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Genero = "";
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
