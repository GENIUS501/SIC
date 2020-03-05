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
    public partial class Menu : Form
    {
        //Sesiones ses;
        Gestor Negocios;
        public string usuario { get; set; }
        public int Id_Session { get; set; }
        public int Id_Perfil { get; set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                this.lbl_Usuario.Text = usuario;
                //if (Id_Perfil > 1)
                //{
                //    reporteDePagosToolStripMenuItem.Visible = false;
                //    seguridadToolStripMenuItem.Visible = false;
                //    mantenimientoDePaquetesToolStripMenuItem.Visible = false;
                //    pagoDeProductosToolStripMenuItem.Visible = false;
                //    bitacorasToolStripMenuItem.Visible = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeCasosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportePorExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeEstadoDelExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteAsociadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeRolesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
