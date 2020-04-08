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
        Sesiones ses;
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

            try
            {
                ses = new Sesiones();
                Negocios = new Gestor();
                Int32 FilasAfectadas;
                ses.Id_Sesion = Id_Session;
                ses.fecha_Salio = DateTime.Now;
                FilasAfectadas = Negocios.Salir(ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ses = new Sesiones();
                Negocios = new Gestor();
                Int32 FilasAfectadas;
                ses.Id_Sesion = Id_Session;
                ses.fecha_Salio = DateTime.Now;
                FilasAfectadas = Negocios.Salir(ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    perm = Negocios.Mostrar_Permisos_Unico(Id_Perfil, i);
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
                            case 7:
                                mantenimientoDeProcedimientosToolStripMenuItem.Visible = true;
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
            try
            {
                Lista_Funcionarios frm = new Lista_Funcionarios();
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

        private void mantenimientoDeCasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Casos frm = new Lista_Casos();
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

        private void reportePorExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_numero_expediente frm = new Reporte_numero_expediente();
                frm.usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteDeEstadoDelExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_Estado_Expediente frm = new Reporte_Estado_Expediente();
                // frm.Id_Perfil = Id_Perfil;
                frm.usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteAsociadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_por_Cedula frm = new Reporte_por_Cedula();
                // frm.Id_Perfil = Id_Perfil;
                // frm.usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mantenimientoDeRolesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_de_Roles frm = new Lista_de_Roles();
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
            try
            {
                Bitacora_Sesiones frm = new Bitacora_Sesiones();
                //frm.Id_Perfil = Id_Perfil;
                frm.Usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitacoraDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora_Movimientos frm = new Bitacora_Movimientos();
                frm.Usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cambiar_Contrasena frm = new Cambiar_Contrasena();
                frm.Usuario = usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Procedimiento frm = new Lista_Procedimiento();
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
    }
}
