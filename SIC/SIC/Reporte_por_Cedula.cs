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
    public partial class Reporte_por_Cedula : Form
    {
        public string usuario { get; set; }
        Gestor Negocios;
        public Reporte_por_Cedula()
        {
            InitializeComponent();
        }

        private void Reporte_por_Cedula_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_expedientes.ReadOnly = true;
                Negocios = new Gestor();
                this.dat_expedientes.DataSource = Negocios.llenar_expedientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_generar_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_cedula.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_expedientes.DataSource = Negocios.llenar_expedientes(int.Parse(this.txt_cedula.Text));
                }
                else
                {
                    MessageBox.Show("Debe digitar la cedula!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_cedula.Text != "")
                {
                    Visor_Reporte_Expediente_Cedula frm = new Visor_Reporte_Expediente_Cedula();
                    frm.Usuario = usuario;
                    frm.Cedula = int.Parse(this.txt_cedula.Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Debe digitar la cedula!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                Visor_Reporte_Expediente frm = new Visor_Reporte_Expediente();
                frm.Usuario = usuario;
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
    }
}
