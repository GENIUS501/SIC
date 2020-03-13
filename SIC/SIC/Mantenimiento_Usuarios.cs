using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace SIC
{
    public partial class Mantenimiento_Usuarios : Form
    {
        public string Accion { get; set; }
        public string Usuario { get; set; }
        Gestor Negocios;
        Usuarios Usua;
        public Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }
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
        private void Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sICDataSet.Tab_Perfiles' Puede moverla o quitarla según sea necesario.
                this.tab_PerfilesTableAdapter.Fill(this.sICDataSet.Tab_Perfiles);
                Llenar_cbo_genero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A" || Accion == "M")
                {
                    Negocios = new Gestor();
                    Usua = new Usuarios();
                    Usua.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
