using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC
{
    public partial class Mantenimiento_Casos : Form
    {
        public Mantenimiento_Casos()
        {
            InitializeComponent();
        }

        public string Accion { get; set; }
        public string Usuario { get; set; }
        public string Num_Expediente { get; set; }
        Gestor Negocios;
        Expedientes Exp;

        private void Llenar_cbo_parte_procesal()
        {
            try
            {
                this.cbo_parte_procesal.DisplayMember = "Text";
                this.cbo_parte_procesal.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Investigado", Value = "Investigado" },
                                    new { Text = "Ofendido", Value = "Ofendido" },
                                    new { Text = "Empresa", Value = "Empresa" },
                                    };
                this.cbo_parte_procesal.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        private void Mantenimiento_Casos_Load(object sender, EventArgs e)
        {
            try
            {
                Llenar_cbo_parte_procesal();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
