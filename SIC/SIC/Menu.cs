﻿using Negocios;
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
        Permisos perm;
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
                perm = new Permisos();
                Negocios = new Gestor();
                this.lbl_Usuario.Text = usuario;
                mantenimientoDeRolesYPermisosToolStripMenuItem.Visible = false;
                mantenimientoDeUsuariosToolStripMenuItem.Visible = false;
                mantenimientoDeFuncionariosToolStripMenuItem.Visible = false;
                mantenimientoDeCasosToolStripMenuItem.Visible = false;
                bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Visible = false;
                bitacoraDeMovimientosToolStripMenuItem.Visible = false;
                int i = 1;
                while(i<7)
                {
                    perm = Negocios.Mostrar_Paquete_Unico(Id_Perfil, i);
                    if (perm.Modulo == i)
                    {
                        switch (i)
                        {
                            case 1:
                                mantenimientoDeRolesYPermisosToolStripMenuItem.Visible = true;
                                break;
                            case 2:
                                mantenimientoDeUsuariosToolStripMenuItem.Visible = true;
                                break;
                            case 3:
                                mantenimientoDeFuncionariosToolStripMenuItem.Visible = true;
                                break;
                            case 4:
                                mantenimientoDeCasosToolStripMenuItem.Visible = true;
                                break;
                            case 5:
                                bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Visible = true;
                                break;
                            case 6:
                                bitacoraDeMovimientosToolStripMenuItem.Visible = true;
                                break;
                        }
                    }
                    i++;
                }
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
            try
            {
                Lista_Usuario frm = new Lista_Usuario();
                frm.Id_Perfil = Id_Perfil;
                frm.usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
