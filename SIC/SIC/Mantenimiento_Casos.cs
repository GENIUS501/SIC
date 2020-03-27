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

        private void Llenar_cbo_estado()
        {
            try
            {
                this.cbo_estado.DisplayMember = "Text";
                this.cbo_estado.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Activo", Value = "Activo" },
                                    new { Text = "Concluido", Value = "Concluido" },
                                    };
                this.cbo_estado.DataSource = items;
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
                Llenar_cbo_estado();
                // TODO: esta línea de código carga datos en la tabla 'sICDataSet1.Tab_Procedimiento' Puede moverla o quitarla según sea necesario.
                this.tab_ProcedimientoTableAdapter.Fill(this.sICDataSet1.Tab_Procedimiento);
                this.cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cbo_parte_procesal.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cbo_tipo_procedimiento.DropDownStyle = ComboBoxStyle.DropDownList;
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }finally
            {
                this.Close();
            }
        }

        private void btn_acpetar_Click(object sender, EventArgs e)
        {

        }
    }
}
