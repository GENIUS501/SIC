﻿using System;
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
    public partial class Visor_Bitacora_Sesiones_Usuario : Form
    {
        public Visor_Bitacora_Sesiones_Usuario()
        {
            InitializeComponent();
        }

        private void Visor_Bitacora_Sesiones_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SICDataSet1.Tab_Bitacora_Sesiones' Puede moverla o quitarla según sea necesario.
                this.Tab_Bitacora_SesionesTableAdapter.Fill(this.SICDataSet1.Tab_Bitacora_Sesiones);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
