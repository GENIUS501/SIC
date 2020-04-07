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
    public partial class Bitacora_Movimientos : Form
    {
        Gestor Negocios;
        public string Usuario { get; set; }
        public Bitacora_Movimientos()
        {
            InitializeComponent();
        }

        private void Bitacora_Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_movimientos.ReadOnly = true;
                Negocios = new Gestor();
                this.dat_movimientos.DataSource = Negocios.llenar_movimientos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Bitacora_Movimientos frm = new Visor_Bitacora_Movimientos();
                frm.Usuario = Usuario;
                frm.MdiParent = this.MdiParent;
                frm.Show();
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
                Negocios = new Gestor();
                this.dat_movimientos.DataSource = Negocios.llenar_movimientos(Convert.ToDateTime(this.txt_fecha_ini.Text),Convert.ToDateTime(this.txt_fecha_fin.Text));
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

        private void btn_generar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_movimientos.DataSource = Negocios.llenar_movimientos(this.Txt_Usuario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Bitacora_Movimientos_Usuario frm = new Visor_Bitacora_Movimientos_Usuario();
                frm.Usuario = Usuario;
                frm.Usua = this.Txt_Usuario.Text;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
