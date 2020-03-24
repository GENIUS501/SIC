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
    public partial class Mantenimiento_Funcionarios : Form
    {
        public Mantenimiento_Funcionarios()
        {
            InitializeComponent();
        }
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public int Cedula { get; set; }
        private void Llenar_cbo_genero()
        {
            try
            {
                this.cbo_genero.DisplayMember = "Text";
                this.cbo_genero.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Masculino", Value = "M" },
                                    new { Text = "Femenino", Value = "F" },
                                    };
                this.cbo_genero.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        private void Mantenimiento_Funcionarios_Load(object sender, EventArgs e)
        {
            try {
                Llenar_cbo_genero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
