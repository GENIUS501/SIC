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
    public partial class Lista_Usuario : Form
    {
        Gestor Negocios;
        Permisos perm;
        int valor_celda = -1;
        public string usuario { get; set; }
        public int Id_Perfil { get; set; }
        public Lista_Usuario()
        {
            InitializeComponent();
        }

        private void Lista_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                perm = new Permisos();
                Negocios = new Gestor();
                this.btn_agregar.Enabled = false;
                this.btn_consultar.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_eliminar.Enabled = false;
                this.dat_usuarios.DataSource = Negocios.llenar_Usuarios();
                perm = Negocios.Mostrar_Permisos_Unico(Id_Perfil, 2);
                if (perm.Agregar == "S")
                {
                    this.btn_agregar.Enabled = true;
                }
                if (perm.Modificar == "S")
                {
                    this.btn_editar.Enabled = true;
                }
                if (perm.Eliminar == "S")
                {
                    this.btn_eliminar.Enabled = true;
                }
                if (perm.Consultar == "S")
                {
                    this.btn_consultar.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento_Usuarios frm = new Mantenimiento_Usuarios();
                frm.Accion = "A";
                frm.Usuario = usuario;
                frm.Text = "Mantenimiento de usuarios: Agregar usuario.";
                frm.ShowDialog();
                Lista_Usuario_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try {
                this.dat_usuarios.DataSource = Negocios.llenar_Usuarios(int.Parse(this.txt_buscar_cedula.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    Lista_Usuario_Load(null, null);
                }
                else
                {
                    valor_celda = Convert.ToInt32(this.dat_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Usuarios frm = new Mantenimiento_Usuarios();
                    frm.Accion = "M";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de usuarios: Modificar usuarios.";
                    frm.ShowDialog();
                    Lista_Usuario_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Usuarios frm = new Mantenimiento_Usuarios();
                    frm.Accion = "E";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de usuarios: Eliminar usuarios.";
                    frm.ShowDialog();
                    Lista_Usuario_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Usuarios frm = new Mantenimiento_Usuarios();
                    frm.Accion = "C";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de usuarios: Consultar usuarios.";
                    frm.ShowDialog();
                    Lista_Usuario_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
