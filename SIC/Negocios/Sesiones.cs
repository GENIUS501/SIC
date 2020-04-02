using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Sesiones
    {
        #region Atributos
        public int Id_Sesion { get; set; }
        public DateTime Fecha_inicio{ get; set; }
        public DateTime fecha_Salio { get; set; }
        public string Usuario { get; set; }
        public string Direccion_Ip { get; set; }
        #endregion

        #region Constructor sin parametros
        public Sesiones()
        {
            Id_Sesion = 0;
            Fecha_inicio = DateTime.Now;
            fecha_Salio = DateTime.Now;
            Usuario = "";
            Direccion_Ip = "";
        }
        #endregion

        #region Constructos con parametros
        public Sesiones(int id_sesiones, DateTime fecha_inicio,DateTime fecha_salio,string usuario,string direccion_ip)
        {
            Id_Sesion = id_sesiones;
            Fecha_inicio = fecha_inicio;
            fecha_salio = fecha_Salio;
            Usuario = usuario;
            Direccion_Ip = direccion_ip;
        }
        #endregion
    }
}
