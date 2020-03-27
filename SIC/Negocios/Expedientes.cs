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
        public string Parte_Procesal { get; set; }
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
            Parte_Procesal = "";
            Lugar_Trabajo = "";
            Descripcion = "";
            Medida_Cautelar = "";
            Id_Tipo_Procedimiento = 0;
            Organo_Director = "";
        }
        #endregion

        #region Constructos con parametros
        public Expedientes(int cedula, string usuario_generador, string num_expediente,string parte_procesal, string lugar_trabajo, string descripcion, string medida_cautelar, int id_tipo_procedimiento, string organo_director)
        {
            Cedula = cedula;
            Usuario_Generador = usuario_generador;
            Num_Expediente = num_expediente;
            Parte_Procesal = parte_procesal;
            Lugar_Trabajo = lugar_trabajo;
            Descripcion = descripcion;
            Medida_Cautelar = medida_cautelar;
            Id_Tipo_Procedimiento = id_tipo_procedimiento;
            Organo_Director = organo_director;
        }
        #endregion
    }
}
