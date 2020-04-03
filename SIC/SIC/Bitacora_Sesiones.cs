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
    public partial class Bitacora_Sesiones : Form
    {
        public string Usuario { get; set; }
        public Bitacora_Sesiones()
        {
            InitializeComponent();
        }

        Gestor Negocios;
        private void Bitacora_Sesiones_Load(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_sesiones.DataSource = Negocios.llenar_sesiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Bitacora_sesiones frm = new Visor_Bitacora_sesiones();
                frm.Usuario = Usuario;
                frm.MdiParent = this.MdiParent;
                frm.Show();
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

        private void btn_generar_bit_usua_Click(object sender, EventArgs e)
        {
            Negocios = new Gestor();
            this.dat_sesiones.DataSource = Negocios.llenar_sesiones(this.txt_usuario.Text);
        }

        private void btn_imprimir_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_fecha_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
