using Microsoft.Reporting.WinForms;
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
    public partial class Visor_Reporte_Expediente_Cedula : Form
    {
        public string Usuario { get; set; }
        public int Cedula { get; set; }
        public Visor_Reporte_Expediente_Cedula()
        {
            InitializeComponent();
        }

        private void Visor_Reporte_Estado_Cedula_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SICDataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
                this.DataTable1TableAdapter.Fill(this.SICDataSet1.DataTable1);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Cedula", Cedula.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
