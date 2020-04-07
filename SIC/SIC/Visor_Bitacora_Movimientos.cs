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
    public partial class Visor_Bitacora_Movimientos : Form
    {
        public string Usuario { get; set; }
        public Visor_Bitacora_Movimientos()
        {
            InitializeComponent();
        }

        private void Visor_Bitacora_Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SICDataSet1.Tab_Bitacora_Movimientos' Puede moverla o quitarla según sea necesario.
                this.Tab_Bitacora_MovimientosTableAdapter.Fill(this.SICDataSet1.Tab_Bitacora_Movimientos);
                ReportParameter[] parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
