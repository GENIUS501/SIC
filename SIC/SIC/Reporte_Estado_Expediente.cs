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
    public partial class Reporte_Estado_Expediente : Form
    {
        Gestor Negocios;
        public string usuario { get; set; }
        public Reporte_Estado_Expediente()
        {
            InitializeComponent();
        }

        private void Reporte_Estado_Expediente_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_expedientes.ReadOnly = true;
                Negocios = new Gestor();
                this.dat_expedientes.DataSource = Negocios.llenar_expedientes_estado();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_generar_expediente_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_numero_expediente.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_expedientes.DataSource = Negocios.llenar_expedientes_estado(this.txt_numero_expediente.Text);
                }
                else
                {
                   MessageBox.Show("Debe digitar el numero de expediente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_expediente_Click(object sender, EventArgs e)
        {
            try
            {

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
