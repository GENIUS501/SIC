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
    public partial class Mantenimiento_Usuarios : Form
    {
        public Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }
     /*   private void LlenarCombo()
        {
            try
            {
                this.Cbo_Rol.DisplayMember = "Text";
                this.Cbo_Rol.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Administrador", Value = "1" },
                                    new { Text = "Consultor", Value = "2" },
                                    new { Text = "Auditor", Value = "3" },
                                    };
                this.Cbo_Rol.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }*/
        private void Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
